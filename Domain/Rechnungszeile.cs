using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Rechnungszeile : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>

        private long _AngebotID;
        public long AngebotID
        {
            get
            {
                return _AngebotID;
            }
            set
            {
                if (_AngebotID != value)
                {
                    _AngebotID = value;

                    OnPropertyChanged("AngebotID");
                }
            }
        }

        private long _AusgangsrechnungID;
        public long AusgangsrechnungID
        {
            get
            {
                return _AusgangsrechnungID;
            }
            set
            {
                if (_AusgangsrechnungID != value)
                {
                    _AusgangsrechnungID = value;

                    OnPropertyChanged("AusgangsrechnungID");
                }
            }
        }

        private string _Bezeichnung;
        public string Bezeichnung
        {
            get
            {
                return _Bezeichnung;
            }
            set
            {
                if (_Bezeichnung != value)
                {
                    _Bezeichnung = value;

                    OnPropertyChanged("Bezeichnung");
                }
            }
        }

        private double _Betrag;
        public double Betrag
        {
            get
            {
                return _Betrag;
            }
            set
            {
                if (_Betrag != value)
                {
                    _Betrag = value;

                    OnPropertyChanged("Betrag");
                }
            }
        }
    }
}
