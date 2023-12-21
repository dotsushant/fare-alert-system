using System;

namespace FareAlertSystem.GenericInterfaces
{
    public interface IEntity<TId>
    {
        TId Id
        {
            get;
        }
    }
}