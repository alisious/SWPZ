using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPZ.EO.Domain
{
    public enum Sex
    {
        M,
        K
    };

    
    public class Person
    {

        private readonly IList<Address> _addresses;
        private readonly IList<Workplace> _workplaces;
        private readonly IList<Citizenship> _citizenships; 


        public Guid Id { get; protected set; }
        public string PESEL { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public Sex Sex { get; set; }

        public IReadOnlyList<Address> Addresses
        {
            get { return new ReadOnlyCollection<Address>(_addresses); }
        }

        public IReadOnlyList<Workplace> Workplaces
        {
            get { return new ReadOnlyCollection<Workplace>(_workplaces); }
        }

        public IReadOnlyList<Citizenship> Citizenships
        {
            get { return new ReadOnlyCollection<Citizenship>(_citizenships); }
        }

        private Person()
        {
            _addresses = new List<Address>();
            _workplaces = new List<Workplace>();
            _citizenships = new List<Citizenship>();
        }

        internal Person(string pesel, string firstName, string lastName,string city,string street,string postalCode) 
            :this()
        {
            PESEL = pesel;
            FirstName = firstName;
            LastName = lastName;
            AddAddress(city,street,postalCode);
        }

        public void AddAddress(string city,string street,string postalCode)
        {
            var address = new Address() {City = city, Street = street, PostalCode = postalCode};
            _addresses.Add(address);
        }

        public void RemoveAddress(Address address)
        {
            _addresses.Remove(address);
        }


        public void AddWorkplace(string companyName,string jobTittle)
        {
            var workplace = new Workplace() {CompanyName = companyName,JobTittle = jobTittle};
            _workplaces.Add(workplace);
        }

        public void RemoveWorkplace(Workplace workplace)
        {
            _workplaces.Remove(workplace);
        }

        public void AddCitizenship(Citizenship citizenship)
        {
           if(!_citizenships.Contains(citizenship))
            _citizenships.Add(citizenship);
        }
    } 
    
}
