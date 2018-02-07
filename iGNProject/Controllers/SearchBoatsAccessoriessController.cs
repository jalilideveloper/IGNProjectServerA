using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchBoatsAccessoriessController : ApiController
    {
        // GET: api/SearchBoatsAccessoriess
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchBoatsAccessoriess/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchBoatsAccessoriess
        public IHttpActionResult Post(SearchBoatsAccessoriess value)
        {
            return null;
        }

        // PUT: api/SearchBoatsAccessoriess/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchBoatsAccessoriess/5
        public void Delete(int id)
        {
        }
    }
}
