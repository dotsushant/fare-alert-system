using System;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public class FareSearchResult
    {
        public FareSearchResult(Airline airline, Fare fare, Journey journey)
        {
            Contract.Requires<ArgumentNullException>(airline != null, ModelResource.InvalidAirline);
            Contract.Requires<ArgumentNullException>(fare != null, ModelResource.InvalidFare);
            Contract.Requires<ArgumentNullException>(journey != null, ModelResource.InvalidJourneyDetails);

            Airline = airline;
            Fare = fare;
            Journey = journey;
        }

        public Airline Airline
        {
            get;
            private set;
        }

        public Fare Fare
        {
            get;
            private set;
        }

        public Journey Journey
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format(ModelResource.FareSearchResultDescriptionFormat, Airline, Fare, Journey.Source, Journey.Destination);
        }
    }
}