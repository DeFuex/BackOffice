using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class RechnungBuchung : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>
        /// 
        private long _BuchungszeilenID;
        public long BuchungszeilenID
        {
            get
            {
                return _BuchungszeilenID;
            }
            set
            {
                if (_BuchungszeilenID != value)
                {
                    _BuchungszeilenID = value;

                    OnPropertyChanged("BuchungszeilenID");
                }
            }
        }

        private long _RechnungsID;
        public long RechnungsID
        {
            get
            {
                return _RechnungsID;
            }
            set
            {
                if (_RechnungsID != value)
                {
                    _RechnungsID = value;

                    OnPropertyChanged("RechnungsID");
                }
            }
        }

        private string _Rechnungstyp;
        public string Rechnungstyp
        {
            get
            {
                return _Rechnungstyp;
            }
            set
            {
                if (_Rechnungstyp != value)
                {
                    _Rechnungstyp = value;

                    OnPropertyChanged("Rechnungstyp");
                }
            }
        }

    }
}
