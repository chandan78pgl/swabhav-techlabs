using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace FirstApiApp.Repository
{
    public interface ISpecification<T>
    {
       Expression<Func<T,bool>> SearchFunction { get; }
    }
}