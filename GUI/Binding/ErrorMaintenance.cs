using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Binding
{
    public class ErrorMaintenance : Label
    {
        public ErrorMaintenance()
                : base()
        {
            this.Text = "";
        }

        public void setError(string msg)
        {
            this.Text = msg;
        }

        public void clearError()
        {
            this.Text = "";
        }
    }
}
