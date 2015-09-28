using System.Collections.Generic;
using SWPZ.Base.DDD.Domain;

namespace SWPZ.Base.DDD.Domain.SharedKernel
{
    #pragma warning disable 661,660 //Equals and GetHashCode are overridden in ValueObject class.
    public class Address : ValueObject
    #pragma warning restore 661,660
    {
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public string PlaceNo { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }


        internal Address()
        {

        }

        public Address(string city)
        {
            City = city;
        }

        #region Infrastructure
        

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Street;
            yield return StreetNo;
            yield return PlaceNo;
            yield return PostalCode;

        }

        public static bool operator ==(Address left, Address right)
        {
            return EqualOperator(left, right);
        }

        public static bool operator !=(Address left, Address right)
        {
            return NotEqualOperator(left, right);
        }

        #endregion

    }
}
