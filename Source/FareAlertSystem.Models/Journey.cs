using System;
using System.Linq;
using System.Collections.Generic;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public class Journey
    {
        public Journey(City source, City destination, DateTime onwardDate, DateTime? returnDate, IEnumerable<Passenger> passengers)
        {
            Contract.Requires<ArgumentNullException>(source != null, ModelResource.InvalidCity);
            Contract.Requires<ArgumentNullException>(destination != null, ModelResource.InvalidCity);
            Contract.Requires<ArgumentException>(!source.Equals(destination), ModelResource.InvalidCityPair);
            Contract.Requires<ArgumentException>(onwardDate.Date >= DateTime.Now.Date, ModelResource.InvalidJourneyDetails);
            Contract.Requires<ArgumentException>(returnDate.HasValue ? returnDate.Value.Date >= onwardDate.Date : true, ModelResource.InvalidJourneyDetails);
            Contract.Requires<ArgumentException>(passengers.All(p => p != null), ModelResource.InvalidPassengerDetails);

            Source = source;
            Destination = destination;

            Onward = onwardDate;
            Return = returnDate;
            Passengers = passengers;
        }

        public City Source
        {
            get;
            private set;
        }

        public City Destination
        {
            get;
            private set;
        }

        public DateTime Onward
        {
            get;
            private set;
        }

        public DateTime? Return
        {
            get;
            private set;
        }

        public IEnumerable<Passenger> Passengers
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format(ModelResource.JourneyDescriptionFormat, Source, Destination, Onward.Date, Return.HasValue ? Return.Value.Date.ToString() : "N/A");
        }
    }
}