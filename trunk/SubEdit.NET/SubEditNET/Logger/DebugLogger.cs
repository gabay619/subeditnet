using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubEditNET.Logger
{
    class DebugLogger
    {
        Level level = Level.DEBUG;
        Status status = Status.ENABLED;
        static DebugLogger instance = null;
        static readonly object padlock = new object();
        String currentLog = "";
        

        public DebugLogger()
        {
            add("Log initalized with Level: " + level,Level.DEBUG);
            //Log initalized with Level: "+debugLogger.getLevel(), Level.DEBUG);
        }


        public static DebugLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DebugLogger();
                    }
                    return instance;
                }
            }
        }

      public  string getCurrentLog(){
          if (status == Status.ENABLED)
          {
              return currentLog;
          }
          else
              return "";
        }

      public void add(string text_to_add, Level level)
      {
          if (this.level == level)
          {
              this.currentLog = currentLog + "[" + DateTime.Now + "] " + "[" + text_to_add + "]" + "\r\n";
          }
    

      }

      public void clear()
      {

          this.currentLog = "";
      }

      public void setStatus(Status status)
      {
          this.status = status;
      }

      public void setLevel(Level level)
      {
          this.level = level;
      }

      public Level getLevel()
      {
          return this.level;
      }


    }


    enum Level
    {
        NORMAL, DEBUG, EXPERT
    }

    enum Status
    {
        ENABLED,
        DISABLED
    }




}
