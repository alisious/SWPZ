using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWPZ.Base.DDD.Domain;

namespace SWPZ.EO.Domain
{
    public abstract class PersonRegistration :AggregateRoot
    {
        public DateTime RegistrationDate { get; private set; }
        public string RegisteringOperator { get; private set; }
        public Person RegisteredPerson { get; private set; }
        public string Notes { get; set; }

        protected PersonRegistration(DateTime registrationDate, string registeringOperator, Person registeredPerson)
        {
            RegistrationDate = registrationDate;
            RegisteringOperator = registeringOperator;
            RegisteredPerson = registeredPerson;
        }

    }
}
