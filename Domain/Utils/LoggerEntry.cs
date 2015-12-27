using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Utils
{
    public class LoggerEntry
    {
        public Type Type { get; private set; } 
        public LogLevel Level { get; private set; } 
        public string Message { get; private set; }
        public Exception Exception { get; private set; } 
        public DateTime Timestamp { get; private set; }

        public LoggerEntry(Type type, LogLevel level, string message, Exception exc) 
        {
            Type = type;
            Level = level;
            Message = message;
            Exception = exc;
            Timestamp = DateTime.Now;
        }

        public override string ToString()           //mit override überschreibt man eine in der object Klasse vorhandene Methode namens ToString()....man kann zum beispiel keine methode in der klasse string überschreiben wenn man nicht in dieser ist...neu erstellte klassen(wie hier eben LoggerEntry) erben automatisch von der Klasse object...public class LoggerEntry : object wäre genau das selbe wie nur public class LoggerEntry
        {
            return string.Format("[{0}] Level={1} Type={2} \"{3}\"", Timestamp.ToString("yyyy-MM-dd HH:mm:ss") //wenn HH klein geschrieben wird dann wird zum beispiel 2 uhr nachmittags mit 02:00 angezeigt statt 14:00
                                                                                   , Level.ToString().PadRight(10)
                                                                                   , Type.FullName.PadRight(40)
                                                                                   , Message);                          //überall wo ToString über LoggerEntry.ToString() verwendet wird, wird dieses output geschrieben.
        }

    }
}
