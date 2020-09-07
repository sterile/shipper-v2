using System;

namespace shipper_v2
{
    class Letter : Parcel
    {
        private decimal _cost; // Cost of shipment

        public Letter(Address origin, Address destination, decimal cost) : base(origin, destination)
        {
            Cost = cost;
        }

        private decimal Cost
        {
            get => _cost;
            set
            {
                if (value <= decimal.Zero)
                    throw new ArgumentOutOfRangeException(nameof(Cost), value,
                        $"{nameof(Cost)} must be greater than {decimal.Zero:C}.");

                _cost = value;
            }
        }
        public override decimal CalcCost() => Cost;
    }
}
