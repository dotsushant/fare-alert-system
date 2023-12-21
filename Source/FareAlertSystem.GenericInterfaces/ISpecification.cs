using System;
using System.Collections.Generic;

namespace FareAlertSystem.GenericInterfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T subject);
    }
}