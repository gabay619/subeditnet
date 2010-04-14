using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
            logger.add("[SRTSaver] SRT Saver initialized.", Level.DEBUG);
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



        }
    }



}
