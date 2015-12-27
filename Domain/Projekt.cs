using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Domain
{
    public class Projekt : BaseObject
    {

        //Primary Key ist Fremdschlüssel in Ausgangsrechnung und Angebot

        private double _Gesamtzeit;
        /// <summary>
        /// in Stunden
        /// </summary>
        public double Gesamtzeit
        {
            get
            {
                return _Gesamtzeit;
            }
            set
            {
                if (_Gesamtzeit != value)
                {
                    _Gesamtzeit = value;

                    OnPropertyChanged("Gesamtzeit");
                }
            }
        }
        
        private string _Name = ""; //_Name wird "" eingefügt, da der string anfangs null ist.
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Property Name shouldn't be null!");
                _Name = value;

                OnPropertyChanged("Name");
                //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public override string ToString()
        {
            return "Projekt(ID=" + ID.ToString() + "; Name=" + Name + "; Gesamtzeit=" + Gesamtzeit.ToString() + ")";
        }
        public override bool Equals(object obj)
        {
            if (obj is Projekt)
            {
                var proj = obj as Projekt;

                if (this.ID != proj.ID) return false;
                if (this.Gesamtzeit != proj.Gesamtzeit) return false;
                if (!this.Name.Equals(proj.Name)) return false;

                return true;
            }

            return false;
        }

    }
}
