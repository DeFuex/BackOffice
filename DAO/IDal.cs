using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public interface IDal
    {
        IProjektDal ProjektDal { get; }
        IAngebotDal AngebotDal { get; }
        IAusgangsrechnungDal AusgangsrechnungDal { get; }
        IBuchungKategorieDal BuchungKategorieDal { get; }
        IBuchungszeileDal BuchungszeileDal { get; }
        IEingangsrechnungDal EingangsrechnungDal { get; }
        IKategorieDal KategorieDal { get; }
        IKontaktDal KontaktDal { get; }
        IKundeDal KundeDal { get; }
        IRechnungBuchungDal RechnungBuchungDal { get; }
        IRechnungszeileDal RechnungszeileDal { get; }
    }
}
