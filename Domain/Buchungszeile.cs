using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Buchungszeile : BaseObject
    {
        /// <summary>
        /// Fremdschlüssel
        /// Anmerkung: Primary Key wird automatisch mit abstrakter Klasse
        ///            Baseobjekt eingebunden
        /// </summary>

        private string _Bankkonto;
        public string Bankkonto
        {
            get
            {
                return _Bankkonto;
            }
            set
            {
                if (_Bankkonto != value)
                {
                    _Bankkonto = value;

                    OnPropertyChanged("Bankkonto");
                }
            }
        }

        private double _Rechnungssumme;
        public double Rechnungssumme
        {
            get
            {
                return _Rechnungssumme;
            }
            set
            {
                if (_Rechnungssumme != value)
                {
                    _Rechnungssumme = value;

                    OnPropertyChanged("Rechnungssumme");
                }
            }
        }

        private double _Ust;
        public double Ust
        {
            get
            {
                return _Ust;
            }
            set
            {
                if (_Ust != value)
                {
                    _Ust = value;

                    OnPropertyChanged("Ust");
                }
            }
        }
    }
}
