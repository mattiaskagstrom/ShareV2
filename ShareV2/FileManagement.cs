using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Web;

namespace ShareV2
{
    class FileManagement
    {
        private readonly ApplicationSettings settings;

        private readonly ILogInterface Logger;

        public FileManagement(ApplicationSettings settings, ILogInterface log)
        {
            this.settings = settings;
            Logger = log;
        }

        public string SaveImage(Image image)
        {

            string filename = DateTime.Now.ToString(settings.ScreenshotDateTimeFormatString) + ".jpeg";
            image.Save(settings.WebPath + filename, ImageFormat.Jpeg);
            return settings.ExternalAdress + filename;
        }

        public string SaveFileOrDirectory(string path)
        {
            if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
            {
                return SaveDirectory(path);
            }
            else
            {
                return SaveFile(path);
            }
        }

        public string SaveDirectory(string path)
        {
            int i = 0;
            while (File.Exists(settings.WebPath + HttpUtility.UrlEncode(new DirectoryInfo(path).Name) + (i == 0 ? "" : i.ToString()) + ".zip"))
            {
                i++;
            }
            ZipFile.CreateFromDirectory(path, settings.WebPath + HttpUtility.UrlEncode(new DirectoryInfo(path).Name) + (i == 0 ? "" : i.ToString()) + ".zip", CompressionLevel.Optimal, false);
            return settings.ExternalAdress + HttpUtility.UrlEncode(new DirectoryInfo(path).Name) + (i == 0 ? "" : i.ToString()) + ".zip";
        }

        public string SaveZipFromMultipleFiles(List<string> paths)
        {
            string filename = Guid.NewGuid() + ".zip";
            Logger.Log("Creating " + filename);
            var zip = ZipFile.Open(settings.WebPath + filename, ZipArchiveMode.Create);
            for (int i = 0; i < paths.Count; i++)
            {
                Logger.Log("Adding file " + i + " of " + paths.Count + "(" + paths[i] + ")");
                zip.CreateEntryFromAny(paths[i]);
            }
            zip.Dispose();
            return settings.ExternalAdress + filename;
        }

        public string SaveFile(string path)
        {
            Logger.Log("Copying " + path);
            if (settings.ShouldShowProgressbar && new FileInfo(path).Length * 1000 >= settings.PopProgressDialogThreshold)
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(
                    path,
                    settings.WebPath + HttpUtility.UrlEncode(Path.GetFileName(path)),
                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                    Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException
                );
            }
            else
            {
                File.Copy(path, settings.WebPath + HttpUtility.UrlEncode(Path.GetFileName(path)), true);
            }
            Logger.Log("Copied " + path);
            return settings.ExternalAdress + HttpUtility.UrlEncode(Path.GetFileName(path));
        }

        public void DeleteWebPathContents()
        {
            if (settings.WebPath.Length > 5)
            {
                if (settings.DeleteOnExit)
                {
                    var sendToTrash = Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin;
                    if (!settings.MoveToTrash) sendToTrash = Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently;
                    var directory = new DirectoryInfo(settings.WebPath);
                    foreach (FileInfo file in directory.EnumerateFiles())
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file.FullName, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, sendToTrash);
                    }
                    foreach (DirectoryInfo dir in directory.EnumerateDirectories())
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(dir.FullName, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, sendToTrash);
                    }
                }
            }
        }
    }
}
