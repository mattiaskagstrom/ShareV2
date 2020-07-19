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
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web path:";
            // 
            // TxtWebLocation
            // 
            this.TxtWebLocation.Location = new System.Drawing.Point(15, 26);
            this.TxtWebLocation.Name = "TxtWebLocation";
            this.TxtWebLocation.Size = new System.Drawing.Size(161, 20);
            this.TxtWebLocation.TabIndex = 1;
            this.TxtWebLocation.TextChanged += new System.EventHandler(this.TxtWebLocation_TextChanged);
            // 
            // TxtExternalAdress
            // 
            this.TxtExternalAdress.Location = new System.Drawing.Point(15, 66);
            this.TxtExternalAdress.Name = "TxtExternalAdress";
            this.TxtExternalAdress.Size = new System.Drawing.Size(161, 20);
            this.TxtExternalAdress.TabIndex = 3;
            this.TxtExternalAdress.TextChanged += new System.EventHandler(this.TxtExternalAdress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "External adress:";
            // 
            // BtnBrowseFolder
            // 
            this.BtnBrowseFolder.Location = new System.Drawing.Point(180, 24);
            this.BtnBrowseFolder.Name = "BtnBrowseFolder";
            this.BtnBrowseFolder.Size = new System.Drawing.Size(51, 23);
            this.BtnBrowseFolder.TabIndex = 4;
            this.BtnBrowseFolder.Text = "Browse";
            this.BtnBrowseFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ChbDeleteOnExit
            // 
            this.ChbDeleteOnExit.AutoSize = true;
            this.ChbDeleteOnExit.Location = new System.Drawing.Point(15, 132);
            this.ChbDeleteOnExit.Name = "ChbDeleteOnExit";
            this.ChbDeleteOnExit.Size = new System.Drawing.Size(151, 17);
            this.ChbDeleteOnExit.TabIndex = 5;
            this.ChbDeleteOnExit.Text = "Delete on shutdown/close";
            this.ChbDeleteOnExit.UseVisualStyleBackColor = true;
            this.ChbDeleteOnExit.CheckedChanged += new System.EventHandler(this.ChbDeleteOnExit_CheckedChanged);
            // 
            // ChbStartWithWindows
            // 
            this.ChbStartWithWindows.AutoSize = true;
            this.ChbStartWithWindows.Location = new System.Drawing.Point(15, 177);
            this.ChbStartWithWindows.Name = "ChbStartWithWindows";
            this.ChbStartWithWindows.Size = new System.Drawing.Size(117, 17);
            this.ChbStartWithWindows.TabIndex = 6;
            this.ChbStartWithWindows.Text = "Start with Windows";
            this.ChbStartWithWindows.UseVisualStyleBackColor = true;
            this.ChbStartWithWindows.CheckedChanged += new System.EventHandler(this.ChbStartWithWindows_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key combination:";
            // 
            // ChbAddIndexToWebPath
            // 
            this.ChbAddIndexToWebPath.AutoSize = true;
            this.ChbAddIndexToWebPath.Location = new System.Drawing.Point(15, 200);
            this.ChbAddIndexToWebPath.Name = "ChbAddIndexToWebPath";
            this.ChbAddIndexToWebPath.Size = new System.Drawing.Size(154, 17);
            this.ChbAddIndexToWebPath.TabIndex = 9;
            this.ChbAddIndexToWebPath.Text = "Add index.html to web path";
            this.toolTip1.SetToolTip(this.ChbAddIndexToWebPath, "Adds a index.html to the web path directory. This will disable the autogenerated " +
        "file index by your webserver.");
            this.ChbAddIndexToWebPath.UseVisualStyleBackColor = true;
            this.ChbAddIndexToWebPath.CheckedChanged += new System.EventHandler(this.ChbAddIndexToWebPath_CheckedChanged);
            // 
            // DropdownModifier1
            // 
            this.DropdownModifier1.FormattingEnabled = true;
            this.DropdownModifier1.Items.AddRange(new object[] {
            "None",
            "Alt",
            "Shift",
            "Ctrl",
            "Win"});
            this.DropdownModifier1.Location = new System.Drawing.Point(15, 105);
            this.DropdownModifier1.Name = "DropdownModifier1";
            this.DropdownModifier1.Size = new System.Drawing.Size(48, 21);
            this.DropdownModifier1.TabIndex = 10;
            this.DropdownModifier1.SelectedIndexChanged += new System.EventHandler(this.DropdownModifier1_SelectedIndexChanged);
            // 
            // DropdownModifier2
            // 
            this.DropdownModifier2.FormattingEnabled = true;
            this.DropdownModifier2.Items.AddRange(new object[] {
            "None",
            "Alt",
            "Shift",
            "Ctrl",
            "Win"});
            this.DropdownModifier2.Location = new System.Drawing.Point(69, 105);
            this.DropdownModifier2.Name = "DropdownModifier2";
            this.DropdownModifier2.Size = new System.Drawing.Size(48, 21);
            this.DropdownModifier2.TabIndex = 11;
            this.DropdownModifier2.SelectedIndexChanged += new System.EventHandler(this.DropdownModifier2_SelectedIndexChanged);
            // 
            // DropdownKey
            // 
            this.DropdownKey.FormattingEnabled = true;
            this.DropdownKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "Å",
            "Ä",
            "Ö",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.DropdownKey.Location = new System.Drawing.Point(123, 105);
            this.DropdownKey.Name = "DropdownKey";
            this.DropdownKey.Size = new System.Drawing.Size(51, 21);
            this.DropdownKey.TabIndex = 12;
            this.DropdownKey.SelectedIndexChanged += new System.EventHandler(this.DropdownKey_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Copy - Share";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuOpen,
            this.CtxMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // CtxMenuOpen
            // 
            this.CtxMenuOpen.Name = "CtxMenuOpen";
            this.CtxMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.CtxMenuOpen.Text = "Open";
            this.CtxMenuOpen.Click += new System.EventHandler(this.CtxMenuOpen_Click);
            // 
            // CtxMenuExit
            // 
            this.CtxMenuExit.Name = "CtxMenuExit";
            this.CtxMenuExit.Size = new System.Drawing.Size(103, 22);
            this.CtxMenuExit.Text = "Exit";
            this.CtxMenuExit.Click += new System.EventHandler(this.CtxMenuExit_Click);
            // 
            // ChbSendToTrash
            // 
            this.ChbSendToTrash.AutoSize = true;
            this.ChbSendToTrash.Location = new System.Drawing.Point(15, 154);
            this.ChbSendToTrash.Name = "ChbSendToTrash";
            this.ChbSendToTrash.Size = new System.Drawing.Size(215, 17);
            this.ChbSendToTrash.TabIndex = 14;
            this.ChbSendToTrash.Text = "Move files to recycle bin when deleteing";
            this.ChbSendToTrash.UseVisualStyleBackColor = true;
            this.ChbSendToTrash.CheckedChanged += new System.EventHandler(this.ChbSendToTrash_CheckedChanged);
            // 
            // LblDirNotExisting
            // 
            this.LblDirNotExisting.AutoSize = true;
            this.LblDirNotExisting.ForeColor = System.Drawing.Color.Red;
            this.LblDirNotExisting.Location = new System.Drawing.Point(65, 10);
            this.LblDirNotExisting.Name = "LblDirNotExisting";
            this.LblDirNotExisting.Size = new System.Drawing.Size(120, 13);
            this.LblDirNotExisting.TabIndex = 15;
            this.LblDirNotExisting.Text = "Directory does not exist!";
            this.LblDirNotExisting.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 226);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Copy - Share";
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
    }
}

