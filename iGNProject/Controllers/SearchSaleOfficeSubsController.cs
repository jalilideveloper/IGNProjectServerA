using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchSaleOfficeSubsController : ApiController
    {
        // GET: api/SearchSaleOfficeSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchSaleOfficeSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchSaleOfficeSubs
        public IHttpActionResult Post(SearchSaleOfficeSubs value)
        {
        }

        // PUT: api/SearchSaleOfficeSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchSaleOfficeSubs/5
        public void Delete(int id)
        {
        }
    }
}
