using ProductAppApi.Models;
using ProductAppApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProductAppApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/product")]
    public class ProductController:ApiController
    {
        IRepository<Product> _productRepository = new ProductRepository();

        [Route("AllProducts")]
        public IHttpActionResult getAllProducts()
        {
            return Ok(_productRepository.GetAll());
        }

        [Route("ProductDetails/{id:int}")]
        public IHttpActionResult getProductById(int id)
        {
            return Ok(_productRepository.GetById(id));
        }

        [Route("SearchProducts/{searchString}")]
        public IHttpActionResult getProductsByName(string searchString)
        {
            return Ok(_productRepository.Find(searchString));
        }
    }
}