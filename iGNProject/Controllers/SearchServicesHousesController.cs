using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchServicesHousesController : ApiController
    {
        // GET: api/SearchServicesHouses
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchServicesHouses/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchServicesHouses
        public IHttpActionResult Post(SearchServicesHouses value)
        {
            return null;
        }

        // PUT: api/SearchServicesHouses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchServicesHouses/5
        public void Delete(int id)
        {
        }
    }
}
