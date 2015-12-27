using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger
{
    public interface IAppender
    {
        public void configure(); 
        public void write(LogLevel level, string message, Exception ex, string StackTrace);

    }
}
