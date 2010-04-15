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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.previewTextbox = new System.Windows.Forms.TextBox();
            this.previewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSRTFile = new System.Windows.Forms.OpenFileDialog();
            this.DebugLogger = new System.Windows.Forms.TextBox();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.convertGroupBox = new System.Windows.Forms.GroupBox();
            this.convertLabel = new System.Windows.Forms.Label();
            this.cp1252toUCButton = new System.Windows.Forms.Button();
            this.cp1251toUCButton = new System.Windows.Forms.Button();
            this.currentFileGroupBox = new System.Windows.Forms.GroupBox();
            this.currentFileTextbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timeshift_msecEnd_inputBox = new System.Windows.Forms.TextBox();
            this.timeshift_secondEnd_inputBox = new System.Windows.Forms.TextBox();
            this.timeshift_minuteEnd_inputBox = new System.Windows.Forms.TextBox();
            this.timeshift_hourEnd_inputBox = new System.Windows.Forms.TextBox();
            this.timeShiftMinusButton = new System.Windows.Forms.Button();
            this.timeshift_msecond_textinput = new System.Windows.Forms.TextBox();
            this.timeShiftPlusButton = new System.Windows.Forms.Button();
            this.timeshift_second_textinput = new System.Windows.Forms.TextBox();
            this.timeshift_hour_textbox = new System.Windows.Forms.TextBox();
            this.timeshift__minute_textinput = new System.Windows.Forms.TextBox();
            this.statusStripMain.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.convertGroupBox.SuspendLayout();
            this.currentFileGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 465);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(794, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
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
            this.previewGroupBox.Size = new System.Drawing.Size(400, 278);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // previewTextbox
            // 
            this.previewTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.previewTextbox.ContextMenuStrip = this.previewContextMenuStrip;
            this.previewTextbox.Location = new System.Drawing.Point(6, 24);
            this.previewTextbox.Multiline = true;
            this.previewTextbox.Name = "previewTextbox";
            this.previewTextbox.ReadOnly = true;
            this.previewTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewTextbox.Size = new System.Drawing.Size(387, 242);
            this.previewTextbox.TabIndex = 0;
            // 
            // previewContextMenuStrip
            // 
            this.previewContextMenuStrip.Name = "previewContextMenuStrip";
            this.previewContextMenuStrip.Size = new System.Drawing.Size(61, 4);
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
            this.DebugLogger.Size = new System.Drawing.Size(758, 91);
            this.DebugLogger.TabIndex = 3;
            this.DebugLogger.WordWrap = false;
            this.DebugLogger.ContextMenuStripChanged += new System.EventHandler(this.DebugLogger_ContextMenuStripChanged);
            this.DebugLogger.TextChanged += new System.EventHandler(this.DebugLogger_TextChanged);
            // 
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.logContextMenu.Name = "logContextMenu";
            this.logContextMenu.Size = new System.Drawing.Size(123, 70);
            this.logContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.logContextMenu_Opening);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.DebugLogger);
            this.logGroupBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logGroupBox.Location = new System.Drawing.Point(12, 336);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(770, 119);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.themeToolStripMenuItem.Enabled = false;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.howDoIToolStripMenuItem.Enabled = false;
            this.howDoIToolStripMenuItem.Name = "howDoIToolStripMenuItem";
            this.howDoIToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.howDoIToolStripMenuItem.Text = "How Do I";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Enabled = false;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Enabled = false;
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
            this.checkForUpdatesToolStripMenuItem.Enabled = false;
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
            this.toolStripOpenButton,
            this.toolStripSeparator3,
            this.toolStripSaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.Image = global::SubEditNET.Properties.Resources.Folder_Open;
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(56, 22);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.Image = global::SubEditNET.Properties.Resources.FloppyDisk;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(51, 22);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.convertGroupBox);
            this.controlGroupBox.Controls.Add(this.currentFileGroupBox);
            this.controlGroupBox.Controls.Add(this.groupBox4);
            this.controlGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.Location = new System.Drawing.Point(12, 52);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(365, 278);
            this.controlGroupBox.TabIndex = 6;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // convertGroupBox
            // 
            this.convertGroupBox.Controls.Add(this.convertLabel);
            this.convertGroupBox.Controls.Add(this.cp1252toUCButton);
            this.convertGroupBox.Controls.Add(this.cp1251toUCButton);
            this.convertGroupBox.Enabled = false;
            this.convertGroupBox.Location = new System.Drawing.Point(7, 184);
            this.convertGroupBox.Name = "convertGroupBox";
            this.convertGroupBox.Size = new System.Drawing.Size(352, 82);
            this.convertGroupBox.TabIndex = 10;
            this.convertGroupBox.TabStop = false;
            this.convertGroupBox.Text = "Convert";
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Location = new System.Drawing.Point(32, 57);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(283, 17);
            this.convertLabel.TabIndex = 2;
            this.convertLabel.Text = "CP1251 is ASCII Cyrillic, CP1252 is ASCI Western";
            // 
            // cp1252toUCButton
            // 
            this.cp1252toUCButton.Location = new System.Drawing.Point(172, 24);
            this.cp1252toUCButton.Name = "cp1252toUCButton";
            this.cp1252toUCButton.Size = new System.Drawing.Size(158, 30);
            this.cp1252toUCButton.TabIndex = 1;
            this.cp1252toUCButton.Text = "CP1252 to Unicode";
            this.cp1252toUCButton.UseVisualStyleBackColor = true;
            this.cp1252toUCButton.Click += new System.EventHandler(this.cp1252toUCButton_Click);
            // 
            // cp1251toUCButton
            // 
            this.cp1251toUCButton.Location = new System.Drawing.Point(15, 24);
            this.cp1251toUCButton.Name = "cp1251toUCButton";
            this.cp1251toUCButton.Size = new System.Drawing.Size(151, 30);
            this.cp1251toUCButton.TabIndex = 0;
            this.cp1251toUCButton.Text = "CP1251 to Unicode";
            this.cp1251toUCButton.UseVisualStyleBackColor = true;
            this.cp1251toUCButton.Click += new System.EventHandler(this.cp1251toUCButton_Click);
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
            this.groupBox4.Controls.Add(this.timeshift_msecEnd_inputBox);
            this.groupBox4.Controls.Add(this.timeshift_secondEnd_inputBox);
            this.groupBox4.Controls.Add(this.timeshift_minuteEnd_inputBox);
            this.groupBox4.Controls.Add(this.timeshift_hourEnd_inputBox);
            this.groupBox4.Controls.Add(this.timeShiftMinusButton);
            this.groupBox4.Controls.Add(this.timeshift_msecond_textinput);
            this.groupBox4.Controls.Add(this.timeShiftPlusButton);
            this.groupBox4.Controls.Add(this.timeshift_second_textinput);
            this.groupBox4.Controls.Add(this.timeshift_hour_textbox);
            this.groupBox4.Controls.Add(this.timeshift__minute_textinput);
            this.groupBox4.Location = new System.Drawing.Point(6, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 84);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time shift";
            // 
            // timeshift_msecEnd_inputBox
            // 
            this.timeshift_msecEnd_inputBox.Location = new System.Drawing.Point(211, 53);
            this.timeshift_msecEnd_inputBox.Name = "timeshift_msecEnd_inputBox";
            this.timeshift_msecEnd_inputBox.Size = new System.Drawing.Size(50, 25);
            this.timeshift_msecEnd_inputBox.TabIndex = 10;
            // 
            // timeshift_secondEnd_inputBox
            // 
            this.timeshift_secondEnd_inputBox.Location = new System.Drawing.Point(171, 53);
            this.timeshift_secondEnd_inputBox.Name = "timeshift_secondEnd_inputBox";
            this.timeshift_secondEnd_inputBox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_secondEnd_inputBox.TabIndex = 9;
            // 
            // timeshift_minuteEnd_inputBox
            // 
            this.timeshift_minuteEnd_inputBox.Location = new System.Drawing.Point(131, 53);
            this.timeshift_minuteEnd_inputBox.Name = "timeshift_minuteEnd_inputBox";
            this.timeshift_minuteEnd_inputBox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_minuteEnd_inputBox.TabIndex = 8;
            // 
            // timeshift_hourEnd_inputBox
            // 
            this.timeshift_hourEnd_inputBox.Location = new System.Drawing.Point(91, 53);
            this.timeshift_hourEnd_inputBox.Name = "timeshift_hourEnd_inputBox";
            this.timeshift_hourEnd_inputBox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_hourEnd_inputBox.TabIndex = 7;
            // 
            // timeShiftMinusButton
            // 
            this.timeShiftMinusButton.Location = new System.Drawing.Point(36, 34);
            this.timeShiftMinusButton.Name = "timeShiftMinusButton";
            this.timeShiftMinusButton.Size = new System.Drawing.Size(35, 26);
            this.timeShiftMinusButton.TabIndex = 1;
            this.timeShiftMinusButton.Text = "-";
            this.timeShiftMinusButton.UseVisualStyleBackColor = true;
            this.timeShiftMinusButton.Click += new System.EventHandler(this.timeShiftMinusButton_Click);
            // 
            // timeshift_msecond_textinput
            // 
            this.timeshift_msecond_textinput.Location = new System.Drawing.Point(211, 22);
            this.timeshift_msecond_textinput.Name = "timeshift_msecond_textinput";
            this.timeshift_msecond_textinput.Size = new System.Drawing.Size(50, 25);
            this.timeshift_msecond_textinput.TabIndex = 6;
            this.timeshift_msecond_textinput.TextChanged += new System.EventHandler(this.timeshift_msecond_textinput_TextChanged);
            // 
            // timeShiftPlusButton
            // 
            this.timeShiftPlusButton.Location = new System.Drawing.Point(281, 34);
            this.timeShiftPlusButton.Name = "timeShiftPlusButton";
            this.timeShiftPlusButton.Size = new System.Drawing.Size(35, 26);
            this.timeShiftPlusButton.TabIndex = 0;
            this.timeShiftPlusButton.Text = "+";
            this.timeShiftPlusButton.UseVisualStyleBackColor = true;
            this.timeShiftPlusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeshift_second_textinput
            // 
            this.timeshift_second_textinput.Location = new System.Drawing.Point(171, 22);
            this.timeshift_second_textinput.Name = "timeshift_second_textinput";
            this.timeshift_second_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift_second_textinput.TabIndex = 5;
            this.timeshift_second_textinput.TextChanged += new System.EventHandler(this.timeshift_second_textinput_TextChanged);
            // 
            // timeshift_hour_textbox
            // 
            this.timeshift_hour_textbox.Location = new System.Drawing.Point(91, 22);
            this.timeshift_hour_textbox.Name = "timeshift_hour_textbox";
            this.timeshift_hour_textbox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_hour_textbox.TabIndex = 3;
            this.timeshift_hour_textbox.TextChanged += new System.EventHandler(this.timeshift_hour_textbox_TextChanged);
            // 
            // timeshift__minute_textinput
            // 
            this.timeshift__minute_textinput.Location = new System.Drawing.Point(131, 22);
            this.timeshift__minute_textinput.Name = "timeshift__minute_textinput";
            this.timeshift__minute_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift__minute_textinput.TabIndex = 4;
            this.timeshift__minute_textinput.TextChanged += new System.EventHandler(this.timeshift__minute_textinput_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 487);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubEdit.NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
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
            this.convertGroupBox.ResumeLayout(false);
            this.convertGroupBox.PerformLayout();
            this.currentFileGroupBox.ResumeLayout(false);
            this.currentFileGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
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
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripOpenButton;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
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
        private System.Windows.Forms.Button timeShiftMinusButton;
        private System.Windows.Forms.Button timeShiftPlusButton;
        private System.Windows.Forms.TextBox timeshift_msecond_textinput;
        private System.Windows.Forms.TextBox timeshift_second_textinput;
        private System.Windows.Forms.TextBox timeshift__minute_textinput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox currentFileGroupBox;
        private System.Windows.Forms.TextBox currentFileTextbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox convertGroupBox;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Button cp1252toUCButton;
        private System.Windows.Forms.Button cp1251toUCButton;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip previewContextMenuStrip;
        private System.Windows.Forms.TextBox timeshift_msecEnd_inputBox;
        private System.Windows.Forms.TextBox timeshift_secondEnd_inputBox;
        private System.Windows.Forms.TextBox timeshift_minuteEnd_inputBox;
        private System.Windows.Forms.TextBox timeshift_hourEnd_inputBox;
    }
}

