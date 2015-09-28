using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWPZ.Base.DDD.Domain;

namespace SWPZ.EO.Domain
{
    public class Reservation :PersonRegistration
    {

        internal Reservation(DateTime registrationDate, string registeringOperator, Person registeredPerson)
            : base(registrationDate, registeringOperator, registeredPerson)
        {
            
        }

        public ReservationStatus ReservationStatus { get; private set; }

        public void Cancel(DateTime cancelationDate, string cancelingOperator)
        {
            CancelationDate = cancelationDate;
            CancelingOperator = cancelingOperator;
            ReservationStatus = ReservationStatus.Cancelled;
        }


        public DateTime CancelationDate { get; private set; }

        public string CancelingOperator { get; private set; }
    }
}
