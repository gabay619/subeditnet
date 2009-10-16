﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Loader.Entities
{
    class SRTLine
    {
        private int id;
        private SRTTime start_time;
        private SRTTime end_time;
        private string line;

        public SRTLine()
        {
            this.start_time = new SRTTime();
            start_time.setTime("00:00:00,000");
            this.end_time = new SRTTime();
            end_time.setTime("00:00:00,000");
        }

        public int getID(){
            return this.id;
        }
        public void setID(int id)
        {
            this.id = id;
        }


        public void setStartTime(string starttime){

            this.start_time.setTime(starttime);
        }

        public string getStartTime()
        {

            return this.start_time.getTime();
        }


        public void setEndTime(string endtime)
        {
             
            this.end_time.setTime(endtime);
        }


        public string getEndTime()
        {
            return this.end_time.getTime();
        }

        public void setLine(string line)
        {
            this.line = line;
        }


        public string getLine()
        {
            return this.line;
        }

        public void clearLine()
        {
            this.id = 0;
            this.start_time.setTime("00:00:00,000");
            this.end_time.setTime("00:00:00,000");
            line = "";
        }
     
    }
}
