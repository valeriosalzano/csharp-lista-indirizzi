using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_lista_indirizzi
{
    internal class Address
    {
        public string Name {  get; private set; }
        public string Surname { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }   
        public string Province { get; private set; }
        public string ZIP { get; private set; }

        public Address(string name, string surname, string street, string city, string province, string zip) 
        {
            if (name.Trim() == "")
                throw new ArgumentException("field cannot be empty","Name");
            Name = name;

            if (surname.Trim() == "")
                throw new ArgumentException("field cannot be empty", "Surname");
            Surname = surname;

            if (street.Trim() == "")
                throw new ArgumentException("field cannot be empty", "Street");
            Street = street;

            if (city.Trim() == "")
                throw new ArgumentException("field cannot be empty", "City");
            City = city;

            if (province.Trim() == "")
                throw new ArgumentException("field cannot be empty", "Province");
            Province = province;

            if (zip.Trim() == "")
                throw new ArgumentException("field cannot be empty", "ZIP");
            ZIP = zip;
        }
    }
}
