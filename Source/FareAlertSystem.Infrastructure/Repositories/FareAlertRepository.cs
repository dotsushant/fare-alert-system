using System;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.Infrastructure
{
    public class FareAlertRepository : IFareAlertRepository
    {
        public void Add(FareAlert entity)
        {
            throw new NotImplementedException();
        }

        public FareAlert Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FareAlert> GetAll()
        {
            throw new NotImplementedException();
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