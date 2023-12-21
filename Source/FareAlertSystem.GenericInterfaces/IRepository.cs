using System;
using System.Collections.Generic;

namespace FareAlertSystem.GenericInterfaces
{
    public interface IRepository<TEntity, in TId> where TEntity : IEntity<TId>
    {
        void Add(TEntity entity);
        void Remove(TId id);
        void Update(TEntity entity);

        TEntity Get(TId id);
        IEnumerable<TEntity> GetAll();
    }
}