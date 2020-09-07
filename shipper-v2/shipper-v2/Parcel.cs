using System;

namespace shipper_v2
{
    abstract class Parcel
    {
        private Address _origin, // Origin address
            _destination;        // Destination address

        public Parcel(Address origin, Address destination)
        {
            OriginAddress = origin;
            DestinationAddress = destination;
        }

        public Address OriginAddress
        {
            get => _origin;
            set => _origin = value ?? throw new ArgumentOutOfRangeException(nameof(OriginAddress), value, $"{nameof(OriginAddress)} must not be null.");
        }

        public Address DestinationAddress
        {
            get => _destination;
            set => _destination = value ?? throw new ArgumentOutOfRangeException(nameof(DestinationAddress), value, $"{nameof(DestinationAddress)} must not be null.");
        }

        public abstract decimal CalcCost();

        public override string ToString()
        {
            string NL = Environment.NewLine;
            return $"ORIGIN: {NL}{OriginAddress}{NL}" +
                $"{NL}DESTINATION:{NL}{DestinationAddress}{NL}" +
                $"{NL}COST: {CalcCost():C}";
        }
    }
}
