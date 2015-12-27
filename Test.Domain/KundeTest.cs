using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class KundeTest
    {
        [Test]
        public void AddKundeTest()
        {
            Kunde k = new Kunde();
            k.Adresse = "Teststraße 123";
            k.Bemerkungen = "Bemerkung";
            k.Email = "test@tester.at";
            k.Nachname = "Muster";
            k.Ort = "Wien";
            k.Plz = 1170;
            k.Telefon = "062394873";
            k.Vorname = "Hans";

            long sum = BusinessLogic.Instance.GetAllKunden().Count;
            BusinessLogic.Instance.AddKunde(k);
            long index = BusinessLogic.Instance.GetAllKunden().Count;
            Assert.That(BusinessLogic.Instance.GetAllKunden().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllKunden().Contains(k));
        }

        [Test]
        public void UpdateKundeTest()
        {
            Kunde k = BusinessLogic.Instance.GetKundeByID(2);
            k.Adresse = "Teststraße 123";
            k.Bemerkungen = "Bemerkung";
            k.Email = "test@tester.at";
            k.Nachname = "Muster";
            k.Ort = "Wien";
            k.Plz = 1170;
            k.Telefon = "062394873";
            k.Vorname = "Hans";

            BusinessLogic.Instance.UpdateKunde(k);
            Assert.IsTrue(BusinessLogic.Instance.GetAllKunden().Contains(k));
            Assert.That(BusinessLogic.Instance.GetKundeByID(2), Is.EqualTo(k));
        }

        [Test]
        public void FindKundeTest()
        {
            List<Kunde> kl = BusinessLogic.Instance.FindKunden("Marie");

            Assert.That(kl.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetKundeByIDTest()
        {
            Kunde k = new Kunde();
            k = BusinessLogic.Instance.GetKundeByID(2);

            Assert.That(k.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllKundenTest()
        {
            List<Kunde> kl = BusinessLogic.Instance.GetAllKunden();

            Assert.That(kl.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteKundeTest()
        {
            Kunde k = BusinessLogic.Instance.GetKundeByID(1);
            long sum = BusinessLogic.Instance.GetAllKunden().Count;
            BusinessLogic.Instance.DeleteKunde(k);

            Assert.IsFalse(BusinessLogic.Instance.GetAllKunden().Contains(k));
            Assert.That(BusinessLogic.Instance.GetAllKunden().Count, Is.EqualTo(sum - 1));
        }
    }
}
