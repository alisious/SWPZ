using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWPZ.EO.Domain
{
    public class Workplace
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

    }
}
