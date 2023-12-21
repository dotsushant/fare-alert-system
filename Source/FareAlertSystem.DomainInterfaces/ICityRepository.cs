using FareAlertSystem.Models;
using FareAlertSystem.GenericInterfaces;

namespace FareAlertSystem.DomainInterfaces
{
    public interface ICityRepository : IRepository<City, string>
    {
    }
}