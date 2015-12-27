using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class AngebotTest
    {
        [Test]
        public void AddAngebotTest()
        {
            Angebot a = new Angebot();
            a.Chance = 40;
            a.Datum = DateTime.Parse("01-01-2013");
            a.Dauer = 20;
            a.KundenID = 1;
            a.ProjektID = 1;
            a.Summe = 500;

            long sum = BusinessLogic.Instance.GetAllAngebote().Count;
            BusinessLogic.Instance.AddAngebot(a);
            long index = BusinessLogic.Instance.GetAllAngebote().Count;
            Assert.That(BusinessLogic.Instance.GetAllAngebote().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllAngebote().Contains(a));
        }

        [Test]
        public void UpdateAngebotTest()
        {
            Angebot a = BusinessLogic.Instance.GetAngebotByID(2);
            a.Chance = 40;
            a.Datum = DateTime.Parse("01-01-2013");
            a.Dauer = 20;
            a.KundenID = 1;
            a.ProjektID = 1;
            a.Summe = 500;

            BusinessLogic.Instance.UpdateAngebot(a);
            Assert.IsTrue(BusinessLogic.Instance.GetAllAngebote().Contains(a));
            Assert.That(BusinessLogic.Instance.GetAngebotByID(2), Is.EqualTo(a));
        }

        [Test]
        public void FindAngebotTest()
        {
            List<Angebot> al = BusinessLogic.Instance.FindAngebote("500");

            Assert.That(al.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetAngebotByIDTest()
        {
            Angebot a = new Angebot();
            a = BusinessLogic.Instance.GetAngebotByID(2);

            Assert.That(a.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllAngeboteTest()
        {
            List<Angebot> al = BusinessLogic.Instance.GetAllAngebote();

            Assert.That(al.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteAngebotTest()
        {
            Angebot a = BusinessLogic.Instance.GetAngebotByID(1);
            long sum = BusinessLogic.Instance.GetAllAngebote().Count;
            BusinessLogic.Instance.DeleteAngebot(a);

            Assert.IsFalse(BusinessLogic.Instance.GetAllAngebote().Contains(a));
            Assert.That(BusinessLogic.Instance.GetAllAngebote().Count, Is.EqualTo(sum - 1));
        }
    }
}
