using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    //Der Primary Key ist in BuchgKategorie ein Fremdschlüssel

    public class Kategorie : BaseObject //nur kategorie??
    {
        private string _KategorieTyp;  
        public string KategorieTyp
        {
            get
            {
                return _KategorieTyp;
            }
            set 
            {
                if (_KategorieTyp != value)
                {
                    _KategorieTyp = value;

                    OnPropertyChanged("Kategorie");
                }
            } 
        
        }
    }
}
