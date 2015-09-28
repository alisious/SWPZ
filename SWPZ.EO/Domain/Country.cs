using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWPZ.EO.Domain
{
    public class Country
    {
        public string ShortName { get; private set; }
        public string Name { get; private set; }

        private Country()
        {

        }

        public Country(string shortName, string name)
        {
            ShortName = shortName;
            Name = name;
        }
    }
}
