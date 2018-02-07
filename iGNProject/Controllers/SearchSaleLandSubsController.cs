using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchSaleLandSubsController : ApiController
    {
        // GET: api/SearchSaleLandSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchSaleLandSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchSaleLandSubs
        public IHttpActionResult Post(SearchSaleLandSubs value)
        {
        }

        // PUT: api/SearchSaleLandSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchSaleLandSubs/5
        public void Delete(int id)
        {
        }
    }
}
