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
using SubEditNET.Entities;
using SubEditNET.Saver;
using SubEditNET.Modifiers;

namespace SubEditNET
{
    public partial class MainForm : Form
    {
        DebugLogger logger = SubEditNET.Logger.DebugLogger.Instance;
        SRT currentSRT = new SRT();

        public MainForm()
        {
           
            InitializeComponent();

            this.timeshift_hour_textbox.MaxLength = 2;
            this.timeshift__minute_textinput.MaxLength = 2;
            this.timeshift_second_textinput.MaxLength = 2;
            this.timeshift_msecond_textinput.MaxLength = 3;

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
            SRT newSRT = loader.readSRT(srt_to_read);

          //  previewTextbox.Text = newSRT.printSRT();

            //add message to logger
            currentFileTextbox.Text = srt_to_read;
          //  logger.add("openSRTFile_FileOk called:" + srt_to_read, Level.DEBUG);
            logger.add("successfully read file with lines:", Level.DEBUG);
            DebugLogger.Text = logger.getCurrentLog();

            currentSRT = newSRT;

            timeshift_hour_textbox.Text = currentSRT.getToken(0).getStartTime().getHour().ToString();
            timeshift__minute_textinput.Text = currentSRT.getToken(0).getStartTime().getMinute().ToString();
            timeshift_second_textinput.Text = currentSRT.getToken(0).getStartTime().getSecond().ToString();
            timeshift_msecond_textinput.Text = currentSRT.getToken(0).getStartTime().getMilliSecond().ToString();

            timeshift_hourEnd_inputBox.Text = currentSRT.getToken(0).getEndTime().getHour().ToString();
            timeshift_minuteEnd_inputBox.Text = currentSRT.getToken(0).getEndTime().getMinute().ToString();
            timeshift_secondEnd_inputBox.Text = currentSRT.getToken(0).getEndTime().getSecond().ToString();
            timeshift_msecEnd_inputBox.Text = currentSRT.getToken(0).getEndTime().getMilliSecond().ToString();
       
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
            MessageBox.Show("Version 1.0 - currentTrunk \nAuthor: M.Baehr \nE-Mail: nerom86@googlemail.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //if (timeshift_msecond_textinput.MaxLength > 4)
                //{

                //}
              
                //int currentValue = Convert.ToInt32(timeshift_msecond_textinput.Text);
                //if (currentValue >= 0 && currentValue <= 999)
                //{
                //    logger.add(currentValue.ToString(), Level.DEBUG);
                //    DebugLogger.Text = logger.getCurrentLog();
                //}
                //if (currentValue < 0 || currentValue > 999)
                //{
                //    timeshift_msecond_textinput.Text = "";
                //    DebugLogger.Text = logger.getCurrentLog();
                //}
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
            if (currentFileTextbox.Text == "" || currentFileTextbox.Text == null)
            {
                MessageBox.Show("Please load a file first.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Do you want to save the file? This can not be undone.", "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SRTSaver saver = SRTSaver.Instance;
                TimeShifter shifter = TimeShifter.Instance;

                SRTTime newStartTime = new SRTTime(Convert.ToInt32(timeshift_hour_textbox.Text),
                                                    Convert.ToInt32(timeshift__minute_textinput.Text),
                                                    Convert.ToInt32(timeshift_second_textinput.Text),
                                                    Convert.ToInt32(timeshift_msecond_textinput.Text));

                shifter.shiftTime(currentSRT, newStartTime);

                saver.saveSRT(currentSRT, currentFileTextbox.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFileTextbox.Text == "" || currentFileTextbox.Text == null)
            {
                MessageBox.Show("Please load a file first.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //read old values
                int oldMSValue;
                try
                {
                    oldMSValue = Convert.ToInt32(timeshift_msecond_textinput.Text);
                }
                catch (Exception)
                {
                    oldMSValue = 0;
                }
                //---
                int oldSecValue;
                try
                {
                    oldSecValue = Convert.ToInt32(timeshift_second_textinput.Text);
                }
                catch (Exception)
                {
                    oldSecValue = 0;
                }
                //---
                int oldMinValue;
                try
                {
                    oldMinValue = Convert.ToInt32(timeshift__minute_textinput.Text);
                }
                catch (Exception)
                {
                    oldMinValue = 0;
                }
                //---
                int oldHrValue;
                try
                {
                    oldHrValue = Convert.ToInt32(timeshift_hour_textbox.Text);
                }
                catch (Exception)
                {
                    oldHrValue = 0;
                }
                //###############

                int oldTimeValue = oldHrValue * 60 * 60 * 1000 + oldMinValue * 60 * 1000 + oldSecValue * 1000 + oldMSValue;

                int newTimeValue = oldTimeValue + 500;
                //bis hier stimmt der wert newTimeValue nun muss er aufgesplittet werden und hier passieren die fehler:

                int newHrValue = newTimeValue / 3600000;
                int newMinValue = (newTimeValue - newHrValue * 3600000) / (60000);
                int newSecValue = (newTimeValue - (newHrValue * 3600000) - (newMinValue * 60000)) / 1000;
                int newMSValue = newTimeValue - newHrValue * 3600000 - newMinValue * 60000 - newSecValue * 1000;

                timeshift_msecond_textinput.Text = newMSValue.ToString();
                timeshift_second_textinput.Text = newSecValue.ToString();
                timeshift__minute_textinput.Text = newMinValue.ToString();
                timeshift_hour_textbox.Text = newHrValue.ToString();
            }
           
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSRTFile.Filter = "SRT Files (*.srt)|*.srt";
            //openSRTFile.Filter = "SRT Files (*.srt)|*.srt|All files (*.*)|*.*";
            if (openSRTFile.ShowDialog() == DialogResult.OK)
            {

            }
            DebugLogger.Text = logger.getCurrentLog();
        }

        private void cp1251toUCButton_Click(object sender, EventArgs e)
        {
            if (currentFileTextbox.Text == "" || currentFileTextbox.Text == null)
            {
                MessageBox.Show("Please load a file first.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This feature is not implemented yet.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cp1252toUCButton_Click(object sender, EventArgs e)
        {
            if (currentFileTextbox.Text == "" || currentFileTextbox.Text == null)
            {
                MessageBox.Show("Please load a file first.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This feature is not implemented yet.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timeShiftMinusButton_Click(object sender, EventArgs e)
        {
            if (currentFileTextbox.Text == "" || currentFileTextbox.Text == null)
            {
                MessageBox.Show("Please load a file first.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //read old values
                int oldMSValue;
                try
                {
                    oldMSValue = Convert.ToInt32(timeshift_msecond_textinput.Text);
                }
                catch (Exception)
                {
                    oldMSValue = 0;
                }
                //---
                int oldSecValue;
                try
                {
                    oldSecValue = Convert.ToInt32(timeshift_second_textinput.Text);
                }
                catch (Exception)
                {
                    oldSecValue = 0;
                }
                //---
                int oldMinValue;
                try
                {
                    oldMinValue = Convert.ToInt32(timeshift__minute_textinput.Text);
                }
                catch (Exception)
                {
                    oldMinValue = 0;
                }
                //---
                int oldHrValue;
                try
                {
                    oldHrValue = Convert.ToInt32(timeshift_hour_textbox.Text);
                }
                catch (Exception)
                {
                    oldHrValue = 0;
                }
                //###############

                int oldTimeValue = oldHrValue * 60 * 60 * 1000 + oldMinValue * 60 * 1000 + oldSecValue * 1000 + oldMSValue;

                int newTimeValue = oldTimeValue - 500;
                //bis hier stimmt der wert newTimeValue nun muss er aufgesplittet werden und hier passieren die fehler:
                if (newTimeValue >= 0)
                {

                    int newHrValue = newTimeValue / 3600000;
                    int newMinValue = (newTimeValue - newHrValue * 3600000) / (60000);
                    int newSecValue = (newTimeValue - (newHrValue * 3600000) - (newMinValue * 60000)) / 1000;
                    int newMSValue = newTimeValue - newHrValue * 3600000 - newMinValue * 60000 - newSecValue * 1000;

                    timeshift_msecond_textinput.Text = newMSValue.ToString();
                    timeshift_second_textinput.Text = newSecValue.ToString();
                    timeshift__minute_textinput.Text = newMinValue.ToString();
                    timeshift_hour_textbox.Text = newHrValue.ToString();
                }
                else
                {
                    int newHrValue = 0;
                    int newMinValue = 0;
                    int newSecValue = 0;
                    int newMSValue = 0;

                    timeshift_msecond_textinput.Text = newMSValue.ToString();
                    timeshift_second_textinput.Text = newSecValue.ToString();
                    timeshift__minute_textinput.Text = newMinValue.ToString();
                    timeshift_hour_textbox.Text = newHrValue.ToString();
                }


            }
           
        }

      
    }
}
