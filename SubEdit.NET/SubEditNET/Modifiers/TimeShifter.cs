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
            //read old starting values
            int h_old = srt.getToken(0).getStartTime().getHour();
            int m_old = srt.getToken(0).getStartTime().getMinute();
            int s_old = srt.getToken(0).getStartTime().getSecond();
            int ms_old = srt.getToken(0).getStartTime().getMilliSecond();

            //get new starting values
            int h_new = time.getHour();
            int m_new = time.getMinute();
            int s_new = time.getSecond();
            int ms_new = time.getMilliSecond();

            //determine difference
            int h_diff = h_new - h_old;
            int m_diff = m_new - m_old;
            int s_diff = s_new - s_old;
            int ms_diff = ms_new - ms_old;

            for (int i = 0; i < srt.getLineCounter(); i++ )
            {

                int h_old_st = srt.getToken(i).getStartTime().getHour();
                int m_old_st = srt.getToken(i).getStartTime().getMinute();
                int s_old_st = srt.getToken(i).getStartTime().getSecond();
                int ms_old_st = srt.getToken(i).getStartTime().getMilliSecond();

                int h_old_end = srt.getToken(i).getEndTime().getHour();
                int m_old_end = srt.getToken(i).getEndTime().getMinute();
                int s_old_end = srt.getToken(i).getEndTime().getSecond();
                int ms_old_end = srt.getToken(i).getEndTime().getMilliSecond();

                srt.getToken(i).setStartTime(new SRTTime(h_old_st + h_diff, m_old_st + m_diff, s_old_st + s_diff, ms_old_st + ms_diff));
                srt.getToken(i).setEndTime(new SRTTime(h_old_end + h_diff, m_old_end + m_diff, s_old_end + s_diff, ms_old_end + ms_diff));


            }

            return srt;
        }


    }
}
