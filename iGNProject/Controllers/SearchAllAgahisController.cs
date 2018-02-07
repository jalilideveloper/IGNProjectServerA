using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchAllAgahisController : ApiController
    {
        // GET: api/SearchAllAgahis
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchAllAgahis/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchAllAgahis
        public IHttpActionResult Post(SearchAllAgahis value)
        {
            return null;
        }

        // PUT: api/SearchAllAgahis/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchAllAgahis/5
        public void Delete(int id)
        {
        }
    }
}
