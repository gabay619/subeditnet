using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SubEditNET.Entities;
using SubEditNET.Logger;

namespace SubEditNET.Saver


{
    class SRTSaver
    {
        static SRTSaver instance = null;
        static readonly object padlock = new object();
        DebugLogger logger = DebugLogger.Instance;


        public SRTSaver()
        {
            logger.add("SRT Saver initialized.", Level.DEBUG);
        }

        public static SRTSaver Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SRTSaver();
                    }
                    return instance;
                }
            }
        }


        public void saveSRT(SRT srt, String path)
        {
            // create a writer and open the file
            TextWriter saveLog = new StreamWriter(path);

            // write a line of text to the file
            //saveLog.WriteLine(DateTime.Now);
            //saveLog.WriteLine();

            //saveLog.WriteLine(srt.getLineCounter());

            for (int i = 0; i < srt.getLineCounter(); i++ )
            {
                if (i != 0)
                {
                    //space after each token
                    saveLog.WriteLine();
                }
                SRTToken currentToken = srt.getToken(i);
                saveLog.WriteLine(currentToken.getID());
                saveLog.WriteLine(currentToken.getStartTimeString() + " --> " + currentToken.getEndTimeString());
                saveLog.WriteLine(currentToken.getLine());

            }

            // close the stream
            saveLog.Close();


        }
    }



}
