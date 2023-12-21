using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using FareAlertSystem.Models;

namespace FareAlertSystem.Infrastructure
{
    public static class Extensions
    {
        public static CityDTO DTO(this City city)
        {
            return new CityDTO() // User automapper later
            {
                Id = city.Id,
                Name = city.Name
            };
        }

        public static FareAlertDTO DTO(this FareAlert fareAlert)
        {
            return new FareAlertDTO() // User automapper later
            {
                CreatedOn = fareAlert.CreatedOn.Date.ToShortDateString(),
                Source = fareAlert.Journey.Source.Id,
                Destination = fareAlert.Journey.Destination.Id,
                OnwardDate = fareAlert.Journey.Onward.Date.ToShortDateString(),
                ReturnDate = fareAlert.Journey.Return.HasValue ? fareAlert.Journey.Return.Value.Date.ToShortDateString() : string.Empty,
                Passengers = fareAlert.Journey.Passengers.Select(p => p.Age).ToList(),
                Frequency = fareAlert.Frequency
            };
        }
    }
}