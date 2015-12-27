using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Utils;

namespace DAL.Fake
{
    public class FakeDal : IDal
    {

        public IProjektDal ProjektDal { get; private set; }
        public IAngebotDal AngebotDal { get; private set; }
        public IAusgangsrechnungDal AusgangsrechnungDal { get; private set; }
        public IBuchungKategorieDal BuchungKategorieDal { get; private set; }
        public IBuchungszeileDal BuchungszeileDal { get; private set; }
        public IEingangsrechnungDal EingangsrechnungDal { get; private set; }
        public IKategorieDal KategorieDal { get; private set; }
        public IKontaktDal KontaktDal { get; private set; }
        public IKundeDal KundeDal { get; private set; }
        public IRechnungBuchungDal RechnungBuchungDal { get; private set; }
        public IRechnungszeileDal RechnungszeileDal { get; private set; }

        public FakeDal()
        {
            this.GetLogger().Debug("Initializing Fake-DAL");

            ProjektDal = new FakeProjektDal();
            AngebotDal = new FakeAngebotDal();
            BuchungKategorieDal = new FakeBuchungKategorieDal();
            BuchungszeileDal = new FakeBuchungszeileDal();
            AusgangsrechnungDal = new FakeAusgangsrechnungDal();
            EingangsrechnungDal = new FakeEingangsrechnungDal();
            KategorieDal = new FakeKategorieDal();
            KontaktDal = new FakeKontaktDal();
            KundeDal = new FakeKundeDal();
            RechnungBuchungDal = new FakeRechnungBuchungDal();
            RechnungszeileDal = new FakeRechnungszeileDal();
        }
    }
}
