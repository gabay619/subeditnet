using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SubEditNET.Entities;
using SubEditNET.Logger;
using System.IO;


namespace SubEditNET.Loader
{
    class SRTLoader
    {
        static SRTLoader instance = null;
        static readonly object padlock = new object();
        DebugLogger logger = DebugLogger.Instance;

       public  SRTLoader()
        {
            logger.add("SRT Loader initialized.", Level.DEBUG);
        }
        public static SRTLoader Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SRTLoader();
                    }
                    return instance;
                }
            }
        }

        public SRT readSRT(string path)
        {
           FileEncoding encoding = determineEncoding(path);

            //ANSI Handling
           if (encoding == FileEncoding.ANSI)
           {
               StreamReader srtFileReader = new System.IO.StreamReader(path, Encoding.Default);
               return readFile(srtFileReader, path);
           }

           // //UTF16LE Handling
           if (encoding == FileEncoding.UTF16_LITTLE_ENDIAN)
           {
               StreamReader srtFileReader = new System.IO.StreamReader(path, Encoding.Unicode);
               return readFile(srtFileReader, path);
           }

           // //UTF8 Handling
           if (encoding == FileEncoding.UTF8)
           {
               StreamReader srtFileReader = new System.IO.StreamReader(path, Encoding.UTF8);
               return readFile(srtFileReader, path);
           }
            
            //TODO: proper error handling
            //case0: no encoding
            //case1: reading errors
        
            return null;

        }

      

        private static bool IsNumeric(string s)
        {
            int n;
            return Int32.TryParse(s, out n);
        }

        enum LineType
        {
            INDEX, TIMELINE, TEXT_START, TEXT_MID, TEXT_END, LINEBREAK
        }

        enum FileEncoding
        {
            UTF8, UTF16_BIG_ENDIAN, UTF16_LITTLE_ENDIAN, ANSI
        }

        private FileEncoding determineEncoding(string path){

             FileEncoding encoding = FileEncoding.UTF8;
            
            //TODO: do not read complete file, instead really only the first bytes
            byte[] rawData = File.ReadAllBytes(path);

            if (rawData[0] == 0xEF && rawData[1] == 0xBB && rawData[2] == 0xBF)
            {
                encoding = FileEncoding.UTF8;
                logger.add("UTF8", Level.NORMAL);

            }

            if (rawData[0] == 0xFF && rawData[1] == 0xFE)
            {
                encoding = FileEncoding.UTF16_LITTLE_ENDIAN;
                logger.add("UTF16_LITTLE_ENDIAN", Level.NORMAL);

            }

            if (rawData[0] == 0xFE && rawData[1] == 0xFF)
            {
                encoding = FileEncoding.UTF16_BIG_ENDIAN;
                logger.add("UTF16_BIG_ENDIAN", Level.NORMAL);

            }

            if (rawData[0] != 0xFE && rawData[0] != 0xFF && rawData[0] != 0xEF)
            {
                encoding = FileEncoding.ANSI;
                logger.add("ANSI", Level.NORMAL);
            }


            return encoding;

        }


        private SRT readFile(StreamReader srtFileReader, string path)
        {
            SRT srt = new SRT();

            Entities.SRTToken line = new Entities.SRTToken();

            string currentLine = null;

            while ((currentLine = srtFileReader.ReadLine()) != null)
            {
             
                //CHECK IF LINE IS NEW INDEX
                 if (IsNumeric(currentLine))
                 {
                     if (currentLine != "1")
                     {
                         srt.addLine(line);
                         line = new Entities.SRTToken();
                     }

                     line.setID(Convert.ToInt32(currentLine));
                     logger.add("INDEX:" + currentLine, Level.DEBUG);

                 }

                ////CHECK IF LINE IS TIMELINE
                 if (currentLine.Contains("-->"))
                 {
                     //char[] arr = currentLine.ToCharArray();

                     line.setStartTimeString(currentLine.Substring(0, 12));
                     line.setEndTimeString(currentLine.Substring(17, 12));
                     //logger.add("s_substr: " + line.start_time.getStartTime(), Level.DEBUG);
                     //logger.add("e_substr: " + line.end_time.getEndTime(), Level.DEBUG);
                     logger.add("TIMELINE:" + currentLine, Level.DEBUG);
                 }//ENDIF

                //CHECK IF LINE IS CONTENT LINE
                 if ((IsNumeric(currentLine) == false) && (currentLine.Contains("-->") == false) && ((currentLine == "") == false))
                 {
                     //if line is still empty just add the current line
                     if (line.getLine() == null || line.getLine() == "") //|| !currentLine.Contains("-->") || !IsNumeric(currentLine)
                     {
                         line.setLine(currentLine);
                     }
                     //if line isnt empty add a space and the current line
                     else
                     {
                         line.setLine(line.getLine() + System.Environment.NewLine + currentLine);
                     }

                     logger.add("CONTENTLINE:" + currentLine, Level.DEBUG);
                 }//ENDIF   
            }
            srt.addLine(line);
            return srt;
        }
  
    }
}
