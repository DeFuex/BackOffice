using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Eingangsrechnung : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>
        private long _KontaktID;
        public long KontaktID
        {
            get
            {
                return _KontaktID;
            }
            set
            {
                if (_KontaktID != value)
                {
                    _KontaktID = value;

                    OnPropertyChanged("KontaktID");
                }
            }
        }

        private double _Summe;
        public double Summe
        {
            get
            {
                return _Summe;
            }
            set
            {
                if (_Summe != value)
                {
                    _Summe = value;

                    OnPropertyChanged("Summe");
                }
            }
        }

        private DateTime _Datum;
        public DateTime Datum
        {
            get
            {
                return _Datum;
            }
            set
            {
                if (_Datum != value)
                {
                    _Datum = value;

                    OnPropertyChanged("Datum");
                }
            }
        }

        private string _Beschreibung;
        public string Beschreibung
        {
            get
            {
                return _Beschreibung;
            }
            set
            {
                if (_Beschreibung != value)
                {
                    _Beschreibung = value;

                    OnPropertyChanged("Beschreibung");
                }
            }
        }

        private Boolean _Offen;
        public Boolean Offen
        {
            get
            {
                return _Offen;
            }
            set
            {
                if (_Offen != value)
                {
                    _Offen = value;

                    OnPropertyChanged("Offen");
                }
            }
        }
    }
}
