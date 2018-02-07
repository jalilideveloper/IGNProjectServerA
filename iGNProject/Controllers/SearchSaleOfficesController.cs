using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchSaleOfficesController : ApiController
    {
        // GET: api/SearchSaleOffices
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchSaleOffices/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchSaleOffices
        public IHttpActionResult Post(SearchSaleOffices value)
        {
            return null;
        }

        // PUT: api/SearchSaleOffices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchSaleOffices/5
        public void Delete(int id)
        {
        }
    }
}
