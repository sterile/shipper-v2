using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace shipper_v2
{
    class Address
    {
        private string _name, // Name of receiver
            _addressLine1,    // First line of address
            _addressLine2,    // Second line of address (optional)
            _city,            // Address city
            _state;           // Address state
        private int _zip;     // Address ZIP code

        private const int MIN_ZIP = 0, // Lowest possible ZIP code
            MAX_ZIP = 99999;           // Highest possible ZIP code

        public Address(string name, string adr1, string adr2, string city, string state, int zip)
        {
            Name = name;
            Address1 = adr1;
            Address2 = adr2;
            City = city;
            State = state;
            Zip = zip;
        }

        public Address(string name, string adr1, string city, string state, int zip)
        {
            Name = name;
            Address1 = adr1;
            City = city;
            State = state;
            Zip = zip;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Name", "Name is a required field.");
                else
                    _name = value;
            }
        }
        public string Address1
        {
            get => _addressLine1;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Address line 1", "Address line 1 is a required field.");
                else
                    _addressLine1 = value;
            }
        }

        public string Address2
        {
            get => _addressLine2;
            set => _addressLine2 = value;
        }

        public string City
        {
            get => _city;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("City", "City is a required field.");
                else
                    _city = value;
            }
        }

        public string State
        {
            get => _state;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("State", "State is a required field.");
                else
                    _state = value;
            }
        }

        public int Zip
        {
            get => _zip;
            set
            {
                if (MIN_ZIP > value || MAX_ZIP < value)
                    throw new ArgumentOutOfRangeException("Zip code", $"Zip code must be between {MIN_ZIP:D5} and {MAX_ZIP:D5}.");
                else
                    _zip = value;
            }
        }

        public override string ToString()
        {
            string address;

            if (String.IsNullOrWhiteSpace(Address2))
                address = $"{Address1}{Environment.NewLine}";
            else
                address = $"{Address1}{Environment.NewLine}" +
                    $"{Address2}{Environment.NewLine}";

            return $"{Name}{Environment.NewLine}{address}" +
                $"{City}, {State} {Zip}";
        }
    }
}
