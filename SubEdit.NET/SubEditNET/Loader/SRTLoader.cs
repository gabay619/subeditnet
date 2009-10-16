using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
           StreamReader srtFileReader = new System.IO.StreamReader(path);

            //ANSI Handling
           if (encoding == FileEncoding.ANSI)
           {
              return readANSI(path);
           }

            //UTF16LE Handling
            if (encoding == FileEncoding.UTF16_LITTLE_ENDIAN)
            {
                return readUTF16LE(path);
            }
            //UTF8 Handling
            if (encoding == FileEncoding.UTF8)
            {
                return readUTF8(path);
            }

            //TODO: proper error handling
            //case0: no encoding
            //case1: reading errors
            return null;

        }

        public void readSRT_OLD(string path)
        {
          

         

            //initialize streamreader and write to a string
            StreamReader srtFileReader = new System.IO.StreamReader(path);
         //   string srtFile = srtFileReader.ReadToEnd();


            string currentLine;
          //  LineType currentLineType = LineType.LINEBREAK;
            //LineType lastLineType = LineType.LINEBREAK;

            while (( currentLine = srtFileReader.ReadLine()) != null)
            {
                if (IsNumeric(currentLine))
                {

                  //  currentLineType = LineType.INDEX;
                    logger.add("INDEX:" + currentLine, Level.DEBUG);
                }
          
                if (currentLine.Contains("-->"))
                {
                  //  lastLineType = currentLineType;
                   // currentLineType = LineType.TIMELINE;

                    logger.add("TIMELINE:"+currentLine, Level.DEBUG);
                }
                if (currentLine.Contains("<"))
                {
                   // lastLineType = currentLineType;
                    //currentLineType = LineType.TEXT_START;

                    logger.add("TEXTLINE START:" + currentLine, Level.DEBUG);
                }
              //  if (lastLineType == LineType.TEXT_START && (!currentLine.Contains("<") && (!currentLine.Contains(">") )))
              //  {
            //        logger.add("TEXTLINE MIDDLE:" + currentLine, Level.DEBUG);
              //  }
                if (currentLine.Contains(">") && !(currentLine.Contains("-->")))
                {
                  //  lastLineType = currentLineType;
                   // currentLineType = LineType.TEXT_END;

                    logger.add("TEXTLINE END:" + currentLine, Level.DEBUG);
                }


                else
                {
                    logger.add("NOT RECOGNIZED:" + currentLine, Level.DEBUG);
                }
            }

            //TODO: analyze srtFile and write to SRT objects
            
            
            
            
            //TODO: change return type to SRT Object
            
            //logger.add(srtFile,Level.DEBUG);
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
                logger.add("UTF8", Level.DEBUG);

            }

            if (rawData[0] == 0xFF && rawData[1] == 0xFE)
            {
                encoding = FileEncoding.UTF16_LITTLE_ENDIAN;
                logger.add("UTF16_LITTLE_ENDIAN", Level.DEBUG);

            }

            if (rawData[0] == 0xFE && rawData[1] == 0xFF)
            {
                encoding = FileEncoding.UTF16_BIG_ENDIAN;
                logger.add("UTF16_BIG_ENDIAN", Level.DEBUG);

            }

            if (rawData[0] != 0xFE && rawData[0] != 0xFF && rawData[0] != 0xEF)
            {
                encoding = FileEncoding.ANSI;
                logger.add("ANSI", Level.DEBUG);
            }


            return encoding;

        }


        private SRT readANSI(string path)
        {
            SRT ansiSRT = new SRT();

            Entities.SRTToken line = new Entities.SRTToken();

            StreamReader srtFileReader = new System.IO.StreamReader(path);
            string currentLine = null;
            while ((currentLine = srtFileReader.ReadLine()) != null)
            {
                //CHECK IF LINE IS NEW INDEX
                 if (IsNumeric(currentLine))
                 {
                     line.setID(Convert.ToInt32(currentLine));
                     logger.add("INDEX:" + currentLine, Level.DEBUG);

                 }//ENDIF

                //CHECK IF LINE IS TIMELINE
                 if (currentLine.Contains("-->"))
                 {
                     //char[] arr = currentLine.ToCharArray();

                     line.setStartTime(currentLine.Substring(0, 12));
                     line.setEndTime(currentLine.Substring(17, 12));
                     //logger.add("s_substr: " + line.start_time.getStartTime(), Level.DEBUG);
                     //logger.add("e_substr: " + line.end_time.getEndTime(), Level.DEBUG);
                     logger.add("TIMELINE:" + currentLine, Level.DEBUG);
                 }//ENDIF

                //CHECK IF LINE IS CONTENT LINE
                 if ((IsNumeric(currentLine) == false) && (currentLine.Contains("-->") == false) && ((currentLine == "") == false))
                 {
                     //if line is still empty just add the current line
                     if (line.getLine() == null || line.getLine() == "")
                     {
                         line.setLine(currentLine);
                     }
                     //if line isnt empty add a space and the current line
                     else
                     {
                         line.setLine(line.getLine() + " " + currentLine);
                     }

                     logger.add("CONTENTLINE:" + currentLine, Level.DEBUG);
                 }//ENDIF

                //CHECK IF LINE IS COMPLETE
                 if (currentLine == "")
                 {
                     //check if line complete
                     if (line.getID() != 0 && line.getStartTime() != null && line.getEndTime() != null && line.getLine() != null)
                     {
                         logger.add("LINE COMPLETE!!", Level.DEBUG);

                      //   ansiSRT.addLine(line.id, line.start_time, line.end_time, line.);
                        ansiSRT.addLine(line);
                       // line.clearLine();
                        // line.clearLine();
                     }

                     //add to list
                  
                     logger.add("NEXT SECTION", Level.DEBUG);
                 }//ENDIF

            }
            return ansiSRT;
        }
        private SRT readUTF16LE(string path)
        {
            SRT utf16leSRT = new SRT();
            //string currentLine = null;

            //Entities.SRTLine line = new Entities.SRTLine();

            //while( (currentLine = srtFileReader.ReadLine()) != null ){

            //    if (IsNumeric(currentLine))
            //    {
            //        line.Index = Convert.ToInt32(currentLine);
            //        logger.add("INDEX:" + currentLine, Level.DEBUG);

            //    }

            //    if (currentLine.Contains("-->"))
            //    {
            //        line.addStartTime(currentLine.Substring(0, 12));
            //        logger.add("TIMELINE:" + currentLine, Level.DEBUG);
            //    }

            //    if ((IsNumeric(currentLine) == false) && (currentLine.Contains("-->") == false) && ( (currentLine == "") == false ) )
            //    {
            //        //if line is still empty just add the current line
            //        if (line.line == null || line.line == "") {
            //              line.line = currentLine;
            //        }
            //        //if line isnt empty add a space and the current line
            //        else {
            //            line.line = line.line + " " + currentLine;
            //        }

            //        logger.add("CONTENTLINE:" + currentLine, Level.DEBUG);
            //    }


            //    if(currentLine==""){
            //        //check if line complete
            //        if( line.Index != 0 && line.start_time != null && line.end_time != null && line.line != null){
            //            logger.add("LINE COMPLETE!!", Level.DEBUG);
            //        }

            //        //add to list
            //        srt.addLine(line);
            //        logger.add("NEXT SECTION", Level.DEBUG);


            //    }





            //}

            //if (currentLine == null)
            //{

            //    logger.add("EOF reached!", Level.DEBUG);

            // }






            return utf16leSRT;
        }
        private SRT readUTF16BE(string path)
        {
            SRT utf16beSRT = new SRT();



            return utf16beSRT;
        }

        private SRT readUTF8(string path)
        {
            SRT utf8SRT = new SRT();



            return utf8SRT;
        }


    }
}
