/*
 * Grading ID: E3780
 * Program: 0
 * Due Date: September 7 2020
 * Course: CIS 200-76
 * Description: Creates an abstract class for a Parcel. Each delivery type is a parcel.
 */

using System;

namespace shipper_v2
{
    abstract class Parcel
    {
        // Backing fields
        private Address _origin, // Origin address
            _destination;        // Destination address

        /*
         * Preconditions: 'origin' and 'destination' are not null.
         * Postcondition: A Parcel object is created.
         */
        public Parcel(Address origin, Address destination)
        {
            OriginAddress = origin;
            DestinationAddress = destination;
        }

        public Address OriginAddress
        {
            /*
             * Preconditions: None
             * Postcondition: Returns the value of the '_origin' backing field.
             */
            get => _origin;
            /*
             * Preconditions: The value is not null.
             * Postcondition: Sets the backing field '_origin' to the value provided.
             */
            set => _origin = value ?? throw new ArgumentOutOfRangeException(nameof(OriginAddress), value, $"{nameof(OriginAddress)} must not be null.");
        }

        public Address DestinationAddress
        {
            /*
             * Preconditions: None
             * Postcondition: Returns the value of the '_destination' backing field.
             */
            get => _destination;
            /*
             * Preconditions: The value is not null.
             * Postcondition: Sets the backing field '_destination' to the value provided.
             */
            set => _destination = value ?? throw new ArgumentOutOfRangeException(nameof(DestinationAddress), value, $"{nameof(DestinationAddress)} must not be null.");
        }

        /*
         * Preconditions: None
         * Postcondition: Varies based on implementation
         */
        public abstract decimal CalcCost();

        /*
         * Preconditions: None
         * Postcondition: Returns the formatted test containing the origin,
         * destination, and cost for deliver the Parcel.
         */
        public override string ToString()
        {
            string NL = Environment.NewLine;
            return $"ORIGIN: {NL}{OriginAddress}{NL}" +
                $"{NL}DESTINATION:{NL}{DestinationAddress}{NL}" +
                $"{NL}COST: {CalcCost():C}";
        }
    }
}
