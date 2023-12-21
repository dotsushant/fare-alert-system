using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.DomainInterfaces
{
    public interface IFareSearchProvider
    {
        void Search(IEnumerable<FareAlert> fareAlerts, IFareAlertNotificationService fareAlertNotificationService);
    }
}