using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Domain.Utils
{
    public class ConsoleLoggerOutput: ILoggerOutput
    {
        private static object synclock = new object();
        private static ConsoleLoggerOutput _Instance = null;
        public static ConsoleLoggerOutput Instance 
        {
            get 
            {
                lock(synclock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new ConsoleLoggerOutput();
                    }
                    return _Instance;
                }
            }        
        }


        #region Windows Console DLL

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);          //extern benutzt man wenn auf externe dlls zugreifen möchte...in diesem fall ist das eine c++ file und man kann mit dllimport zugreifen.

        #endregion


        private ConsoleLoggerOutput()        //kann von außen nicht mit this aufgerufen werden...das ist ja der sinn von singleton....nur mit FileLogger.Instance weil Instance ja public ist...awesome
        {
            AttachConsole(-1); //Call Windos DLL ....-1 bedeutet das man die konsole für den jetzigen prozess haben will.
        }


        public void Write(LoggerEntry entry) 
        {
            Console.WriteLine(entry);
        }
    }
}
