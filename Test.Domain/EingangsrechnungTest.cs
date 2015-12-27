using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class EingangsrechnungTest
    {
        [Test]
        public void AddEingangsrechnungTest()
        {
            Eingangsrechnung er = new Eingangsrechnung();
            er.Beschreibung = "Testrechnung";
            er.Datum = DateTime.Parse("01-01-2013");
            er.KontaktID = 1;
            er.Offen = false;
            er.Summe = 1000;

            long sum = BusinessLogic.Instance.GetAllEingangsrechnungen().Count;
            BusinessLogic.Instance.AddEingangsrechnung(er);
            long index = BusinessLogic.Instance.GetAllEingangsrechnungen().Count;
            Assert.That(BusinessLogic.Instance.GetAllEingangsrechnungen().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllEingangsrechnungen().Contains(er));
        }

        [Test]
        public void UpdateEingangsrechnungTest()
        {
            Eingangsrechnung er = BusinessLogic.Instance.GetEingangsrechnungByID(1);
            er.Beschreibung = "Testrechnung";
            er.Datum = DateTime.Parse("01-01-2013");
            er.KontaktID = 1;
            er.Offen = false;
            er.Summe = 1000;

            BusinessLogic.Instance.UpdateEingangsrechnung(er);
            Assert.IsTrue(BusinessLogic.Instance.GetAllEingangsrechnungen().Contains(er));
            Assert.That(BusinessLogic.Instance.GetEingangsrechnungByID(1), Is.EqualTo(er));
        }

        [Test]
        public void FindEingangsrechnungTest()
        {
            List<Eingangsrechnung> el = BusinessLogic.Instance.FindEingangsrechnungen("Einnahmen");

            Assert.That(el.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetEingangsrechnungByIDTest()
        {
            Eingangsrechnung er = new Eingangsrechnung();
            er = BusinessLogic.Instance.GetEingangsrechnungByID(1);

            Assert.That(er.ID, Is.EqualTo(1));
        }

        [Test]
        public void GetAllEingangsrechnungenTest()
        {
            List<Eingangsrechnung> el = BusinessLogic.Instance.GetAllEingangsrechnungen();

            Assert.That(el.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetEingangsrechnungByBuchungTest()
        {
            List<Eingangsrechnung> el = BusinessLogic.Instance.GetEingangsrechnungByBuchung(1);

            Assert.That(el.Count, Is.EqualTo(1));
        }

        [Test]
        public void DeleteEingangsrechnungTest()
        {
            Eingangsrechnung er = BusinessLogic.Instance.GetEingangsrechnungByID(2);
            long sum = BusinessLogic.Instance.GetAllEingangsrechnungen().Count;
            BusinessLogic.Instance.DeleteEingangsrechnung(er);

            Assert.IsFalse(BusinessLogic.Instance.GetAllEingangsrechnungen().Contains(er));
            Assert.That(BusinessLogic.Instance.GetAllEingangsrechnungen().Count, Is.EqualTo(sum - 1));
        }
    }
}
