using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class AusgangsrechnungTest
    {
        [Test]
        public void AddAusgangsrechnungTest()
        {
            Ausgangsrechnung ar = new Ausgangsrechnung();
            ar.Beschreibung = "Testrechnung";
            ar.Datum = DateTime.Parse("01-01-2013");
            ar.Gedruckt = true;
            ar.KundenID = 1;
            ar.Offen = false;
            ar.ProjektID = 1;
            ar.Summe = 1000;

            long sum = BusinessLogic.Instance.GetAllAusgangsrechnungen().Count;
            BusinessLogic.Instance.AddAusgangsrechnung(ar);
            long index = BusinessLogic.Instance.GetAllAusgangsrechnungen().Count;
            Assert.That(BusinessLogic.Instance.GetAllAusgangsrechnungen().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllAusgangsrechnungen().Contains(ar));
        }

        [Test]
        public void UpdateAusgangsrechnungTest()
        {
            Ausgangsrechnung ar = BusinessLogic.Instance.GetAusgangsrechnungByID(1);
            ar.Beschreibung = "Testrechnung";
            ar.Datum = DateTime.Parse("01-01-2013");
            ar.Gedruckt = true;
            ar.KundenID = 1;
            ar.Offen = false;
            ar.ProjektID = 1;
            ar.Summe = 1000;

            BusinessLogic.Instance.UpdateAusgangsrechnung(ar);
            Assert.IsTrue(BusinessLogic.Instance.GetAllAusgangsrechnungen().Contains(ar));
            Assert.That(BusinessLogic.Instance.GetAusgangsrechnungByID(1), Is.EqualTo(ar));
        }

        [Test]
        public void FindAusgangsrechnungTest()
        {
            List<Ausgangsrechnung> al = BusinessLogic.Instance.FindAusgangsrechnungen("Lieferant");

            Assert.That(al.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetAusgangsrechnungByIDTest()
        {
            Ausgangsrechnung ar = new Ausgangsrechnung();
            ar = BusinessLogic.Instance.GetAusgangsrechnungByID(1);

            Assert.That(ar.ID, Is.EqualTo(1));
        }

        [Test]
        public void GetAllAusgangsrechnungenTest()
        {
            List<Ausgangsrechnung> al = BusinessLogic.Instance.GetAllAusgangsrechnungen();

            Assert.That(al.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetAusgangsrechnungByBuchungTest()
        {
            List<Ausgangsrechnung> al = BusinessLogic.Instance.GetAusgangsrechnungByBuchung(1);

            Assert.That(al.Count, Is.EqualTo(1));
        }

        [Test]
        public void DeleteAusgangsrechnungTest()
        {
            Ausgangsrechnung ar = BusinessLogic.Instance.GetAusgangsrechnungByID(2);
            long sum = BusinessLogic.Instance.GetAllAusgangsrechnungen().Count;
            BusinessLogic.Instance.DeleteAusgangsrechnung(ar);

            Assert.IsFalse(BusinessLogic.Instance.GetAllAusgangsrechnungen().Contains(ar));
            Assert.That(BusinessLogic.Instance.GetAllAusgangsrechnungen().Count, Is.EqualTo(sum - 1));
        }
    }
}
