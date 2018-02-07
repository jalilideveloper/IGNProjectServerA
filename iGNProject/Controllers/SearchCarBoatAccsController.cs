using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchCarBoatAccsController : ApiController
    {
        // GET: api/SearchCarBoatAccs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCarBoatAccs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCarBoatAccs
        public IHttpActionResult Post(SearchCarBoatAccs value)
        {
        }

        // PUT: api/SearchCarBoatAccs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCarBoatAccs/5
        public void Delete(int id)
        {
        }
    }
}
