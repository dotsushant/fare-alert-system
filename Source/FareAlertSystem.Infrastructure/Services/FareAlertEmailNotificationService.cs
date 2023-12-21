using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.Helpers;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.Infrastructure
{
    public class FareAlertEmailNotificationService : IFareAlertNotificationService
    {
        public void Send(FareSearchResult fareSearchResult)
        {
            Send(Enumerable.Repeat(fareSearchResult, 1));
        }

        public void Send(IEnumerable<FareSearchResult> fareSearchResults)
        {
            Contract.Requires<ArgumentNullException>(fareSearchResults.All(fareSearchResult => fareSearchResult != null), ModelResource.InvalidFareSearchResult);

            foreach (var fareSearchResult in fareSearchResults)
            {
                Console.WriteLine(fareSearchResult);
            }
        }
    }
}