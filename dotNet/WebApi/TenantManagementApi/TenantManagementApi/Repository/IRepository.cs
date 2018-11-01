using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Repository.Specification;

namespace TenantManagementApi.Repository
{
    public interface IRepository<T>
    {
        Guid Add(T entity);
        void Update(T entity);
        void Delete(Guid entityId);

        T GetById(Guid entityId);
        IList<T> GetAll();
        IList<T> Find(ISpecification<T> specification);
    }
}