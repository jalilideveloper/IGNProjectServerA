using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchCasesController : ApiController
    {
        // GET: api/SearchCases
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCases/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCases
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SearchCases/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCases/5
        public void Delete(int id)
        {
        }
    }
}
