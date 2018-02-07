using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchLapTopsController : ApiController
    {
        // GET: api/SearchLapTops
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchLapTops/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchLapTops
        public IHttpActionResult Post(SearchLapTops value)
        {
            return null;
        }

        // PUT: api/SearchLapTops/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchLapTops/5
        public void Delete(int id)
        {
        }
    }
}
