using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Repository
{
    public interface IRepository<T>
    {
        Guid Add(T entity);
        void Update(T entity);
        void Delete(Guid entityId);

        T GetById(Guid entityId);
        List<T> GetAll();
        List<T> Find(ISpecification<T> specification);
    }
}