using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI.Binding
{
    public interface IRule
    {
        bool Eval(object value, ErrorMaintenance ctrl);
    }
    
}
