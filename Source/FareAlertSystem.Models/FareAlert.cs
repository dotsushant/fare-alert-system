using System;
using System.Linq;
using System.Collections.Generic;

using FareAlertSystem.Helpers;
using FareAlertSystem.GenericInterfaces;

namespace FareAlertSystem.Models
{
    public class FareAlert : IEntity<Guid>
    {
        public FareAlert(Journey journey, FareBound constraint, IEnumerable<DayOfWeek> frequency)
        {
            Contract.Requires<ArgumentNullException>(journey != null, ModelResource.InvalidJourneyDetails);
            Contract.Requires<ArgumentNullException>(constraint != null, ModelResource.InvalidFareConstraint);
            Contract.Requires<ArgumentNullException>(frequency != null, ModelResource.InvalidFareAlertFrequency);

            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;

            Journey = journey;
            Constraint = constraint;
            Frequency = frequency;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public DateTime CreatedOn
        {
            get;
            private set;
        }

        public Journey Journey
        {
            get;
            private set;
        }

        public FareBound Constraint
        {
            get;
            private set;
        }

        public IEnumerable<DayOfWeek> Frequency
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format(ModelResource.FareAlertDescriptionFormat, Id, Journey);
        }
    }
}