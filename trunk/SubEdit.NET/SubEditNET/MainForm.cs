using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SubEditNET.Logger;
using SubEditNET.Loader;

namespace SubEditNET
{
    public partial class MainForm : Form
    {
        DebugLogger logger = SubEditNET.Logger.DebugLogger.Instance;
     

        public MainForm()
        {
            InitializeComponent();
            int currentScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int currentScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            if (currentScreenHeight <= 600)
            {
                //scale the group boxes
                previewGroupBox.Size = new Size(400,150);
                logGroupBox.Size = new Size();
                this.Size = new Size();
            }
        }

        private void openSRTFile_FileOk(object sender, CancelEventArgs e)
        {
         
           
            //set path of the file to read
            string srt_to_read = string.Empty;
            srt_to_read = openSRTFile.FileName;

            //init filereader
            SRTLoader loader = SRTLoader.Instance;
            SRT currentSRT = loader.readSRT(srt_to_read);

            previewTextbox.Text = currentSRT.printSRT();

            //add message to logger
            currentFileTextbox.Text = srt_to_read;
          //  logger.add("openSRTFile_FileOk called:" + srt_to_read, Level.DEBUG);
            logger.add("successfully read file with lines:"+currentSRT.srtlines.Count, Level.DEBUG);
            DebugLogger.Text = logger.getCurrentLog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openSRTFile.Filter = "SRT Files (*.srt)|*.srt";
            //openSRTFile.Filter = "SRT Files (*.srt)|*.srt|All files (*.*)|*.*";
            if (openSRTFile.ShowDialog() == DialogResult.OK)
            {
              
            }
            DebugLogger.Text = logger.getCurrentLog();
        }

    

        private void DebugLogger_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //SubEditNET.Loader.Entities.SRTTime time = new SubEditNET.Loader.Entities.SRTTime();

            //time.initStart("00:01:18,118");
            //time.initEnd("00:01:20,158");

            //logger.add("TEST", Level.DEBUG);
            //logger.add(time.getStartTime(), Level.DEBUG);
            //logger.add(time.getEndTime(), Level.DEBUG);
            //logger.add(time.getTimeDuration(), Level.DEBUG);

            //DebugLogger.Text = logger.getCurrentLog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Version 0.1 Build 91012\nAuthor: M.Baehr\nE-Mail: baehr-m@online.de\nICQ: 166375846", "About SubEdit.NET",MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void spanishEspanolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeshift_hour_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int currentValue = Convert.ToInt32(timeshift_hour_textbox.Text);
                if (currentValue >= 0 && currentValue <= 23)
                {
                    logger.add(currentValue.ToString(), Level.DEBUG);
                    DebugLogger.Text = logger.getCurrentLog();
                }
                if (currentValue < 0 || currentValue > 23)
                {
                    timeshift_hour_textbox.Text = "";
                    DebugLogger.Text = logger.getCurrentLog();
                }
            }
            catch (Exception)
            {

                timeshift_hour_textbox.Text = "";
            }

           
        }

        private void timeshift__minute_textinput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int currentValue = Convert.ToInt32(timeshift__minute_textinput.Text);
                if (currentValue >= 0 && currentValue <= 59)
                {
                    logger.add(currentValue.ToString(), Level.DEBUG);
                    DebugLogger.Text = logger.getCurrentLog();
                }
                if (currentValue < 0 || currentValue > 59)
                {
                    timeshift__minute_textinput.Text = "";
                    DebugLogger.Text = logger.getCurrentLog();
                }
            }
            catch (Exception)
            {

                timeshift__minute_textinput.Text = "";
            }
        }

        private void timeshift_second_textinput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int currentValue = Convert.ToInt32(timeshift_second_textinput.Text);
                if (currentValue >= 0 && currentValue <= 59)
                {
                    logger.add(currentValue.ToString(), Level.DEBUG);
                    DebugLogger.Text = logger.getCurrentLog();
                }
                if (currentValue < 0 || currentValue > 59)
                {
                    timeshift_second_textinput.Text = "";
                    DebugLogger.Text = logger.getCurrentLog();
                }
            }
            catch (Exception)
            {

                timeshift_second_textinput.Text = "";
            }
        }

        private void timeshift_msecond_textinput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int currentValue = Convert.ToInt32(timeshift_msecond_textinput.Text);
                if (currentValue >= 0 && currentValue <= 999)
                {
                    logger.add(currentValue.ToString(), Level.DEBUG);
                    DebugLogger.Text = logger.getCurrentLog();
                }
                if (currentValue < 0 || currentValue > 999)
                {
                    timeshift_msecond_textinput.Text = "";
                    DebugLogger.Text = logger.getCurrentLog();
                }
            }
            catch (Exception)
            {

                timeshift_msecond_textinput.Text = "";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            openSRTFile.Filter = "SRT Files (*.srt)|*.srt";
            //openSRTFile.Filter = "SRT Files (*.srt)|*.srt|All files (*.*)|*.*";
            if (openSRTFile.ShowDialog() == DialogResult.OK)
            {

            }
            DebugLogger.Text = logger.getCurrentLog();
        }

        private void DebugLogger_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }

        private void logContextMenu_Opening(object sender, CancelEventArgs e)
        {
           
             
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.clear();
            DebugLogger.Text = logger.getCurrentLog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to save the file? This can not be undone.","Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
