using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Domain.Utils
{
    public class FileLoggerOutput : ILoggerOutput
    {
        private static object synclock = new object();
        private static FileLoggerOutput _Instance = null;
        public static FileLoggerOutput Instance 
        {
            get 
            {
                lock(synclock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new FileLoggerOutput();
                    }
                    return _Instance;
                }
            }        
        }




        private FileLoggerOutput()        //kann von außen nicht mit this aufgerufen werden...das ist ja der sinn von singleton....nur mit FileLogger.Instance weil Instance ja public ist...awesome
        { 
        }



        private Queue<LoggerEntry> _WriteQueue = new Queue<LoggerEntry>();      //Queue Liste wird hier verwendet weil in dieser Art von Listen Elemente hinten hinzugefügt werden können und von den Threads einzeln abbehandelt.
        public Queue<LoggerEntry> WriteQueue                                    //Also...die Dequeue Funktion liefert das erste Element der Queue Liste an einem der hier verwendeten Logger Threads und wird dort abgearbeitet
        {                                                                       //Also ein Log Entry aka Error, Warning, Trace, Debug, Info, Fatal wird in den Threads behandelt und ausgegeben.
             get
             {  
                lock(this)
                {
                    return _WriteQueue;
                }
            }
        }

        private bool _Started = false;
        public bool Started
        {
            get
            {
                lock (this)
                {
                    return _Started;
                }
            }
            set 
            {
                lock (this) 
                {
                    _Started = true;
                }
            }
        }



        public void Write(LoggerEntry entry) 
        {
            WriteQueue.Enqueue(entry);
            Start();        
        }

        public void Start() 
        {
            lock (this) 
            {
                if (Started) return;
                Started = true;

                var thread = new Thread(new ThreadStart(Proc));
                thread.IsBackground = true;
                thread.Name = "Logger";
                thread.Priority = ThreadPriority.BelowNormal;
                thread.Start();
            }
        
        }

        public void Proc() 
        {
            using (var file = new StreamWriter("log.txt"))
            {
                while (true)
                {
                    Thread.Sleep(10);
                    if (WriteQueue.Count == 0) continue;

                    var entry = WriteQueue.Dequeue();
                    file.WriteLine(entry);
                    file.Flush();       //Dadurch das ein LoggerThread ein backgroundthread is und automatisch beendet wird wenn die gesamte applikation beendet wird dann kann es passieren
                                        //das der Streamwriter Text noch in einem Buffer hat und diese nicht fertig in die log.txt file schreibt...deswegen wird hier flush angwendet um den Rest
                }                       //auszuschreiben der noch im Buffer steht.
            }
        }
    }
}
