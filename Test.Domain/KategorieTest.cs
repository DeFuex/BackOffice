using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class KategorieTest
    {
        [Test]
        public void AddKategorieTest()
        {
            Kategorie k = new Kategorie();
            k.KategorieTyp = "Testkategorie";

            long sum = BusinessLogic.Instance.GetAllKategorien().Count;
            BusinessLogic.Instance.AddKategorie(k);
            long index = BusinessLogic.Instance.GetAllKategorien().Count;
            Assert.That(BusinessLogic.Instance.GetAllKategorien().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllKategorien().Contains(k));
        }

        [Test]
        public void UpdateKategorieTest()
        {
            Kategorie k = BusinessLogic.Instance.GetKategorieByID(2);
            k.KategorieTyp = "Testkategorie";

            BusinessLogic.Instance.UpdateKategorie(k);
            Assert.IsTrue(BusinessLogic.Instance.GetAllKategorien().Contains(k));
            Assert.That(BusinessLogic.Instance.GetKategorieByID(2), Is.EqualTo(k));
        }

        [Test]
        public void GetKategorieByBuchungTest()
        {
            List<Kategorie> kl = BusinessLogic.Instance.GetKategorieByBuchung(1);

            Assert.That(kl.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetKategorieByIDTest()
        {
            Kategorie k = new Kategorie();
            k = BusinessLogic.Instance.GetKategorieByID(2);

            Assert.That(k.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllKategorienTest()
        {
            List<Kategorie> kl = BusinessLogic.Instance.GetAllKategorien();

            Assert.That(kl.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteKategorieTest()
        {
            Kategorie k = BusinessLogic.Instance.GetKategorieByID(1);
            long sum = BusinessLogic.Instance.GetAllKategorien().Count;
            BusinessLogic.Instance.DeleteKategorie(k);

            Assert.IsFalse(BusinessLogic.Instance.GetAllKategorien().Contains(k));
            Assert.That(BusinessLogic.Instance.GetAllKategorien().Count, Is.EqualTo(sum - 1));
        }
    }
}
