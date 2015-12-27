using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI.Binding
{
    public class PositiveInputRule : IRule
    {
        public bool Eval(object value, ErrorMaintenance ctrl)
        {
            if (value is int)
            {
                if ((int)value < 0)
                {
                    ctrl.setError("Der Wert muss positiv sein!");
                    return false;
                }
            }
            else if (value is double)
            {
                if ((double)value < 0)
                {
                    ctrl.setError("Der Wert muss positiv sein!");
                    return false;
                }
            }
            else if (value is long)
            {
                if ((long)value < 0)
                {
                    ctrl.setError("Der Wert muss positiv sein!");
                    return false;
                }
            }

            return true;
        }
    }
}