using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWPZ.Base.DDD.Domain.Annotations;

namespace SWPZ.EO.Domain
{
    [DomainFactory]
    public class ReservationFactory
    {
        public static Reservation CreateReservation(string registeringOperator, Person person)
        {
            return new Reservation(DateTime.Today,registeringOperator,person);
        }
    }
}
