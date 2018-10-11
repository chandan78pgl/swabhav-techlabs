using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FirstApiApp.Controllers
{
    public class WelcomeController:ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Get Method Invoked");
        }

        public IHttpActionResult Get(int id)
        {
            return Ok("Get Method By Id");
        }

        public IHttpActionResult Post()
        {
            return Ok("Post Method Invoked");
        }

        public IHttpActionResult Put()
        {
            return Ok("Put Method Invoked");
        }

        public IHttpActionResult Delete()
        {
            return Ok("Delete Method Invoked");
        }
    }
}