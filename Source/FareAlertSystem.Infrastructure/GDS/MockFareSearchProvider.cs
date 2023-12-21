using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.Helpers;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.Infrastructure
{
    public class MockFareSearchProvider : IFareSearchProvider
    {
        public void Search(IEnumerable<FareAlert> fareAlerts, IFareAlertNotificationService fareAlertNotificationService)
        {
            Contract.Requires<ArgumentNullException>(fareAlerts != null, ModelResource.InvalidFareAlert);
            Contract.Requires<ArgumentNullException>(fareAlerts.All( fa => fa != null), ModelResource.InvalidFareAlert);
            Contract.Requires<ArgumentNullException>(fareAlertNotificationService != null, InfrastructureResource.InvalidFareAlertNotificationService);

            fareAlertNotificationService.Send(new List<FareSearchResult>());
        }
    }
}