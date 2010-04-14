using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Entities
{
    class SRTToken
    {
        private int id;
        private SRTTime start_time;
        private SRTTime end_time;
        private string line;

        public SRTToken()
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


        public void setStartTimeString(string starttime){

            this.start_time.setTime(starttime);
        }


        public void setStartTime(SRTTime startTime)
        {
            this.start_time = startTime;
        }

        public string getStartTimeString()
        {

            return this.start_time.getTime();
        }

        public SRTTime getStartTime()
        {
            return this.start_time;
        }

        public void setEndTimeString(string endtime)
        {
             
            this.end_time.setTime(endtime);
        }

        public void setEndTime(SRTTime endTime)
        {
            this.end_time = endTime;
        }

        public string getEndTimeString()
        {
            return this.end_time.getTime();
        }

        public SRTTime getEndTime()
        {
            return this.end_time;
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
