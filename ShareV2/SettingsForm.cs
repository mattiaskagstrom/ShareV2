using Microsoft.Win32;
using ShareV2.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text.Json;
using System.Windows.Forms;
using static ShareV2.DrawingFormOverlay;

namespace ShareV2
{
    public partial class SettingsForm : Form
    {
        KeyboardHook Hook;
        static readonly string SettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ShareV2\\ApplicationSettings.json";
        static readonly ApplicationSettings settings = LoadSettings(SettingsPath);
        FileManagement FileManagement;
        readonly LogForm logForm = new LogForm();
        readonly List<Form> overlayForms = new List<Form>();
        RecorderForm recorderForm;
        public SettingsForm()
        {
            InitializeComponent();
            TxtExternalAdress.Text = settings.ExternalAdress;
            TxtWebLocation.Text = settings.WebPath;
            ChbDeleteOnExit.Checked = settings.DeleteOnExit;
            ChbSendToTrash.Enabled = settings.DeleteOnExit;
            ChbStartWithWindows.Checked = settings.StartWithWindows;
            ChbSendToTrash.Checked = settings.MoveToTrash;
            ChbAddIndexToWebPath.Checked = settings.AddIndexToWebPath;
            SystemEvents.SessionEnding += SystemEvents_SessionEnding;
            DropdownModifier1.SelectedIndex = DropdownModifier1.FindString(settings.ModifierKeys[0].ToString());
            DropdownModifier2.SelectedIndex = DropdownModifier2.FindString(settings.ModifierKeys[1].ToString());
            DropdownKey.SelectedIndex = DropdownKey.FindString(settings.Key.ToString().ToUpper(CultureInfo.InvariantCulture));
            TxtScreenshotDateTimeFormatString.Text = settings.ScreenshotDateTimeFormatString;
            ChbShouldShowProgressbar.Checked = settings.ShouldShowProgressbar;
            TxtThreshold.Enabled = settings.ShouldShowProgressbar;
            TxtThreshold.Text = settings.PopProgressDialogThreshold.ToString(CultureInfo.InvariantCulture);
            SetKeyboardHook();
            FileManagement = new FileManagement(settings, logForm);
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void SetKeyboardHook()
        {
            Hook?.Dispose();
            Hook = new KeyboardHook();
            Hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hook_KeyPressed);
            try
            {
                Hook.RegisterHotKey(settings.ModifierKeys[0] | settings.ModifierKeys[1], settings.Key);
            }
            catch
            {                
                MessageBox.Show(Resources.HookInUse);
            }

        }

        static ApplicationSettings LoadSettings(string path)
        {
            if (File.Exists(path))
            {
                var settings = JsonSerializer.Deserialize<ApplicationSettings>(File.ReadAllText(path));
                if (string.IsNullOrEmpty(settings.ScreenshotDateTimeFormatString))
                {
                    settings.ScreenshotDateTimeFormatString = "yyyy-dd-M--HH-mm-ss";
                }

                return settings;
            }
            else
            {
                return new ApplicationSettings
                {
                    DeleteOnExit = false,
                    ExternalAdress = "",
                    Key = Keys.S,
                    ModifierKeys = new List<ModifierKeys> { ShareV2.ModifierKeys.Ctrl, ShareV2.ModifierKeys.Alt },
                    StartWithWindows = false,
                    WebPath = "C:\\Xampp\\htdocs\\",
                    AddIndexToWebPath = false,
                    MoveToTrash = true,
                    ScreenshotDateTimeFormatString = "yyyy-dd-M--HH-mm-ss",
                    ShouldShowProgressbar = false,
                    PopProgressDialogThreshold = 50000
                };
            }
        }

        public static void SaveSettings(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            File.WriteAllText(path, JsonSerializer.Serialize(settings));
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = settings.WebPath;
            folderBrowserDialog1.ShowDialog();
            folderBrowserDialog1.SelectedPath = folderBrowserDialog1.SelectedPath.Replace("\\\\", "");
            TxtWebLocation.Text = folderBrowserDialog1.SelectedPath + "\\";
            settings.WebPath = folderBrowserDialog1.SelectedPath + "\\";

            if (Directory.GetFiles(settings.WebPath).Length > 0)
            {
                MessageBox.Show("The selected directory is not empty, 'Delete on shutdown/close' has been deselected. Make sure the files are not important before reenabling");
                ChbDeleteOnExit.Checked = false;
            }
            SaveChanges();
        }

        private void SaveChanges()
        {
            SaveSettings(SettingsPath);
            FileManagement = new FileManagement(settings, logForm);
        }

