using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Utils
{
    public interface ILoggerOutput
    {
        void Write(LoggerEntry entry);
    }
}
