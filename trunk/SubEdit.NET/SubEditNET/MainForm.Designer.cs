namespace SubEditNET
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.previewTextbox = new System.Windows.Forms.TextBox();
            this.openSRTFile = new System.Windows.Forms.OpenFileDialog();
            this.DebugLogger = new System.Windows.Forms.TextBox();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianItalianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianРусскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishEspanolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.currentFileGroupBox = new System.Windows.Forms.GroupBox();
            this.currentFileTextbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timeshift_msecond_textinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timeshift_second_textinput = new System.Windows.Forms.TextBox();
            this.timeshift_hour_textbox = new System.Windows.Forms.TextBox();
            this.timeshift__minute_textinput = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.currentFileGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewTextbox);
            this.previewGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewGroupBox.Location = new System.Drawing.Point(383, 52);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(400, 300);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // previewTextbox
            // 
            this.previewTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.previewTextbox.Location = new System.Drawing.Point(6, 24);
            this.previewTextbox.Multiline = true;
            this.previewTextbox.Name = "previewTextbox";
            this.previewTextbox.ReadOnly = true;
            this.previewTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewTextbox.Size = new System.Drawing.Size(387, 270);
            this.previewTextbox.TabIndex = 0;
            // 
            // openSRTFile
            // 
            this.openSRTFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openSRTFile_FileOk);
            // 
            // DebugLogger
            // 
            this.DebugLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DebugLogger.ContextMenuStrip = this.logContextMenu;
            this.DebugLogger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugLogger.ForeColor = System.Drawing.Color.Black;
            this.DebugLogger.Location = new System.Drawing.Point(6, 19);
            this.DebugLogger.Multiline = true;
            this.DebugLogger.Name = "DebugLogger";
            this.DebugLogger.ReadOnly = true;
            this.DebugLogger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugLogger.Size = new System.Drawing.Size(387, 143);
            this.DebugLogger.TabIndex = 3;
            this.DebugLogger.WordWrap = false;
            this.DebugLogger.TextChanged += new System.EventHandler(this.DebugLogger_TextChanged);
            this.DebugLogger.ContextMenuStripChanged += new System.EventHandler(this.DebugLogger_ContextMenuStripChanged);
            // 
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.logContextMenu.Name = "logContextMenu";
            this.logContextMenu.Size = new System.Drawing.Size(102, 26);
            this.logContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.logContextMenu_Opening);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.DebugLogger);
            this.logGroupBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logGroupBox.Location = new System.Drawing.Point(383, 358);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(399, 168);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.germanDeutschToolStripMenuItem,
            this.italianItalianoToolStripMenuItem,
            this.russianРусскийToolStripMenuItem,
            this.spanishEspanolToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.englishToolStripMenuItem.Text = "English (English)";
            // 
            // germanDeutschToolStripMenuItem
            // 
            this.germanDeutschToolStripMenuItem.Name = "germanDeutschToolStripMenuItem";
            this.germanDeutschToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.germanDeutschToolStripMenuItem.Text = "German (Deutsch)";
            // 
            // italianItalianoToolStripMenuItem
            // 
            this.italianItalianoToolStripMenuItem.Name = "italianItalianoToolStripMenuItem";
            this.italianItalianoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.italianItalianoToolStripMenuItem.Text = "Italian (Italiano)";
            // 
            // russianРусскийToolStripMenuItem
            // 
            this.russianРусскийToolStripMenuItem.Name = "russianРусскийToolStripMenuItem";
            this.russianРусскийToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.russianРусскийToolStripMenuItem.Text = "Russian (Русский)";
            // 
            // spanishEspanolToolStripMenuItem
            // 
            this.spanishEspanolToolStripMenuItem.Name = "spanishEspanolToolStripMenuItem";
            this.spanishEspanolToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.spanishEspanolToolStripMenuItem.Text = "Spanish (Español)";
            this.spanishEspanolToolStripMenuItem.Click += new System.EventHandler(this.spanishEspanolToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howDoIToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.toolStripSeparator2,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howDoIToolStripMenuItem
            // 
            this.howDoIToolStripMenuItem.Name = "howDoIToolStripMenuItem";
            this.howDoIToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.howDoIToolStripMenuItem.Text = "How Do I";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::SubEditNET.Properties.Resources.ppalicon;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SubEditNET.Properties.Resources.Folder_Open;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::SubEditNET.Properties.Resources.FloppyDisk;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton2.Text = "Save";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.currentFileGroupBox);
            this.controlGroupBox.Controls.Add(this.groupBox4);
            this.controlGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.Location = new System.Drawing.Point(12, 52);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(365, 482);
            this.controlGroupBox.TabIndex = 6;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // currentFileGroupBox
            // 
            this.currentFileGroupBox.Controls.Add(this.currentFileTextbox);
            this.currentFileGroupBox.Location = new System.Drawing.Point(7, 27);
            this.currentFileGroupBox.Name = "currentFileGroupBox";
            this.currentFileGroupBox.Size = new System.Drawing.Size(352, 61);
            this.currentFileGroupBox.TabIndex = 9;
            this.currentFileGroupBox.TabStop = false;
            this.currentFileGroupBox.Text = "Current File";
            // 
            // currentFileTextbox
            // 
            this.currentFileTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.currentFileTextbox.Enabled = false;
            this.currentFileTextbox.Location = new System.Drawing.Point(6, 24);
            this.currentFileTextbox.Name = "currentFileTextbox";
            this.currentFileTextbox.ReadOnly = true;
            this.currentFileTextbox.Size = new System.Drawing.Size(340, 25);
            this.currentFileTextbox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.timeshift_msecond_textinput);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.timeshift_second_textinput);
            this.groupBox4.Controls.Add(this.timeshift_hour_textbox);
            this.groupBox4.Controls.Add(this.timeshift__minute_textinput);
            this.groupBox4.Location = new System.Drawing.Point(6, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 63);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time shift";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timeshift_msecond_textinput
            // 
            this.timeshift_msecond_textinput.Location = new System.Drawing.Point(173, 24);
            this.timeshift_msecond_textinput.Name = "timeshift_msecond_textinput";
            this.timeshift_msecond_textinput.Size = new System.Drawing.Size(50, 25);
            this.timeshift_msecond_textinput.TabIndex = 6;
            this.timeshift_msecond_textinput.Text = "ms";
            this.timeshift_msecond_textinput.TextChanged += new System.EventHandler(this.timeshift_msecond_textinput_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timeshift_second_textinput
            // 
            this.timeshift_second_textinput.Location = new System.Drawing.Point(133, 24);
            this.timeshift_second_textinput.Name = "timeshift_second_textinput";
            this.timeshift_second_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift_second_textinput.TabIndex = 5;
            this.timeshift_second_textinput.Text = "ss";
            this.timeshift_second_textinput.TextChanged += new System.EventHandler(this.timeshift_second_textinput_TextChanged);
            // 
            // timeshift_hour_textbox
            // 
            this.timeshift_hour_textbox.Location = new System.Drawing.Point(53, 24);
            this.timeshift_hour_textbox.Name = "timeshift_hour_textbox";
            this.timeshift_hour_textbox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_hour_textbox.TabIndex = 3;
            this.timeshift_hour_textbox.Text = "hh";
            this.timeshift_hour_textbox.TextChanged += new System.EventHandler(this.timeshift_hour_textbox_TextChanged);
            // 
            // timeshift__minute_textinput
            // 
            this.timeshift__minute_textinput.Location = new System.Drawing.Point(93, 24);
            this.timeshift__minute_textinput.Name = "timeshift__minute_textinput";
            this.timeshift__minute_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift__minute_textinput.TabIndex = 4;
            this.timeshift__minute_textinput.Text = "mm";
            this.timeshift__minute_textinput.TextChanged += new System.EventHandler(this.timeshift__minute_textinput_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubEdit.NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.previewGroupBox.ResumeLayout(false);
            this.previewGroupBox.PerformLayout();
            this.logContextMenu.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.currentFileGroupBox.ResumeLayout(false);
            this.currentFileGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.OpenFileDialog openSRTFile;
        public System.Windows.Forms.TextBox DebugLogger;
        private System.Windows.Forms.TextBox previewTextbox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem howDoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanDeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italianItalianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianРусскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishEspanolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.TextBox timeshift_hour_textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeshift_msecond_textinput;
        private System.Windows.Forms.TextBox timeshift_second_textinput;
        private System.Windows.Forms.TextBox timeshift__minute_textinput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox currentFileGroupBox;
        private System.Windows.Forms.TextBox currentFileTextbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

