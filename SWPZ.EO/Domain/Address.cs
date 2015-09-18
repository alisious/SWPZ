using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPZ.EO.Domain
{
    public class Address
    {
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public string PlaceeNo { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }


        internal Address()
        {

        }
    }
}
