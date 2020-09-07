/*
 * Grading ID: E3780
 * Program: 0
 * Due Date: September 7 2020
 * Course: CIS 200-76
 * Description: Creates a class designed for sending Letters. It is a Parcel.
 */

using System;

namespace shipper_v2
{
    class Letter : Parcel
    {
        // Backing fields
        private decimal _cost; // Cost of shipment

        /*
         * Precondition: cost > $0.00
         * Postcondition: A letter object is created with a base parcel, detailing the origin,
         * destination, and fixed cost for sending the letter.
         */

        public Letter(Address origin, Address destination, decimal cost) : base(origin, destination)
        {
            // Use property to validate cost.
            Cost = cost;
        }

        private decimal Cost
        {
            /*
             * Precondition: None
             * Postcondition: Returns the cost to send the letter.
             */
            get => _cost;
            /*
             * Precondition: value > $0.00
             * Postcondition: Sets the backing field '_cost' to the value provided.
             */
            set
            {
                if (value <= decimal.Zero)
                    throw new ArgumentOutOfRangeException(nameof(Cost), value,
                        $"{nameof(Cost)} must be greater than {decimal.Zero:C}.");

                _cost = value;
            }
        }

        /*
         * Precondition: None
         * Postcondition: Returns the value of the property 'Cost'.
         */
        public override decimal CalcCost() => Cost;
    }
}
