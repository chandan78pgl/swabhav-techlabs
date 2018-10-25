using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAppApi.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Find(string name);
    }
}