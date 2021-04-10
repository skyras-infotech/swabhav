using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPIDemoApp.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult GetAnything() 
        {
            return Ok("Get is working");
        }

        public IHttpActionResult PostAnything()
        {
            return Ok("Post is working");
        }

        public IHttpActionResult PutAnything()
        {
            return Ok("Put is working");
        }

        public IHttpActionResult DeleteAnything()
        {
            return Ok("Delete is working");
        }
    }
}
