using System;

using FareAlertSystem.Helpers;
using FareAlertSystem.GenericInterfaces;

namespace FareAlertSystem.Models
{
    public class City : IEntity<string>, IEquatable<City>, IComparable<City>
    {
        public City(string id, string name)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(id), ModelResource.InvalidCityId);
            Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(name), ModelResource.InvalidCityName);

            Id = id;
            Name = name;
        }

        public string Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public int CompareTo(City otherCity)
        {
            Contract.Requires<ArgumentNullException>(otherCity != null, ModelResource.InvalidCity);

            return Id.CompareTo(otherCity.Id);
        }

        public bool Equals(City otherCity)
        {
            return 0 == this.CompareTo(otherCity);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(ModelResource.CityDescriptionFormat, Id, Name);
        }
    }
}