        void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Clipboard.SetText(FileManagement.SaveImage(Clipboard.GetImage()));
            }
            else if (Clipboard.GetFileDropList().Count > 0)
            {
                if (Clipboard.GetFileDropList().Count == 1)
                {
                    Clipboard.SetText(FileManagement.SaveFileOrDirectory(Clipboard.GetFileDropList()[0]));
                }
                else
                {
                    Clipboard.SetText(FileManagement.SaveZipFromMultipleFiles(Clipboard.GetFileDropList().Cast<string>().ToList()));
                }
            }
        }

        private void TxtExternalAdress_TextChanged(object sender, EventArgs e)
        {
            settings.ExternalAdress = TxtExternalAdress.Text;
            SaveChanges();
        }

        private void ChbDeleteOnExit_CheckedChanged(object sender, EventArgs e)
        {
            if (settings.WebPath.Length > 5)
            {
                settings.DeleteOnExit = ChbDeleteOnExit.Checked;
                ChbSendToTrash.Enabled = settings.DeleteOnExit;
                SaveChanges();
            }
            else
            {
                settings.DeleteOnExit = false;
                ChbDeleteOnExit.Checked = false;
            }
        }

        private void ChbStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            settings.StartWithWindows = ChbStartWithWindows.Checked;
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey(
                                   @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (settings.StartWithWindows)
            {
                string startPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
                                   + @"\ShareV2\ShareV2.appref-ms";

                rkApp.SetValue("ShareV2", startPath);
            }
            else
            {
                rkApp.DeleteValue("ShareV2");
            }

            SaveChanges();
        }

        private void ChbAddIndexToWebPath_CheckedChanged(object sender, EventArgs e)
        {
            settings.AddIndexToWebPath = ChbAddIndexToWebPath.Checked;

            if (settings.AddIndexToWebPath)
            {
                try
                {
                    File.WriteAllText(settings.WebPath + "index.html", ReadResource("index.html"));
                }
                catch
                {
                    ChbAddIndexToWebPath.Checked = false;
                }
            }
            else
            {
                File.Delete(settings.WebPath + "index.html");
            }

            SaveChanges();
        }

        public static string ReadResource(string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"

            resourcePath = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(name, StringComparison.InvariantCultureIgnoreCase));


            using Stream stream = assembly.GetManifestResourceStream(resourcePath);
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileManagement.DeleteWebPathContents();
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            FileManagement.DeleteWebPathContents();
        }

        private void DropdownModifier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownModifier1.SelectedItem != null && DropdownModifier2.SelectedItem != null)
            {
                settings.ModifierKeys = new List<ModifierKeys> {
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),DropdownModifier1.SelectedItem.ToString()),
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),DropdownModifier2.SelectedItem.ToString())
                };
                SaveChanges();
                SetKeyboardHook();
            }
        }

        private void DropdownModifier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownModifier1.SelectedItem != null && DropdownModifier2.SelectedItem != null)
            {
                settings.ModifierKeys = new List<ModifierKeys> {
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),DropdownModifier1.SelectedItem.ToString()),
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),DropdownModifier2.SelectedItem.ToString())
                };
                SaveChanges();
                SetKeyboardHook();
            }
        }

        private void DropdownKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownKey.SelectedItem != null)
            {
                settings.Key = (Keys)Enum.Parse(typeof(Keys), DropdownKey.SelectedItem.ToString());
                SaveChanges();
                SetKeyboardHook();
            }
        }

        private void ShowForm()
        {
            this.Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void CtxMenuOpen_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void CtxMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChbSendToTrash_CheckedChanged(object sender, EventArgs e)
        {
            settings.MoveToTrash = ChbSendToTrash.Checked;
            SaveChanges();
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void TxtWebLocation_TextChanged(object sender, EventArgs e)
        {
            if (TxtWebLocation.Text != settings.WebPath)
            {
                if (Directory.Exists(TxtWebLocation.Text))
                {
                    LblDirNotExisting.Visible = false;
                    settings.WebPath = TxtWebLocation.Text;

                    if (Directory.GetFiles(settings.WebPath).Length > 0)
                    {
                        ChbDeleteOnExit.Checked = false;
                    }
                    SaveChanges();
                }
                else
                {
                    LblDirNotExisting.Visible = true;                    
                }
            }
        }

        private void SettingsForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=netframework-4.8#System_DateTime_ToString_System_String_");
        }

        private void TxtScreenshotDateTimeFormatString_TextChanged(object sender, EventArgs e)
        {
            settings.ScreenshotDateTimeFormatString = TxtScreenshotDateTimeFormatString.Text;
            SaveChanges();
        }

        private void ChbShouldShowProgressbar_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShouldShowProgressbar = ChbShouldShowProgressbar.Checked;
            TxtThreshold.Enabled = settings.ShouldShowProgressbar;
            SaveChanges();
        }

        private void TxtThreshold_TextChanged(object sender, EventArgs e)
        {
            settings.PopProgressDialogThreshold = int.Parse(TxtThreshold.Text, CultureInfo.InvariantCulture);
            SaveChanges();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            logForm.Show();
        }

        private void ChbShouldAutoSolveFilenameConflicts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach(var screen in Screen.AllScreens)
            {
                var form = new DrawingFormOverlay
                {
                    Location = screen.Bounds.Location,
                    Height = screen.Bounds.Height,
                    Width = screen.Bounds.Width
                };
                form.AreaSelected += new EventHandler<AreaSelectedEventArgs>(RecordingAreaSelected);
                overlayForms.Add(form);
                form.Show();
            }
        }

        void RecordingAreaSelected(object sender, AreaSelectedEventArgs e)
        {
            recorderForm = new RecorderForm
            {
                Location = e.SelectedArea.Location,
                Width = e.SelectedArea.Width,
                Height = e.SelectedArea.Height
            };
            foreach (Form form in overlayForms)
            {
                form.Close();
            }
            recorderForm.Show();
        }

        
    }
}
