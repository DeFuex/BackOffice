using Domain;
using BL;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Test
{

    [TestFixture]
    class RechnungszeileTest
    {
        [Test]
        public void AddRechnungszeileTest()
        {
            Rechnungszeile rz = new Rechnungszeile();
            rz.AngebotID = 1;
            rz.AusgangsrechnungID = 1;
            rz.Betrag = 300;
            rz.Bezeichnung = "Testzeile";

            long sum = BusinessLogic.Instance.GetAllRechnungszeilen().Count;
            BusinessLogic.Instance.AddRechnungszeile(rz);
            long index = BusinessLogic.Instance.GetAllRechnungszeilen().Count;
            Assert.That(BusinessLogic.Instance.GetAllRechnungszeilen().Count, Is.EqualTo(sum + 1));
            Assert.IsTrue(BusinessLogic.Instance.GetAllRechnungszeilen().Contains(rz));
        }

        [Test]
        public void UpdateRechnungszeileTest()
        {
            Rechnungszeile rz = BusinessLogic.Instance.GetRechnungszeileByID(2);
            rz.AngebotID = 1;
            rz.AusgangsrechnungID = 1;
            rz.Betrag = 300;
            rz.Bezeichnung = "Testzeile";

            BusinessLogic.Instance.UpdateRechnungszeile(rz);
            Assert.IsTrue(BusinessLogic.Instance.GetAllRechnungszeilen().Contains(rz));
            Assert.That(BusinessLogic.Instance.GetRechnungszeileByID(2), Is.EqualTo(rz));
        }

        [Test]
        public void FindRechnungszeileTest()
        {
            List<Rechnungszeile> rl = BusinessLogic.Instance.FindRechnungszeilen("Testzeile");

            Assert.That(rl.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetRechnungszeileByIDTest()
        {
            Rechnungszeile rz = new Rechnungszeile();
            rz = BusinessLogic.Instance.GetRechnungszeileByID(2);

            Assert.That(rz.ID, Is.EqualTo(2));
        }

        [Test]
        public void GetAllRechnungszeilenTest()
        {
            List<Rechnungszeile> rl = BusinessLogic.Instance.GetAllRechnungszeilen();

            Assert.That(rl.Count, Is.EqualTo(2));
        }

        [Test]
        public void DeleteRechnungszeileTest()
        {
            Rechnungszeile rz = BusinessLogic.Instance.GetRechnungszeileByID(1);
            long sum = BusinessLogic.Instance.GetAllRechnungszeilen().Count;
            BusinessLogic.Instance.DeleteRechnungszeile(rz);

            Assert.IsFalse(BusinessLogic.Instance.GetAllRechnungszeilen().Contains(rz));
            Assert.That(BusinessLogic.Instance.GetAllRechnungszeilen().Count, Is.EqualTo(sum - 1));
        }
    }
}
