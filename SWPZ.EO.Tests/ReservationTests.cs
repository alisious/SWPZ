using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWPZ.EO.Domain;

namespace SWPZ.EO.Tests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void można_utworzyć_nową_rezerwację()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "", "WARSZAWA", "");
            var r = ReservationFactory.CreateReservation("Jacek",p);

            Assert.IsNotNull(r);
            Assert.AreEqual(ReservationStatus.Active, r.ReservationStatus);
        }

        [TestMethod]
        public void rezerwacja_dotyczy_konkretnej_osoby()
        {
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "", "WARSZAWA", "");
            var r = ReservationFactory.CreateReservation("Jacek",p);

            Assert.IsNotNull(r);
            Assert.IsNotNull(r.RegisteredPerson);
            Assert.AreEqual(ReservationStatus.Active, r.ReservationStatus);
            
        }


        [TestMethod]
        public void można_odwołać_tylko_aktywną_rezerwację()
        {
          
            var p = PersonFactory.CreatePerson("73020916558", "JACEK", "KORPUSIK", "", "WARSZAWA", "");
            var r = ReservationFactory.CreateReservation("Jacek", p);
            r.Cancel(DateTime.Today,"Jacek");

            Assert.IsNotNull(r);
            Assert.IsNotNull(r.RegisteredPerson);
            Assert.AreEqual(ReservationStatus.Cancelled,r.ReservationStatus);
            
        }



    }

   
}
