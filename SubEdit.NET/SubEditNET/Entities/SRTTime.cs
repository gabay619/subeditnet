using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Entities
{
    class SRTTime
    {

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

        public string getTime()
        {
                return hour.ToString() + ":" + minute.ToString() + ":" + second.ToString() + "," + msecond.ToString();
        }

    }
}
