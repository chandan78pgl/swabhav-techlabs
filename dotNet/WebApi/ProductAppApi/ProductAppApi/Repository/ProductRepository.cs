using ProductAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAppApi.Repository
{
    public class ProductRepository:IRepository<Product>
    {
        private ProductDBContext _productDBContext;

        public ProductRepository()
        {
            _productDBContext = new ProductDBContext();
        }

        public List<Product> Find(string name)
        {
            return _productDBContext.Products
                        .Where((p) => p.ProductName.ToLower().Contains(name.ToLower()))
                        .ToList();
        }

        public List<Product> GetAll()
        {
            return _productDBContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _productDBContext.Products
                        .Where((p) => p.ProductId == id)
                        .SingleOrDefault();
        }
    }
}