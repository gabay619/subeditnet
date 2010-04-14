using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SubEditNET.Entities;
using SubEditNET.Logger;

namespace SubEditNET.Modifiers
{
     class TimeShifter
    {
        static TimeShifter instance = null;
        static readonly object padlock = new object();
        DebugLogger logger = DebugLogger.Instance;

        public TimeShifter()
        {
            logger.add("TimeShifter initialized.", Level.DEBUG);
        }

        public static TimeShifter Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TimeShifter();
                    }
                    return instance;
                }
            }
        }

        public SRT shiftTime(SRT srt, SRTTime time)
        {


            return srt;
        }


    }
}
