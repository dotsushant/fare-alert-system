using System.Web.Http;

using Unity.WebApi;
using Microsoft.Practices.Unity;

using FareAlertSystem.Infrastructure;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<ICityRepository, CityRepository>();
            container.RegisterType<IFareAlertRepository, MockFareAlertRepository>();
            container.RegisterType<IFareAlertService, FareAlertService>();
            container.RegisterType<IFareSearchProvider, MockFareSearchProvider>();
            container.RegisterType<IFareAlertNotificationService, FareAlertEmailNotificationService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}