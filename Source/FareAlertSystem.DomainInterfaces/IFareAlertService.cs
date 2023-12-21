using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.GenericInterfaces;

namespace FareAlertSystem.DomainInterfaces
{
    public interface IFareAlertService : IService
    {
        void AddAlert(FareAlert fareAlert);
        IEnumerable<FareAlert> GetAlerts();
        void Search(IFareSearchProvider fareSearchProvider, IFareAlertNotificationService fareAlertNotificationService);
    }

    public interface IFareAlertNotificationService : INotificationService<FareSearchResult>
    {

    }
}