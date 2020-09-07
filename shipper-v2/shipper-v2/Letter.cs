using System;
using System.Collections.Generic;
using System.Text;

namespace shipper_v2
{
    class Letter : Parcel
    {
        private decimal cost; // Cost of shipment

        public Letter(Address origin, Address destination, decimal cost) : base(origin, destination)
        {
            Cost = cost;
        }

        private decimal Cost
        {
            get => cost;
            set
            {
                if (value <= decimal.Zero)
                    throw new ArgumentOutOfRangeException(nameof(Cost), value,
                        $"{nameof(Cost)} must be greater than {decimal.Zero:C}.");

                cost = value;
            }
        }
        public override decimal CalcCost() => Cost;

        public override string ToString() => base.ToString() +
            $"{Environment.NewLine}{Environment.NewLine}COST: {CalcCost():C}";
    }
}
