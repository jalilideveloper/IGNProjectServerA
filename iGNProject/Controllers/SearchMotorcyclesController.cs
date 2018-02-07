using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchMotorcyclesController : ApiController
    {
        // GET: api/SearchMotorcycles
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchMotorcycles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchMotorcycles
        public IHttpActionResult Post(SearchMotorcycles value)
        {
        }

        // PUT: api/SearchMotorcycles/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchMotorcycles/5
        public void Delete(int id)
        {
        }
    }
}
