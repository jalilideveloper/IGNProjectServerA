using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchPersonalEntertainmentsController : ApiController
    {
        // GET: api/SearchPersonalEntertainments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchPersonalEntertainments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchPersonalEntertainments
        public IHttpActionResult Post(SearchPersonalEntertainments value)
        {
        }

        // PUT: api/SearchPersonalEntertainments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchPersonalEntertainments/5
        public void Delete(int id)
        {
        }
    }
}
