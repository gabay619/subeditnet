using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Entities
{
    class SRTTime
    {
        public SRTTime()
        {

        }

        public SRTTime(int h, int m, int s, int ms)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
            this.msecond = ms;
        }

        private int hour;
        private int minute;
        private int second;
        private int msecond;

        public void setTime(string time)
        {
            //check if valid

            string[] s1 = time.Split(':');
            hour = Convert.ToInt32(s1[0]);
            minute = Convert.ToInt32(s1[1]);

            string[] s2 = s1[2].Split(',');
            second = Convert.ToInt32(s2[0]);
            msecond = Convert.ToInt32(s2[1]);

        }

        public void setTime(SRTTime time)
        {
            this.hour = time.hour;
            this.minute = time.minute;
            this.second = time.second;
            this.msecond = time.msecond;
        }

        public int getHour()
        {
            return this.hour;
        }

        public int getMinute()
        {
            return this.minute;
        }

        public int getSecond()
        {
            return this.second;
        }

        public int getMilliSecond()
        {
            return this.msecond;
        }

        public string getTime()
        {
            string hourString = hour.ToString();
            string minuteString = minute.ToString();
            string secondString = second.ToString();
            string msecondString = msecond.ToString();

             if (hour < 10)
             {
                 hourString = "0" + hour.ToString();
             }
             if (minute < 10)
             {
                 minuteString = "0" + minute.ToString();
             }
             if (second < 10)
             {
                 secondString = "0" + second.ToString();
             }
             if (msecond < 100 && msecond > 10)
             {
                 msecondString = "0" + msecond.ToString();  
             }
             if (msecond < 10)
             {
                 msecondString = "00" + msecond.ToString();
             }

             return hourString + ":" + minuteString + ":" + secondString + "," + msecondString;
       
        }

    }
}
