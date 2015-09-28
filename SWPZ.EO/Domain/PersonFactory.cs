using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWPZ.Base.DDD.Domain.Annotations;

namespace SWPZ.EO.Domain
{
   
    [DomainFactory]
    public class PersonFactory
    {
        public static Person CreatePerson(string pesel,string firstName,string lastName,string street,string city,string postalCode)
        {
            return new Person(pesel,firstName,lastName,street,city,postalCode);
        }
    }
}
