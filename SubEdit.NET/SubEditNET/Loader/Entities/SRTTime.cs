using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Loader.Entities
{
    class SRTTime
    {

        int start_hour;
        int start_minute;
        int start_second;
        int start_msecond;

        int end_hour;
        int end_minute;
        int end_second;
        int end_msecond;

        //Bsp: "00:01:18,118"
        public void initStart(string start){

            //check if valid

            if (start.Length != 11)
            {
               
            }

            string[] s1 = start.Split(':');
            start_hour = Convert.ToInt32(s1[0]);
            start_minute = Convert.ToInt32(s1[1]);

            string[] s2 = s1[2].Split(',');
            start_second = Convert.ToInt32(s2[0]);
            start_msecond = Convert.ToInt32(s2[1]);

        }

        public void initEnd(string end){

            //check if valid

            if (end.Length != 11)
            {

            }
            string[] s1 = end.Split(':');
            end_hour = Convert.ToInt32(s1[0]);
            end_minute = Convert.ToInt32(s1[1]);

            string[] s2 = s1[2].Split(',');
            end_second = Convert.ToInt32(s2[0]);
            end_msecond = Convert.ToInt32(s2[1]);

        }

        public string getStartTime()
        {
            return start_hour.ToString() + ":" + start_minute.ToString() + ":" + start_second.ToString() + "," + start_msecond.ToString();

        }

        public string getEndTime()
        {
            return end_hour.ToString() + ":" + end_minute.ToString() + ":" + end_second.ToString() + "," + end_msecond.ToString();

        }


        public string getTimeDuration()
        {
            int diff_hour=end_hour-start_hour;
            int diff_minute=end_minute-start_minute;
            int diff_second=end_second-start_second;
            int diff_msecond=end_msecond-start_msecond;

            return diff_hour.ToString() + ":" + diff_minute.ToString() + ":" + diff_second.ToString() + "," + diff_msecond.ToString();

        }

    }
}
