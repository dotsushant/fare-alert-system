using System;
using System.Linq;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.Helpers;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.Infrastructure
{
    public class FareAlertService : IFareAlertService
    {
        private IFareAlertRepository _fareAlertRepository;

        public FareAlertService(IFareAlertRepository fareAlertRepository)
        {
            Contract.Requires<ArgumentNullException>(fareAlertRepository != null, InfrastructureResource.InvalidFareAlertRepository);

            _fareAlertRepository = fareAlertRepository;
        }

        public void AddAlert(FareAlert fareAlert)
        {
            Contract.Requires<ArgumentNullException>(fareAlert != null, ModelResource.InvalidFareAlert);

            _fareAlertRepository.Add(fareAlert);
        }

        public IEnumerable<FareAlert> GetAlerts()
        {
            return _fareAlertRepository.GetAll().Where(fareAlert => fareAlert.Frequency.Contains(DateTime.Now.DayOfWeek) && fareAlert.Journey.Onward.Date >= DateTime.Now.Date);
        }

        public void Search(IFareSearchProvider fareSearchProvider, IFareAlertNotificationService fareAlertNotificationService)
        {
            Contract.Requires<ArgumentNullException>(fareSearchProvider != null, InfrastructureResource.InvalidFareSearchProvider);
            Contract.Requires<ArgumentNullException>(fareAlertNotificationService != null, InfrastructureResource.InvalidFareAlertNotificationService);

            fareSearchProvider.Search(GetAlerts(), fareAlertNotificationService);
        }
    }
}