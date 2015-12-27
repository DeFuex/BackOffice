using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Domain
{
    public abstract class BaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propname) 
        {
            var temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(propname));
            }
        
        }


        private long _ID;
        /// <summary>
        /// ist Key für diese Entität
        /// </summary>
        public long ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;

                OnPropertyChanged("ID");
            }
        }


    }
}
