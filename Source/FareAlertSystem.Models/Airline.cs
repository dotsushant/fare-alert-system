using System;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public class Airline
    {
        public Airline(string name)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(name), ModelResource.InvalidAirline);

            Name = name;
        }

        public string Name
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}