using System;
using System.Collections.Generic;

namespace FareAlertSystem.GenericInterfaces
{
    public interface IService
    {

    }

    public interface INotificationService<T> : IService
    {
        void Send(T notifiable);
        void Send(IEnumerable<T> notifiables);
    }
}