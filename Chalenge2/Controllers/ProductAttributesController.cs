using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Challenge2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributesController : ControllerBase
    {
        // GET: api/ProductAttributes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductAttributes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductAttributes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductAttributes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductAttributes/5
        public void Delete(int id)
        {
        }
    }
}
