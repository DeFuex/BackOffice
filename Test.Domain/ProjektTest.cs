using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class ProjektTest
    {
        [Test]
        public void AddProjektTest()
        {
            Projekt p = new Projekt();
            p.Gesamtzeit = 30;
            p.Name = "Testprojekt";

            long sum = BusinessLogic.Instance.GetAllProjekte().Count;
            BusinessLogic.Instance.AddProjekt(p);
            long index = BusinessLogic.Instance.GetAllProjekte().Count;
            Assert.That(BusinessLogic.Instance.GetAllProjekte().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllProjekte().Contains(p));
        }

        [Test]
        public void UpdateProjektTest()
        {
            Projekt p = BusinessLogic.Instance.GetProjektByID(2);
            p.Gesamtzeit = 30;
            p.Name = "Testprojekt";

            BusinessLogic.Instance.UpdateProjekt(p);
            Assert.IsTrue(BusinessLogic.Instance.GetAllProjekte().Contains(p));
            Assert.That(BusinessLogic.Instance.GetProjektByID(2), Is.EqualTo(p));
        }

        [Test]
        public void FindProjektTest()
        {
            List<Projekt> pl = BusinessLogic.Instance.FindProjekte("Timo");

            Assert.That(pl.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetProjektByIDTest()
        {
            Projekt p = new Projekt();
            p = BusinessLogic.Instance.GetProjektByID(2);

            Assert.That(p.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllProjekteTest()
        {
            List<Projekt> pl = BusinessLogic.Instance.GetAllProjekte();

            Assert.That(pl.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteProjektTest()
        {
            Projekt p = BusinessLogic.Instance.GetProjektByID(1);
            long sum = BusinessLogic.Instance.GetAllProjekte().Count;
            BusinessLogic.Instance.DeleteProjekt(p);

            Assert.IsFalse(BusinessLogic.Instance.GetAllProjekte().Contains(p));
            Assert.That(BusinessLogic.Instance.GetAllProjekte().Count, Is.EqualTo(sum - 1));
        }
    }
}
