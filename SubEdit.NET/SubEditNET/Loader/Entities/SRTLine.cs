using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Loader.Entities
{
    class SRTLine
    {

        public int Index { get; set; }
        public SRTTime start_time { get; set; }
        public SRTTime end_time { get; set; }
        public string line { get; set; }

        public SRTLine()
        {
            start_time = new SRTTime();
            start_time.initStart("00:00:00,000");
            end_time = new SRTTime();
            end_time.initStart("00:00:00,000");
        }

  
        public void addStartTime(string starttime){

            this.start_time.initStart(starttime);
        }
        public void addEndTime(string endtime)
        {
             
            this.end_time.initEnd(endtime);
        }

        public void clearLine()
        {
            this.Index = 0;
            start_time.initStart("00:00:00,000");
            end_time.initStart("00:00:00,000");
            line = "";
        }
     
    }
}
