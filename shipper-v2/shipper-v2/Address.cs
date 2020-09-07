using System;

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
            Address2 = "";
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
                    throw new ArgumentOutOfRangeException(nameof(Name), value, $"{nameof(Name)} is a required field.");
                
                _name = value.Trim();
            }
        }
        public string Address1
        {
            get => _addressLine1;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(Address1), value, $"{nameof(Address1)} is a required field.");
                
                _addressLine1 = value.Trim();
            }
        }

        public string Address2
        {
            get => _addressLine2;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    _addressLine2 = "";
                else
                    _addressLine2 = value.Trim();
            }
        }

        public string City
        {
            get => _city;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(City), value, $"{nameof(City)} is a required field.");
                
                _city = value.Trim();
            }
        }

        public string State
        {
            get => _state;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(State), value, $"{nameof(State)} is a required field.");
                
                _state = value.Trim();
            }
        }

        public int Zip
        {
            get => _zip;
            set
            {
                if (MIN_ZIP > value || MAX_ZIP < value)
                    throw new ArgumentOutOfRangeException(nameof(Zip), value, $"{nameof(Zip)} must be between {MIN_ZIP:D5} and {MAX_ZIP:D5}.");
                
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
                $"{City}, {State} {Zip:D5}";
        }
    }
}
