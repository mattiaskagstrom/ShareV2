namespace ShareV2
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWebLocation = new System.Windows.Forms.TextBox();
            this.TxtExternalAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBrowseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ChbDeleteOnExit = new System.Windows.Forms.CheckBox();
            this.ChbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChbAddIndexToWebPath = new System.Windows.Forms.CheckBox();
            this.DropdownModifier1 = new System.Windows.Forms.ComboBox();
            this.DropdownModifier2 = new System.Windows.Forms.ComboBox();
            this.DropdownKey = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ChbSendToTrash = new System.Windows.Forms.CheckBox();
            this.LblDirNotExisting = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.TxtScreenshotDateTimeFormatString = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChbShouldShowProgressbar = new System.Windows.Forms.CheckBox();
            this.TxtThreshold = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChbShouldAutoSolveFilenameConflicts = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtWebLocation
            // 
            resources.ApplyResources(this.TxtWebLocation, "TxtWebLocation");
            this.TxtWebLocation.Name = "TxtWebLocation";
            this.TxtWebLocation.TextChanged += new System.EventHandler(this.TxtWebLocation_TextChanged);
            // 
            // TxtExternalAdress
            // 
            resources.ApplyResources(this.TxtExternalAdress, "TxtExternalAdress");
            this.TxtExternalAdress.Name = "TxtExternalAdress";
            this.TxtExternalAdress.TextChanged += new System.EventHandler(this.TxtExternalAdress_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BtnBrowseFolder
            // 
            resources.ApplyResources(this.BtnBrowseFolder, "BtnBrowseFolder");
            this.BtnBrowseFolder.Name = "BtnBrowseFolder";
            this.BtnBrowseFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ChbDeleteOnExit
            // 
            resources.ApplyResources(this.ChbDeleteOnExit, "ChbDeleteOnExit");
            this.ChbDeleteOnExit.Name = "ChbDeleteOnExit";
            this.ChbDeleteOnExit.UseVisualStyleBackColor = true;
            this.ChbDeleteOnExit.CheckedChanged += new System.EventHandler(this.ChbDeleteOnExit_CheckedChanged);
            // 
            // ChbStartWithWindows
            // 
            resources.ApplyResources(this.ChbStartWithWindows, "ChbStartWithWindows");
            this.ChbStartWithWindows.Name = "ChbStartWithWindows";
            this.ChbStartWithWindows.UseVisualStyleBackColor = true;
            this.ChbStartWithWindows.CheckedChanged += new System.EventHandler(this.ChbStartWithWindows_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ChbAddIndexToWebPath
            // 
            resources.ApplyResources(this.ChbAddIndexToWebPath, "ChbAddIndexToWebPath");
            this.ChbAddIndexToWebPath.Name = "ChbAddIndexToWebPath";
            this.toolTip1.SetToolTip(this.ChbAddIndexToWebPath, resources.GetString("ChbAddIndexToWebPath.ToolTip"));
            this.ChbAddIndexToWebPath.UseVisualStyleBackColor = true;
            this.ChbAddIndexToWebPath.CheckedChanged += new System.EventHandler(this.ChbAddIndexToWebPath_CheckedChanged);
            // 
            // DropdownModifier1
            // 
            this.DropdownModifier1.FormattingEnabled = true;
            this.DropdownModifier1.Items.AddRange(new object[] {
            resources.GetString("DropdownModifier1.Items"),
            resources.GetString("DropdownModifier1.Items1"),
            resources.GetString("DropdownModifier1.Items2"),
            resources.GetString("DropdownModifier1.Items3"),
            resources.GetString("DropdownModifier1.Items4")});
            resources.ApplyResources(this.DropdownModifier1, "DropdownModifier1");
            this.DropdownModifier1.Name = "DropdownModifier1";
            this.DropdownModifier1.SelectedIndexChanged += new System.EventHandler(this.DropdownModifier1_SelectedIndexChanged);
            // 
            // DropdownModifier2
            // 
            this.DropdownModifier2.FormattingEnabled = true;
            this.DropdownModifier2.Items.AddRange(new object[] {
            resources.GetString("DropdownModifier2.Items"),
            resources.GetString("DropdownModifier2.Items1"),
            resources.GetString("DropdownModifier2.Items2"),
            resources.GetString("DropdownModifier2.Items3"),
            resources.GetString("DropdownModifier2.Items4")});
            resources.ApplyResources(this.DropdownModifier2, "DropdownModifier2");
            this.DropdownModifier2.Name = "DropdownModifier2";
            this.DropdownModifier2.SelectedIndexChanged += new System.EventHandler(this.DropdownModifier2_SelectedIndexChanged);
            // 
            // DropdownKey
            // 
            this.DropdownKey.FormattingEnabled = true;
            this.DropdownKey.Items.AddRange(new object[] {
            resources.GetString("DropdownKey.Items"),
            resources.GetString("DropdownKey.Items1"),
            resources.GetString("DropdownKey.Items2"),
            resources.GetString("DropdownKey.Items3"),
            resources.GetString("DropdownKey.Items4"),
            resources.GetString("DropdownKey.Items5"),
            resources.GetString("DropdownKey.Items6"),
            resources.GetString("DropdownKey.Items7"),
            resources.GetString("DropdownKey.Items8"),
            resources.GetString("DropdownKey.Items9"),
            resources.GetString("DropdownKey.Items10"),
            resources.GetString("DropdownKey.Items11"),
            resources.GetString("DropdownKey.Items12"),
            resources.GetString("DropdownKey.Items13"),
            resources.GetString("DropdownKey.Items14"),
            resources.GetString("DropdownKey.Items15"),
            resources.GetString("DropdownKey.Items16"),
            resources.GetString("DropdownKey.Items17"),
            resources.GetString("DropdownKey.Items18"),
            resources.GetString("DropdownKey.Items19"),
            resources.GetString("DropdownKey.Items20"),
            resources.GetString("DropdownKey.Items21"),
            resources.GetString("DropdownKey.Items22"),
            resources.GetString("DropdownKey.Items23"),
            resources.GetString("DropdownKey.Items24"),
            resources.GetString("DropdownKey.Items25"),
            resources.GetString("DropdownKey.Items26"),
            resources.GetString("DropdownKey.Items27"),
            resources.GetString("DropdownKey.Items28"),
            resources.GetString("DropdownKey.Items29"),
            resources.GetString("DropdownKey.Items30"),
            resources.GetString("DropdownKey.Items31"),
            resources.GetString("DropdownKey.Items32"),
            resources.GetString("DropdownKey.Items33"),
            resources.GetString("DropdownKey.Items34"),
            resources.GetString("DropdownKey.Items35"),
            resources.GetString("DropdownKey.Items36"),
            resources.GetString("DropdownKey.Items37"),
            resources.GetString("DropdownKey.Items38")});
            resources.ApplyResources(this.DropdownKey, "DropdownKey");
            this.DropdownKey.Name = "DropdownKey";
            this.DropdownKey.SelectedIndexChanged += new System.EventHandler(this.DropdownKey_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuOpen,
            this.CtxMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // CtxMenuOpen
            // 
            this.CtxMenuOpen.Name = "CtxMenuOpen";
            resources.ApplyResources(this.CtxMenuOpen, "CtxMenuOpen");
            this.CtxMenuOpen.Click += new System.EventHandler(this.CtxMenuOpen_Click);
            // 
            // CtxMenuExit
            // 
            this.CtxMenuExit.Name = "CtxMenuExit";
            resources.ApplyResources(this.CtxMenuExit, "CtxMenuExit");
            this.CtxMenuExit.Click += new System.EventHandler(this.CtxMenuExit_Click);
            // 
            // ChbSendToTrash
            // 
            resources.ApplyResources(this.ChbSendToTrash, "ChbSendToTrash");
            this.ChbSendToTrash.Name = "ChbSendToTrash";
            this.ChbSendToTrash.UseVisualStyleBackColor = true;
            this.ChbSendToTrash.CheckedChanged += new System.EventHandler(this.ChbSendToTrash_CheckedChanged);
            // 
            // LblDirNotExisting
            // 
            resources.ApplyResources(this.LblDirNotExisting, "LblDirNotExisting");
            this.LblDirNotExisting.ForeColor = System.Drawing.Color.Red;
            this.LblDirNotExisting.Name = "LblDirNotExisting";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TxtScreenshotDateTimeFormatString
            // 
            resources.ApplyResources(this.TxtScreenshotDateTimeFormatString, "TxtScreenshotDateTimeFormatString");
            this.TxtScreenshotDateTimeFormatString.Name = "TxtScreenshotDateTimeFormatString";
            this.TxtScreenshotDateTimeFormatString.TextChanged += new System.EventHandler(this.TxtScreenshotDateTimeFormatString_TextChanged);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ChbShouldShowProgressbar
            // 
            resources.ApplyResources(this.ChbShouldShowProgressbar, "ChbShouldShowProgressbar");
            this.ChbShouldShowProgressbar.Name = "ChbShouldShowProgressbar";
            this.ChbShouldShowProgressbar.UseVisualStyleBackColor = true;
            this.ChbShouldShowProgressbar.CheckedChanged += new System.EventHandler(this.ChbShouldShowProgressbar_CheckedChanged);
            // 
            // TxtThreshold
            // 
            resources.ApplyResources(this.TxtThreshold, "TxtThreshold");
            this.TxtThreshold.Name = "TxtThreshold";
            this.TxtThreshold.TextChanged += new System.EventHandler(this.TxtThreshold_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ChbShouldAutoSolveFilenameConflicts
            // 
            resources.ApplyResources(this.ChbShouldAutoSolveFilenameConflicts, "ChbShouldAutoSolveFilenameConflicts");
            this.ChbShouldAutoSolveFilenameConflicts.Name = "ChbShouldAutoSolveFilenameConflicts";
            this.ChbShouldAutoSolveFilenameConflicts.UseVisualStyleBackColor = true;
            this.ChbShouldAutoSolveFilenameConflicts.CheckedChanged += new System.EventHandler(this.ChbShouldAutoSolveFilenameConflicts_CheckedChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChbShouldAutoSolveFilenameConflicts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtThreshold);
            this.Controls.Add(this.ChbShouldShowProgressbar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtScreenshotDateTimeFormatString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDirNotExisting);
            this.Controls.Add(this.ChbSendToTrash);
            this.Controls.Add(this.DropdownKey);
            this.Controls.Add(this.DropdownModifier2);
            this.Controls.Add(this.DropdownModifier1);
            this.Controls.Add(this.ChbAddIndexToWebPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChbStartWithWindows);
            this.Controls.Add(this.ChbDeleteOnExit);
            this.Controls.Add(this.BtnBrowseFolder);
            this.Controls.Add(this.TxtExternalAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtWebLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseClick);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWebLocation;
        private System.Windows.Forms.TextBox TxtExternalAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBrowseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox ChbDeleteOnExit;
        private System.Windows.Forms.CheckBox ChbStartWithWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChbAddIndexToWebPath;
        private System.Windows.Forms.ComboBox DropdownModifier1;
        private System.Windows.Forms.ComboBox DropdownModifier2;
        private System.Windows.Forms.ComboBox DropdownKey;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuExit;
        private System.Windows.Forms.CheckBox ChbSendToTrash;
        private System.Windows.Forms.Label LblDirNotExisting;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtScreenshotDateTimeFormatString;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChbShouldShowProgressbar;
        private System.Windows.Forms.TextBox TxtThreshold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ChbShouldAutoSolveFilenameConflicts;
        private System.Windows.Forms.Button button2;
    }
}

