using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.FileIO;

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
            string filename = GenerateFilename(SaveType.Screenshot);
            Logger.Log("Saving " + filename);
            image.Save(filename, ImageFormat.Jpeg);
            Logger.Log("Saved " + filename);
            return GetExternalAdressFromPath(filename);
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
            var filename = GenerateFilename(SaveType.Zip);
            ZipFile.CreateFromDirectory(path, filename, CompressionLevel.Optimal, false);
            return GetExternalAdressFromPath(filename);
        }

        public string SaveZipFromMultipleFiles(List<string> paths)
        {
            var filename = GenerateFilename(SaveType.Zip);
            Logger.Log("Creating " + filename);
            var zip = ZipFile.Open(filename, ZipArchiveMode.Create);
            for (int i = 0; i < paths.Count; i++)
            {
                Logger.Log("Adding file " + i + " of " + paths.Count + "(" + paths[i] + ")");
                zip.CreateEntryFromAny(paths[i]);
            }
            zip.Dispose();
            return GetExternalAdressFromPath(filename);
        }

        public string SaveFile(string path)
        {
            Logger.Log("Copying " + path);
            if (settings.ShouldShowProgressbar && new FileInfo(path).Length * 1000 >= settings.PopProgressDialogThreshold)
            {
                FileSystem.CopyFile(
                    path,
                    settings.WebPath + Path.GetFileName(path),
                    UIOption.AllDialogs,
                    UICancelOption.DoNothing
                );
            }
            else if(settings.ShouldAutoResolveFilenames)
            {
                File.Copy(path, GenerateFilename(SaveType.File, path));
            }
            else
            {
                FileSystem.CopyFile(
                    path,
                    settings.WebPath + Path.GetFileName(path),
                    UIOption.OnlyErrorDialogs,
                    UICancelOption.DoNothing
                );
            }
            Logger.Log("Copied " + path);
            return settings.ExternalAdress + Uri.EscapeDataString(Path.GetFileName(path));
        }

        public void DeleteWebPathContents()
        {
            if (settings.WebPath.Length > 5)
            {
                if (settings.DeleteOnExit)
                {
                    var sendToTrash = RecycleOption.SendToRecycleBin;
                    if (!settings.MoveToTrash) sendToTrash = RecycleOption.DeletePermanently;
                    var directory = new DirectoryInfo(settings.WebPath);
                    foreach (FileInfo file in directory.EnumerateFiles())
                    {
                        FileSystem.DeleteFile(file.FullName, UIOption.OnlyErrorDialogs, sendToTrash);
                    }
                    foreach (DirectoryInfo dir in directory.EnumerateDirectories())
                    {
                        FileSystem.DeleteDirectory(dir.FullName, UIOption.OnlyErrorDialogs, sendToTrash);
                    }
                }
            }
        }

        private string GenerateFilename(SaveType type,string originalFilename = null)
        {
            switch (type)
            {
                case SaveType.Screenshot:
                    return DateTime.Now.ToString(settings.ScreenshotDateTimeFormatString, CultureInfo.InvariantCulture) + ".jpeg";
                    
                case SaveType.Zip:
                    return GenerateFilenameForZip(originalFilename);

                case SaveType.File:
                    return GenerateFilenameForFile(originalFilename);
            }
            throw new InvalidEnumArgumentException("Invalid SaveType");
        }

        private string GenerateFilenameForZip(string originalFilename = null)
        {
            if (string.IsNullOrEmpty(originalFilename))
            {
                return settings.WebPath + Guid.NewGuid() + ".zip";
            }
            int i = 0;
            while (File.Exists(settings.WebPath + Uri.EscapeDataString(new DirectoryInfo(originalFilename).Name) + (i == 0 ? "" : i.ToString(CultureInfo.InvariantCulture)) + ".zip"))
            {
                i++;
            }
            return settings.WebPath + Uri.EscapeDataString(new DirectoryInfo(originalFilename).Name) + (i == 0 ? "" : i.ToString(CultureInfo.InvariantCulture)) + ".zip";
        }

        private string GenerateFilenameForFile(string originalFilename = null)
        {

            if (File.Exists(settings.WebPath + Uri.EscapeDataString(Path.GetFileName(originalFilename)))) {
                int i = 0;
                while(File.Exists(settings.WebPath + Uri.EscapeDataString(Path.GetFileNameWithoutExtension(originalFilename) + i.ToString(CultureInfo.InvariantCulture) + Path.GetExtension(originalFilename))))
                {
                    i++;
                }
                return settings.WebPath + Uri.EscapeDataString(Path.GetFileNameWithoutExtension(originalFilename) + i.ToString(CultureInfo.InvariantCulture) + Path.GetExtension(originalFilename));
            }
            else
            {
                return settings.WebPath + Uri.EscapeDataString(Path.GetFileName(originalFilename));
            }
        }

        private string GetExternalAdressFromPath(string path)
        {
            return settings.ExternalAdress + Path.GetFileName(path);
        }
    }
}

enum SaveType
{
    Screenshot, Zip, File
}