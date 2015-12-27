using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Angebot : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>

        private long _ProjektID;
        public long ProjektID
        {
            get
            {
                return _ProjektID;
            }
            set
            {
                if (_ProjektID != value)
                {
                    _ProjektID = value;

                    OnPropertyChanged("ProjektID");
                }
            }
        }

        private long _KundenID;
        public long KundenID
        {
            get
            {
                return _KundenID;
            }
            set
            {
                if (_KundenID != value)
                {
                    _KundenID = value;

                    OnPropertyChanged("KundenID");
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

        private int _Dauer;
        public int Dauer
        {
            get
            {
                return _Dauer;
            }
            set
            {
                if (_Dauer != value)
                {
                    _Dauer = value;

                    OnPropertyChanged("Dauer");
                }
            }
        }

        private float _Chance;
        public float Chance
        {
            get
            {
                return _Chance;
            }
            set
            {
                if (_Chance != value)
                {
                    _Chance = value;

                    OnPropertyChanged("Chance");
                }
            }
        }
    }
}
