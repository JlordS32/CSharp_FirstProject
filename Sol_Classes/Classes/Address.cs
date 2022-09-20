using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Address
    {
        private string _streetUnitNumber;
        private string _streetName;
        private string _suburb;
        private string _state;
        private string _postcode;
        public string StreetUnitNumber
        {
            get => _streetUnitNumber;
            set => _streetUnitNumber = value;
        }

        public string StreetName
        {
            get => _streetName;
            set => _streetName = value;
        }

        public string Suburb
        {
            get => _suburb;
            set => _suburb = value;
        }

        public string State
        {
            get => _state;
            set => _state = value;
        }

        public string PostCode
        {
            get => _postcode;
            set => _postcode = value;
        }

        public Address(string streetUnitNumber, string streetName, string suburb, string state, string postcode)
        {
            StreetUnitNumber = streetUnitNumber;
            StreetName = streetName;
            Suburb = suburb;
            State = state;
            PostCode = postcode;
        }

        public void GetAddress()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", StreetUnitNumber, StreetName, Suburb, State, PostCode);
        }

    }
}
