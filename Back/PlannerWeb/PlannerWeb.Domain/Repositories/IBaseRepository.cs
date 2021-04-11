using System;
using System.Collections.Generic;

namespace PlannerWeb.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        void Create(T Object);
        void Update(T Object);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}