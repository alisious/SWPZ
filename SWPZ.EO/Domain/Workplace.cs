﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWPZ.Base.DDD.Domain;

namespace SWPZ.EO.Domain
{
    #pragma warning disable 661,660 //Equals and GetHashCode are overridden in ValueObject class.
    public class Workplace : ValueObject
    #pragma warning restore 661,660

    {
        internal Workplace()
        {

        }

        public string CompanyName { get; set; }
        public string JobTittle { get; set; }
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public string PlaceeNo { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }


        #region Infrastructure

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return CompanyName;
            yield return JobTittle;
        }

        public static bool operator ==(Workplace left, Workplace right)
        {
            return EqualOperator(left, right);
        }

        public static bool operator !=(Workplace left, Workplace right)
        {
            return NotEqualOperator(left, right);
        }

        #endregion
    }
}
