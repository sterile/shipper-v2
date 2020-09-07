/*
 * Grading ID: E3780
 * Program: 0
 * Due Date: September 7 2020
 * Course: CIS 200-76
 * Description: Creates a class to store an Address. Includes data validation.
 */

using System;

namespace shipper_v2
{
    class Address
    {
        // Backing fields
        private string _name, // Name of receiver
            _addressLine1,    // First line of address
            _addressLine2,    // Second line of address (optional)
            _city,            // Address city
            _state;           // Address state
        private int _zip;     // Address ZIP code

        // Validation fields
        private const int MIN_ZIP = 0, // Lowest possible ZIP code
            MAX_ZIP = 99999;           // Highest possible ZIP code

        /*
         * Preconditions: 'name', 'adr1', 'adr2', 'city', 'state', 'zip' must not be null or whitespace.
         * Postcondition: The address object is created using the values provided.
         */
        public Address(string name, string adr1, string adr2, string city, string state, int zip)
        {
            // Validate address details using properties
            Name = name;
            Address1 = adr1;
            Address2 = adr2;
            City = city;
            State = state;
            Zip = zip;
        }

        /*
         * Preconditions: 'name', 'adr1', 'city', 'state', 'zip' must not be null or whitespace.
         * Postcondition: The address object is created using the values provided.
         */
        public Address(string name, string adr1, string city, string state, int zip)
        {
            // Validate address details using properties
            Name = name;
            Address1 = adr1;
            Address2 = "";
            City = city;
            State = state;
            Zip = zip;
        }

        public string Name
        {
            /*
             * Preconditions: None
             * Postcondition: Backing field '_name' is returned.
             */
            get => _name;
            /*
             * Preconditions: The value is not null or whitespace.
             * Postcondition: Sets the backing field '_name' to the value provided.
             */
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(Name), value, $"{nameof(Name)} is a required field.");
                
                _name = value.Trim();
            }
        }
        public string Address1
        {
            /*
             * Preconditions: None
             * Postcondition: Backing field '_addressLine1' is returned.
             */
            get => _addressLine1;
            /*
             * Preconditions: The value is not null or whitespace.
             * Postcondition: Sets the backing field '_addressLine1' to the value provided.
             */
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(Address1), value, $"{nameof(Address1)} is a required field.");
                
                _addressLine1 = value.Trim();
            }
        }

        public string Address2
        {
            /*
             * Preconditions: None
             * Postcondition: Backing field '_addressLine2' is returned.
             */
            get => _addressLine2;
            /*
             * Preconditions: None
             * Postcondition: Sets the backing field '_addressLine2' to the value provided,
             * or "" if the value is null. (The address does not contain a second line.)
             */
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
            /*
             * Preconditions: None
             * Postcondition: Backing field '_city' is returned.
             */
            get => _city;
            /*
             * Preconditions: The value is not null or whitespace.
             * Postcondition: Sets the backing field '_city' to the value provided.
             */
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(City), value, $"{nameof(City)} is a required field.");
                
                _city = value.Trim();
            }
        }

        public string State
        {
            /*
             * Preconditions: None
             * Postcondition: Backing field '_state' is returned.
             */
            get => _state;
            /*
             * Preconditions: The value is not null or whitespace.
             * Postcondition: Sets the backing field '_state' to the value provided.
             */
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(State), value, $"{nameof(State)} is a required field.");
                
                _state = value.Trim();
            }
        }

        public int Zip
        {
            /*
             * Preconditions: None
             * Postcondition: Backing field '_zip' is returned.
             */
            get => _zip;
            /*
             * Preconditions: The value is between 0 (MIN_ZIP) and 99999 (MAX_ZIP).
             * Postcondition: Sets the backing field '_state' to the value provided.
             */
            set
            {
                if (MIN_ZIP > value || MAX_ZIP < value)
                    throw new ArgumentOutOfRangeException(nameof(Zip), value, $"{nameof(Zip)} must be between {MIN_ZIP:D5} and {MAX_ZIP:D5}.");
                
                _zip = value;
            }
        }

        /*
         * Preconditions: None
         * Postcondition: Returns the formatted address
         */
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
