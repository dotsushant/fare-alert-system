using System;

using FareAlertSystem.Models;
using FareAlertSystem.GenericInterfaces;

namespace FareAlertSystem.DomainInterfaces
{
    public interface IFareAlertRepository : IRepository<FareAlert, Guid>
    {
    }
}