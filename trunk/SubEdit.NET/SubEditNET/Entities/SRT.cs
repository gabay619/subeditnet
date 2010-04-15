using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubEditNET.Entities;

namespace SubEditNET.Entities
{
    /// <summary>
    /// This class represents an SRT Object, which is used to handle SRT-Files in this program.
    /// </summary>
    class SRT
    {

       private List<SRTToken> srtlines = new List<SRTToken>();
        
       /// <summary>
       /// This methods adds a new subtitle line (token) which contains an Index, StartTime, EndTime and the Content
       /// </summary>
       /// <param name="line"></param>
       public void addLine(SRTToken line)
       {
           srtlines.Add(line);
       }

        public string printSRT(){
            string content = "";
            for (int i = 0; i < srtlines.Count; i++ )
            {
                content = srtlines[i].getID() + " "

                    + srtlines[i].getStartTimeString() + " "
                    + srtlines[i].getEndTimeString() + " "
                     + srtlines[i].getLine() +" "
                    ;
                
            }
            return content;

        }

        public int getLineCounter()
        {
            return srtlines.Count;
        }

        public SRTToken getToken(int index)
        {
            return srtlines[index];
        }

    }
}
