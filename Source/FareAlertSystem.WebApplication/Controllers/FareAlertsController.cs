using System;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

using FareAlertSystem.Models;
using FareAlertSystem.Infrastructure;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.WebApi.Controllers
{
    public class FareAlertsController : ApiController
    {
        private IFareAlertService _fareAlertService;

        public FareAlertsController(IFareAlertService fareAlertService)
        {
            _fareAlertService = fareAlertService;
        }

        [Route("api/farealerts")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(_fareAlertService.GetAlerts().Select(fareAlert => fareAlert.DTO()));
        }

        [Route("api/farealerts")]
        public void Post([FromBody]FareAlertDTO fareAlertDTO)
        {
        }
    }
}