using System;
using System.Linq;
using System.Collections.Generic;

using FareAlertSystem.Models;
using FareAlertSystem.DomainInterfaces;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Infrastructure
{
    public class MockCityRepository : ICityRepository
    {
        private HashSet<City> _cityList = new HashSet<City>();

        public MockCityRepository()
        {
            Add(new City("MAA", "Chennai, India"));
            Add(new City("BOM", "Mumbai, India"));
            Add(new City("BLR", "Bangalore, India"));
        }

        public void Add(City city)
        {
            Contract.Requires<ArgumentNullException>(city != null, ModelResource.InvalidCity);

            _cityList.Add(city);
        }

        public City Get(string cityId)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(cityId), ModelResource.InvalidCityId);

            return _cityList.FirstOrDefault(city => city.Id.Equals(cityId, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<City> GetAll()
        {
            return _cityList;
        }

        public void Remove(string cityId)
        {
            throw new NotImplementedException();
        }

        public void Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}