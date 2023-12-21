using System;
using System.Linq;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.Helpers;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.Infrastructure
{
    public class MockFareAlertRepository : IFareAlertRepository
    {
        private List<FareAlert> _alerts = new List<FareAlert>();

        public MockFareAlertRepository(ICityRepository cityRepository)
        {
            var passenger = new Passenger(36);
            var fareConstraint = new FareBound(new Fare(1000), new Fare(4000), FareBoundType.Inclusive, FareBoundType.Inclusive);
            var journey = new Journey(cityRepository.Get("BLR"), cityRepository.Get("MAA"), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), new List<Passenger>() { passenger });

            var fareAlert = new FareAlert(journey, fareConstraint, "SMTWT__".ToDaysOfWeek());
            Add(fareAlert);
        }

        public void Add(FareAlert fareAlert)
        {
            Contract.Requires<ArgumentNullException>(fareAlert != null, ModelResource.InvalidFareAlert);

            _alerts.Add(fareAlert);
        }

        public FareAlert Get(Guid fareAlertId)
        {
            return _alerts.Find(alert => alert.Id.Equals(fareAlertId));
        }

        public IEnumerable<FareAlert> GetAll()
        {
            return _alerts;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(FareAlert entity)
        {
            throw new NotImplementedException();
        }
    }
}