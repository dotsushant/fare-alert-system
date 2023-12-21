using System;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public class Passenger
    {
        public Passenger(byte age)
        {
            Contract.Requires<ArgumentException>(age > 0, ModelResource.InvalidAge);

            Age = age;
        }

        public byte Age
        {
            get;
            private set;
        }
    }
}