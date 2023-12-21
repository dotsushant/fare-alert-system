using System;

using FareAlertSystem.Helpers;

namespace FareAlertSystem.Models
{
    public enum FareBoundType { Inclusive, Exclusive }

    public class FareBound
    {
        public FareBound(Fare minimumFare, Fare maximumFare, FareBoundType minimumFareBoundType, FareBoundType maximumFareBoundType)
        {
            Contract.Requires<ArgumentNullException>(minimumFare != null, ModelResource.InvalidFare);
            Contract.Requires<ArgumentNullException>(maximumFare != null, ModelResource.InvalidFare);

            MinimumFare = minimumFare;
            MaximumFare = maximumFare;
            MinimumFareBoundType = minimumFareBoundType;
            MaximumFareBoundType = maximumFareBoundType;
        }

        public Fare MinimumFare
        {
            get;
            private set;
        }

        public Fare MaximumFare
        {
            get;
            private set;
        }

        public FareBoundType MinimumFareBoundType
        {
            get;
            private set;
        }

        public FareBoundType MaximumFareBoundType
        {
            get;
            private set;
        }

        public bool Contains(Fare fare)
        {
            Contract.Requires<ArgumentNullException>(fare != null, ModelResource.InvalidFare);

            var lower = MinimumFareBoundType == FareBoundType.Exclusive ? MinimumFare.CompareTo(fare) < 0 : MinimumFare.CompareTo(fare) <= 0;
            var upper = MaximumFareBoundType == FareBoundType.Exclusive ? MaximumFare.CompareTo(fare) > 0 : MaximumFare.CompareTo(fare) >= 0;
            return lower && upper;
        }

        public override string ToString()
        {
            return string.Format(ModelResource.FareBoundDescriptionFormat, MinimumFare, MaximumFare, MinimumFareBoundType, MaximumFareBoundType);
        }
    }
}