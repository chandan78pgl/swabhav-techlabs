using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BankAppApi.Controllers
{
    public class HomeController : ApiController
    {
        // GET: Home
        public IHttpActionResult Index()
        {
            return Ok("Home Index Is Called");
        }
    }
}