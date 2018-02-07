using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchSaleHomesController : ApiController
    {
        // GET: api/SearchSaleHomes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchSaleHomes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchSaleHomes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SearchSaleHomes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchSaleHomes/5
        public void Delete(int id)
        {
        }
    }
}
