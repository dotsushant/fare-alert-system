using System;
using System.Collections.Generic;

namespace FareAlertSystem.Infrastructure
{
    public class CityDTO
    {
        public string Id;
        public string Name;
    }

    public class FareAlertDTO
    {
        public string CreatedOn;
        public string Source;
        public string Destination;
        public string OnwardDate;
        public string ReturnDate;
        public IEnumerable<byte> Passengers;
        public double MinimumFare;
        public double MaximumFare;
        public IEnumerable<DayOfWeek> Frequency;
    }
}