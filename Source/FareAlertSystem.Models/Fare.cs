using System;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public class Fare : IEquatable<Fare>, IComparable<Fare>
    {
        public Fare(double value)
        {
            Contract.Requires<ArgumentException>(value >= 0, ModelResource.InvalidFare);
                        
            Value = value;
        }

        public double Value
        {
            get;
            private set;
        }

        public bool Equals(Fare otherFare)
        {
            Contract.Requires<ArgumentNullException>(otherFare != null, ModelResource.InvalidFare);

            return Value.Equals(otherFare.Value);
        }

        public int CompareTo(Fare otherFare)
        {
            Contract.Requires<ArgumentNullException>(otherFare != null, ModelResource.InvalidFare);

            return Value.CompareTo(otherFare.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}