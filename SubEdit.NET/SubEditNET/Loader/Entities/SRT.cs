using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubEditNET.Loader.Entities;

namespace SubEditNET.Loader
{
    class SRT
    {

       public List<SRTLine> srtlines = new List<SRTLine>();
        //String encoding;


        public void addLine(int index,string starttime, string endtime, string line)
        {
            SRTLine newLine = new SRTLine();
            newLine.Index = index;

            newLine.addStartTime(starttime);
            newLine.addEndTime(endtime);
     
            newLine.line = line;

            srtlines.Add(newLine);
        }

        public void addLine(SRTLine line)
        {
            srtlines.Add(line);
        }



        public string printSRT(){
            string content = "";
            for (int i = 0; i < srtlines.Count; i++ )
            {
                content = srtlines[i].Index.ToString() + "\n"

                    //+ srtlines[i].start_time.getStartTime() + "\n"
                    //+ srtlines[i].end_time.getEndTime() + "\n"
                    //+ srtlines[i].line+"\n\n"
                    ;
                
            }
            return content;

        }

    }
}
