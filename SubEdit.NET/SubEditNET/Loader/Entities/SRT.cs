using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubEditNET.Loader.Entities;

namespace SubEditNET.Loader
{
    class SRT
    {

       private List<SRTToken> srtlines = new List<SRTToken>();
        //String encoding;


        //public void addLine(int index,string starttime, string endtime, string line)
        //{
        //    SRTLine newLine = new SRTLine();
        //    newLine.id = index;

        //    newLine.addStartTime(starttime);
        //    newLine.addEndTime(endtime);
     
        //    newLine.line = line;

        //    srtlines.Add(newLine);
        //}

       public void addLine(SRTToken line)
       {
           srtlines.Add(line);
       }



        public string printSRT(){
            string content = "";
            for (int i = 0; i < srtlines.Count; i++ )
            {
                content = srtlines[i].getID() + " "

                    + srtlines[i].getStartTime() + " "
                    + srtlines[i].getEndTime() + " "
                     + srtlines[i].getLine() +" "
                    ;
                
            }
            return content;

        }

    }
}
