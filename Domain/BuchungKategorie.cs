using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class BuchungKategorie : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>
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

        private long _KategorieID;
        public long KategorieID
        {
            get
            {
                return _KategorieID;
            }
            set
            {
                if (_KategorieID != value)
                {
                    _KategorieID = value;

                    OnPropertyChanged("KategorieID");
                }
            }
        }
    }
}
