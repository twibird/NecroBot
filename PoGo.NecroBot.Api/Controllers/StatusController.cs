using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PoGo.NecroBot.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Status")]
    public class StatusController : Controller
    {
        // GET: api/Status
        [HttpGet]
        public HttpStatusCode Get()
        {
            return HttpStatusCode.OK;
        }

        // GET: api/Status/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Status
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
