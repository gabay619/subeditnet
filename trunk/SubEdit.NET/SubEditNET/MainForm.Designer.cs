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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.previewIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previewStartTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.previewEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.previewSubtitleLine = new System.Windows.Forms.TextBox();
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
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.timeShiftGroupBox = new System.Windows.Forms.GroupBox();
            this.timeShiftValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeShiftMinusButton = new System.Windows.Forms.Button();
            this.timeshift_msecond_textinput = new System.Windows.Forms.TextBox();
            this.timeShiftPlusButton = new System.Windows.Forms.Button();
            this.timeshift_second_textinput = new System.Windows.Forms.TextBox();
            this.timeshift_hour_textbox = new System.Windows.Forms.TextBox();
            this.timeshift_minute_textinput = new System.Windows.Forms.TextBox();
            this.saveSRTFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStripMain.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.convertGroupBox.SuspendLayout();
            this.currentFileGroupBox.SuspendLayout();
            this.timeShiftGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 465);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(693, 22);
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
            this.previewGroupBox.Controls.Add(this.label5);
            this.previewGroupBox.Controls.Add(this.previewIndex);
            this.previewGroupBox.Controls.Add(this.label3);
            this.previewGroupBox.Controls.Add(this.previewStartTime);
            this.previewGroupBox.Controls.Add(this.label2);
            this.previewGroupBox.Controls.Add(this.previewEndTime);
            this.previewGroupBox.Controls.Add(this.label1);
            this.previewGroupBox.Controls.Add(this.button3);
            this.previewGroupBox.Controls.Add(this.button2);
            this.previewGroupBox.Controls.Add(this.button1);
            this.previewGroupBox.Controls.Add(this.previewSubtitleLine);
            this.previewGroupBox.Enabled = false;
            this.previewGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewGroupBox.Location = new System.Drawing.Point(383, 52);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(288, 278);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Index";
            // 
            // previewIndex
            // 
            this.previewIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewIndex.Location = new System.Drawing.Point(7, 57);
            this.previewIndex.Name = "previewIndex";
            this.previewIndex.Size = new System.Drawing.Size(38, 25);
            this.previewIndex.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Time";
            // 
            // previewStartTime
            // 
            this.previewStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewStartTime.Location = new System.Drawing.Point(7, 105);
            this.previewStartTime.Name = "previewStartTime";
            this.previewStartTime.Size = new System.Drawing.Size(272, 25);
            this.previewStartTime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Time";
            // 
            // previewEndTime
            // 
            this.previewEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewEndTime.Location = new System.Drawing.Point(7, 153);
            this.previewEndTime.Name = "previewEndTime";
            this.previewEndTime.Size = new System.Drawing.Size(272, 25);
            this.previewEndTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subtitle Line";
            // 
            // button3
            // 
            this.button3.Image = global::SubEditNET.Properties.Resources.fwd;
            this.button3.Location = new System.Drawing.Point(101, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 20);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::SubEditNET.Properties.Resources.backwd;
            this.button2.Location = new System.Drawing.Point(54, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 20);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(7, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // previewSubtitleLine
            // 
            this.previewSubtitleLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewSubtitleLine.ContextMenuStrip = this.previewContextMenuStrip;
            this.previewSubtitleLine.Location = new System.Drawing.Point(7, 208);
            this.previewSubtitleLine.Multiline = true;
            this.previewSubtitleLine.Name = "previewSubtitleLine";
            this.previewSubtitleLine.ReadOnly = true;
            this.previewSubtitleLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewSubtitleLine.Size = new System.Drawing.Size(272, 38);
            this.previewSubtitleLine.TabIndex = 0;
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
            this.DebugLogger.Size = new System.Drawing.Size(644, 91);
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
            this.logGroupBox.Size = new System.Drawing.Size(659, 119);
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
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.themeToolStripMenuItem.Enabled = false;
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
            this.toolStripNewButton,
            this.toolStripSeparator4,
            this.toolStripOpenButton,
            this.toolStripSeparator3,
            this.toolStripSaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(51, 22);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.toolStripNewButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.Image = global::SubEditNET.Properties.Resources.Folder_Open;
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(56, 22);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.toolStripOpenButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.Enabled = false;
            this.toolStripSaveButton.Image = global::SubEditNET.Properties.Resources.FloppyDisk;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(67, 22);
            this.toolStripSaveButton.Text = "Save As";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.convertGroupBox);
            this.controlGroupBox.Controls.Add(this.currentFileGroupBox);
            this.controlGroupBox.Controls.Add(this.timeShiftGroupBox);
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
            this.currentFileTextbox.Location = new System.Drawing.Point(6, 24);
            this.currentFileTextbox.Name = "currentFileTextbox";
            this.currentFileTextbox.ReadOnly = true;
            this.currentFileTextbox.Size = new System.Drawing.Size(340, 25);
            this.currentFileTextbox.TabIndex = 0;
            // 
            // timeShiftGroupBox
            // 
            this.timeShiftGroupBox.Controls.Add(this.timeShiftValue);
            this.timeShiftGroupBox.Controls.Add(this.label4);
            this.timeShiftGroupBox.Controls.Add(this.timeShiftMinusButton);
            this.timeShiftGroupBox.Controls.Add(this.timeshift_msecond_textinput);
            this.timeShiftGroupBox.Controls.Add(this.timeShiftPlusButton);
            this.timeShiftGroupBox.Controls.Add(this.timeshift_second_textinput);
            this.timeShiftGroupBox.Controls.Add(this.timeshift_hour_textbox);
            this.timeShiftGroupBox.Controls.Add(this.timeshift_minute_textinput);
            this.timeShiftGroupBox.Enabled = false;
            this.timeShiftGroupBox.Location = new System.Drawing.Point(6, 94);
            this.timeShiftGroupBox.Name = "timeShiftGroupBox";
            this.timeShiftGroupBox.Size = new System.Drawing.Size(353, 84);
            this.timeShiftGroupBox.TabIndex = 8;
            this.timeShiftGroupBox.TabStop = false;
            this.timeShiftGroupBox.Text = "Time shift";
            // 
            // timeShiftValue
            // 
            this.timeShiftValue.Location = new System.Drawing.Point(274, 33);
            this.timeShiftValue.Name = "timeShiftValue";
            this.timeShiftValue.Size = new System.Drawing.Size(63, 25);
            this.timeShiftValue.TabIndex = 8;
            this.timeShiftValue.Text = "500";
            this.timeShiftValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeShiftValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeShiftValue_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value in ms";
            // 
            // timeShiftMinusButton
            // 
            this.timeShiftMinusButton.Location = new System.Drawing.Point(233, 32);
            this.timeShiftMinusButton.Name = "timeShiftMinusButton";
            this.timeShiftMinusButton.Size = new System.Drawing.Size(35, 26);
            this.timeShiftMinusButton.TabIndex = 1;
            this.timeShiftMinusButton.Text = "-";
            this.timeShiftMinusButton.UseVisualStyleBackColor = true;
            this.timeShiftMinusButton.Click += new System.EventHandler(this.timeShiftMinusButton_Click);
            // 
            // timeshift_msecond_textinput
            // 
            this.timeshift_msecond_textinput.Location = new System.Drawing.Point(136, 33);
            this.timeshift_msecond_textinput.Name = "timeshift_msecond_textinput";
            this.timeshift_msecond_textinput.Size = new System.Drawing.Size(50, 25);
            this.timeshift_msecond_textinput.TabIndex = 6;
            this.timeshift_msecond_textinput.TextChanged += new System.EventHandler(this.timeshift_msecond_textinput_TextChanged);
            this.timeshift_msecond_textinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeshift_msecond_textinput_KeyPress);
            // 
            // timeShiftPlusButton
            // 
            this.timeShiftPlusButton.Location = new System.Drawing.Point(192, 32);
            this.timeShiftPlusButton.Name = "timeShiftPlusButton";
            this.timeShiftPlusButton.Size = new System.Drawing.Size(35, 26);
            this.timeShiftPlusButton.TabIndex = 0;
            this.timeShiftPlusButton.Text = "+";
            this.timeShiftPlusButton.UseVisualStyleBackColor = true;
            this.timeShiftPlusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeshift_second_textinput
            // 
            this.timeshift_second_textinput.Location = new System.Drawing.Point(96, 33);
            this.timeshift_second_textinput.Name = "timeshift_second_textinput";
            this.timeshift_second_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift_second_textinput.TabIndex = 5;
            this.timeshift_second_textinput.TextChanged += new System.EventHandler(this.timeshift_second_textinput_TextChanged);
            this.timeshift_second_textinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeshift_second_textinput_KeyPress);
            // 
            // timeshift_hour_textbox
            // 
            this.timeshift_hour_textbox.Location = new System.Drawing.Point(16, 33);
            this.timeshift_hour_textbox.Name = "timeshift_hour_textbox";
            this.timeshift_hour_textbox.Size = new System.Drawing.Size(34, 25);
            this.timeshift_hour_textbox.TabIndex = 3;
            this.timeshift_hour_textbox.TextChanged += new System.EventHandler(this.timeshift_hour_textbox_TextChanged);
            this.timeshift_hour_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeshift_hour_textbox_KeyPress);
            // 
            // timeshift_minute_textinput
            // 
            this.timeshift_minute_textinput.Location = new System.Drawing.Point(56, 33);
            this.timeshift_minute_textinput.Name = "timeshift_minute_textinput";
            this.timeshift_minute_textinput.Size = new System.Drawing.Size(34, 25);
            this.timeshift_minute_textinput.TabIndex = 4;
            this.timeshift_minute_textinput.TextChanged += new System.EventHandler(this.timeshift__minute_textinput_TextChanged);
            this.timeshift_minute_textinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeshift_minute_textinput_KeyPress);
            // 
            // saveSRTFile
            // 
            this.saveSRTFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveSRTFile_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 487);
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
            this.timeShiftGroupBox.ResumeLayout(false);
            this.timeShiftGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox previewSubtitleLine;
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
        private System.Windows.Forms.TextBox timeshift_minute_textinput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox currentFileGroupBox;
        private System.Windows.Forms.TextBox currentFileTextbox;
        private System.Windows.Forms.GroupBox timeShiftGroupBox;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox convertGroupBox;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Button cp1252toUCButton;
        private System.Windows.Forms.Button cp1251toUCButton;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip previewContextMenuStrip;
        private System.Windows.Forms.SaveFileDialog saveSRTFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox previewStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox previewEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeShiftValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox previewIndex;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

