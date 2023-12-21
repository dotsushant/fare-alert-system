using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using FareAlertSystem.Models;
using FareAlertSystem.Infrastructure;
using FareAlertSystem.DomainInterfaces;

namespace FareAlertSystem.WebApi.Controllers
{
    public class CitiesController : ApiController
    {
        private ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [Route("api/cities")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(_cityRepository.GetAll().Select(city => city.DTO()));
        }

        [Route("api/cities/{id}")]
        public HttpResponseMessage Get(string id)
        {
            var matchingCity = _cityRepository.Get(id);
            var responseMessage = default(HttpResponseMessage);

            if (null != matchingCity)
            {
                responseMessage = Request.CreateResponse(HttpStatusCode.OK, matchingCity.DTO());
            }
            else
            {
                responseMessage = Request.CreateResponse(new HttpError(InfrastructureResource.InvalidCityCode));
            }

            return responseMessage;
        }
    }
}