using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class KontaktTest
    {
        [Test]
        public void AddKontaktTest()
        {
            Kontakt k = new Kontakt();
            k.Adresse = "Teststraße 123";
            k.Bemerkungen = "Bemerkung";
            k.Email = "test@tester.at";
            k.Nachname = "Muster";
            k.Ort = "Wien";
            k.Plz = 1170;
            k.Telefon = "062394873";
            k.Vorname = "Hans";
            k.Firmenname = "Musterfirma";

            long sum = BusinessLogic.Instance.GetAllKontakte().Count;
            BusinessLogic.Instance.AddKontakt(k);
            long index = BusinessLogic.Instance.GetAllKontakte().Count;
            Assert.That(BusinessLogic.Instance.GetAllKontakte().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllKontakte().Contains(k));
        }

        [Test]
        public void UpdateKontaktTest()
        {
            Kontakt k = BusinessLogic.Instance.GetKontaktByID(2);
            k.Adresse = "Teststraße 123";
            k.Bemerkungen = "Bemerkung";
            k.Email = "test@tester.at";
            k.Nachname = "Muster";
            k.Ort = "Wien";
            k.Plz = 1170;
            k.Telefon = "062394873";
            k.Vorname = "Hans";
            k.Firmenname = "Musterfirma";

            BusinessLogic.Instance.UpdateKontakt(k);
            Assert.IsTrue(BusinessLogic.Instance.GetAllKontakte().Contains(k));
            Assert.That(BusinessLogic.Instance.GetKontaktByID(2), Is.EqualTo(k));
        }

        [Test]
        public void FindKontaktTest()
        {
            List<Kontakt> kl = BusinessLogic.Instance.FindKontakte("Hans");

            Assert.That(kl.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetKontaktByIDTest()
        {
            Kontakt k = new Kontakt();
            k = BusinessLogic.Instance.GetKontaktByID(2);

            Assert.That(k.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllKontakteTest()
        {
            List<Kontakt> kl = BusinessLogic.Instance.GetAllKontakte();

            Assert.That(kl.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteKontaktTest()
        {
            Kontakt k = BusinessLogic.Instance.GetKontaktByID(1);
            long sum = BusinessLogic.Instance.GetAllKontakte().Count;
            BusinessLogic.Instance.DeleteKontakt(k);

            Assert.IsFalse(BusinessLogic.Instance.GetAllKontakte().Contains(k));
            Assert.That(BusinessLogic.Instance.GetAllKontakte().Count, Is.EqualTo(sum - 1));
        }
    }
}
