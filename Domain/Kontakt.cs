using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Kontakt : BaseObject
    {
        //Der Primary Key ist in BuchgKategorie ein Fremdschlüssel

        private string _Firmenname;
        public string Firmenname
        {
            get
            {
                return _Firmenname;
            }
            set
            {
                if (_Firmenname != value)
                {
                    _Firmenname = value;

                    OnPropertyChanged("Firmenname");
                }
            }
        }

        private string _Nachname;
        public string Nachname
        {
            get
            {
                return _Nachname;
            }
            set
            {
                if (_Nachname != value)
                {
                    _Nachname = value;

                    OnPropertyChanged("Nachname");
                }
            }
        }

        private string _Vorname;
        public string Vorname
        {
            get
            {
                return _Vorname;
            }
            set
            {
                if (_Vorname != value)
                {
                    _Vorname = value;

                    OnPropertyChanged("Vorname");
                }
            }
        }

        private string _Adresse;
        public string Adresse
        {
            get
            {
                return _Adresse;
            }
            set
            {
                if (_Adresse != value)
                {
                    _Adresse = value;

                    OnPropertyChanged("Adresse");
                }
            }
        }

        //private string _Hausnummer;
        //public string Hausnummer
        //{
        //    get
        //    {
        //        return _Hausnummer;
        //    }
        //    set
        //    {
        //        if (_Hausnummer != value)
        //        {
        //            _Hausnummer = value;

        //            OnPropertyChanged("Hausnummer");
        //        }
        //    }
        //}

        private int _Plz;
        public int Plz
        {
            get
            {
                return _Plz;
            }
            set
            {
                if (_Plz != value)
                {
                    _Plz = value;

                    OnPropertyChanged("Plz");
                }
            }
        }

        private string _Ort;
        public string Ort
        {
            get
            {
                return _Ort;
            }
            set
            {
                if (_Ort != value)
                {
                    _Ort = value;

                    OnPropertyChanged("Ort");
                }
            }
        }

        private string _Telefon;
        public string Telefon
        {
            get
            {
                return _Telefon;
            }
            set
            {
                if (_Telefon != value)
                {
                    _Telefon = value;

                    OnPropertyChanged("Telefon");
                }
            }
        }

        private string _Bemerkungen;
        public string Bemerkungen
        {
            get
            {
                return _Bemerkungen;
            }
            set
            {
                if (_Bemerkungen != value)
                {
                    _Bemerkungen = value;

                    OnPropertyChanged("Bemerkungen");
                }
            }
        }

        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (_Email != value)
                {
                    _Email = value;

                    OnPropertyChanged("Email");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Vorname ?? "NULL", Nachname ?? "NULL");
        }

    }
}
