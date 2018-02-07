using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchRentOfficesController : ApiController
    {
        // GET: api/SearchRentOffices
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchRentOffices/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchRentOffices
        public IHttpActionResult Post(SearchRentOffices value)
        {
            return null;
        }

        // PUT: api/SearchRentOffices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchRentOffices/5
        public void Delete(int id)
        {
        }
    }
}
