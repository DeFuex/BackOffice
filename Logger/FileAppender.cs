using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger
{
    public class FileAppender : IAppender
    {


        public void configure()
        {
            
        }

        public void write(LogLevel.Level level, string message, Exception ex, string StackTrace)
        {


            switch (level)
            {
                case LogLevel.Level.Debug:

                case LogLevel.Level.Error:

                case LogLevel.Level.Fatal:
                
                case LogLevel.Level.Info:

                case LogLevel.Level.Trace:

                case LogLevel.Level.Warn:

                default:

                    break;
            }

        bool bReturn        = false;
        string strException    = string.Empty;
        
        try
        {
            sw = new StreamWriter(strPathName,true);
            sw.WriteLine("Source        : " + 
                    objException.Source.ToString().Trim());
            sw.WriteLine("Method        : " + 
                    objException.TargetSite.Name.ToString());
            sw.WriteLine("Date        : " + 
                    DateTime.Now.ToLongTimeString());
            sw.WriteLine("Time        : " + 
                    DateTime.Now.ToShortDateString());
            sw.WriteLine("Computer    : " + 
                    Dns.GetHostName().ToString());
            sw.WriteLine("Error        : " +  
                    objException.Message.ToString().Trim());
            sw.WriteLine("Stack Trace    : " + 
                    objException.StackTrace.ToString().Trim());
            sw.WriteLine("^^------------------------
                    -------------------------------------------^^");
            sw.Flush();
            sw.Close();
            bReturn    = true;
        }
        catch(Exception)
        {
            bReturn    = false;
        }
        return bReturn;

        }
    }
}
