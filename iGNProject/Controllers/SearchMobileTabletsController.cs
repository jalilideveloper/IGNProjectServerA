using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchMobileTabletsController : ApiController
    {
        // GET: api/SearchMobileTablets
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchMobileTablets/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchMobileTablets
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SearchMobileTablets/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchMobileTablets/5
        public void Delete(int id)
        {
        }
    }
}
