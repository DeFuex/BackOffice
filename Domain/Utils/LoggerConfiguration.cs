using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Domain.Utils
{
    public class LoggerConfiguration
    {
        private static LoggerConfiguration _Instance;
        public static LoggerConfiguration Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoggerConfiguration();
                    _Instance.Load();                       //da in der Load() Methode schon auf den aktuellen Logger zugegriffen wird, wird über this.GetLogger() der Logger geholt
                }                                           //Über Getlogger kommt der Loggerwert zurück und greift auf diese Instance zu. _Instance ist nicht mehr null wenn 
                return _Instance;                           //der private konstruktor ausgeführt ist. Man schreibt eine extra Load() Methode weil man in der Load Methode schon auf das Objekt(in diesem Fall "Instance" von dem Singleton der LoggerConfiguration Klasse) zugreifen will (und schreibt dessen Inhalt absichtlich nicht in den Konstruktor)
            }                                               //In der Load Methode wird diese Intance schon gebraucht, weil man ja auf die Instance der FileLoggerOutput Klasse zugreifen will um zum Beispiel den Loggertyp oder das LogLevel zu bekommen. Es wird passieren das man in einer Endlosschleife hängt wenn man keine Load() Methode schreibt und alles in den private Konstruktor definiert. Die Instance wird vorher nicht null werden um die Instance des FileLoggerOutput zu verwenden. 
        }

        public LogLevel LogLevel { get; private set; }
        public ILoggerOutput LoggerOutput { get; private set; }

        private LoggerConfiguration()       //Hier speichert man Standardwerte für LogLevel und LogOutput. Wenn in der app config falsche Werte
        {                                   //oder gar keine Werte für diese Keys dastehen
            LogLevel = Utils.LogLevel.Debug;
            LoggerOutput = FileLoggerOutput.Instance;
        }


        private void Load() 
        {
            string loggerOutputConfiguration = ConfigurationManager.AppSettings["LoggerOutput"] ?? string.Empty;

            if (loggerOutputConfiguration.ToLower().Equals("File".ToLower()))
            {
                LoggerOutput = FileLoggerOutput.Instance;
            }
            else if (loggerOutputConfiguration.ToLower().Equals("Console".ToLower()))
            {
                LoggerOutput = ConsoleLoggerOutput.Instance;
            }
            else
            {
                this.GetLogger().Warn("No valid loggerOutput configured in app.config. Logger-output is now set to 'File'.");
            }


            string logLevelConfiguration = ConfigurationManager.AppSettings["LogLevel"] ?? string.Empty;

            try
            {
                LogLevel = (LogLevel)Enum.Parse(typeof(LogLevel), logLevelConfiguration, true);
            }
            catch (Exception exc)
            {
                this.GetLogger().Warn("No valid LogLevel configured in app.config. LogLevel is now set to 'Debug'");    
            }
        }
    }
}
