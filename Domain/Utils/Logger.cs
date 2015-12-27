using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Utils
{
    public class Logger
    {
        public Type CurrentType { get; private set; }

        public Logger(Type type)                            //nach dem holen eines objects durch die GetLogger() Methode (steht zum beispiel ein Klassenname drin wenn man mit this arbeitet...mit gettype kann man sich zusätzliche informationen über der klasse holen).
        {                                                   //in loggerextension wurde als letzter befehl eine new Logger Klasse erstellt mit dem geholten object der GetLogger() Methode und wird hier natürlich in der Logger Klasse übergeben.
            CurrentType = type;                             //das object wird sofort mit dem type definiert und über den konstruktor in die property CurrentType geschrieben.
        }

        public void Debug(string message)                   { Write(LogLevel.Debug, message, null); }       //hier werden die Methoden der Meldungen erstellt...um in der selbst geschreibenen write Methode
        public void Trace(string message)                   { Write(LogLevel.Trace, message, null); }       //einen LogLevel(warn, info, error usw.), eine message und eine exception gegeben oder eben gar nichts(null)
        public void Warn(string message)                    { Write(LogLevel.Warn, message, null); }        //je nachdem welche methode man verwendet.
        public void Info(string message)                    { Write(LogLevel.Info, message, null); }
        public void Error(string message, Exception exc)    { Write(LogLevel.Error, message, null); }
        public void Error(Exception exc)                    { Write(LogLevel.Error, exc.Message, exc); }
        public void Fatal(string message, Exception exc)    { Write(LogLevel.Fatal, message, exc); }

        public void Write(LogLevel level, string message, Exception exc) 
        {
            if (LoggerConfiguration.Instance.LogLevel > level)              //Da wird der Level der app.config Datei festgelegt. Praktisch ab welchem Level aufwärts ausgegeben werden soll...
            {                                                               //wenn warn im Level steht wird noch Infor, Error, Fatal ausgegeben...Debug und Trace nicht.
                return;
            }
            LoggerConfiguration.Instance.LoggerOutput.Write(new LoggerEntry(CurrentType, level, message, exc)); //hier wird die Methode Write aus der single Instance von FileLoggerOutput geöffnet und Einträge bzw. Daten
                                                                                                                //von der LoggerEntry in die log.txt file geschrieben(wenn in app.config "file" drinsteht).
        }                                                                                                       //Wichtig!!! -> zusätzlich wird über die Load() Methode der single instance aus der klasse LoggerConfiguration
    }                                                                                                           //entschieden ob in die log.txt (also in app.config "file" steht) geschrieben wird oder eben in die Konsole (app.config "console")
}                                                                                                               //wenn eben console in app.config vorhanden ist, dann wird die single instance methode von ConsoleLoggerOutput verwendet. public void Write(LoggerEntry entry)
