using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace TenantManagementApi.Repository.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> SearchExpression { get; }
    }
}