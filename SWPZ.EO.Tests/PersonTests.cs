using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWPZ.EO.Domain;

namespace SWPZ.EO.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void można_utworzyć_obiekt_Person()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "NOWA 10", "WARSZAWA", "01-163");

            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void nowa_osoba_musi_mieć_przynajmniej_1_adres()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK","NOWA 10","WARSZAWA","01-163");

            Assert.IsNotNull(p);
            Assert.AreEqual(1,p.Addresses.Count);
            
        }

        [TestMethod]
        public void osoba_może_mieć_kilka_adresów()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "NOWA 10", "WARSZAWA", "01-163");
            p.AddAddress("KRAKÓW","JAGIEŁŁY 20","03-123");
            Assert.IsNotNull(p);
            Assert.AreEqual(2, p.Addresses.Count);
            
        }

        [TestMethod]
        public void wybrany_adres_można_usunąć()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "NOWA 10", "WARSZAWA", "01-163");
            p.AddAddress("KRAKÓW", "JAGIEŁŁY 20", "03-123");
            Assert.IsNotNull(p);
            Assert.AreEqual(2, p.Addresses.Count);

            var a = p.Addresses[0];
            p.RemoveAddress(a);

            Assert.AreEqual(1,p.Addresses.Count);

        }

        [TestMethod]
        public void osobie_można_przypisać_miejsca_pracy()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "NOWA 10", "WARSZAWA", "01-163");
            p.AddWorkplace("KGŻW","SPECJALISTA");
            p.AddWorkplace("KGŻW", "SZEF WYDZIAŁU");
            Assert.IsNotNull(p);
            Assert.AreEqual(2, p.Workplaces.Count);

        }

        [TestMethod]
        public void można_usunąć_wybrane_miejsce_pracy()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "NOWA 10", "WARSZAWA", "01-163");
            p.AddWorkplace("KGŻW", "SPECJALISTA");
            p.AddWorkplace("KGŻW", "SZEF WYDZIAŁU");
            Assert.IsNotNull(p);
            Assert.AreEqual(2, p.Workplaces.Count);

            var w = p.Workplaces[0];
            p.RemoveWorkplace(w);
            Assert.AreEqual(1, p.Workplaces.Count);


        }

    }
}
