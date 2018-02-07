using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchRentOfficeSubsController : ApiController
    {
        // GET: api/SearchRentOfficeSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchRentOfficeSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchRentOfficeSubs
        public IHttpActionResult Post(SearchRentOfficeSubs value)
        {
        }

        // PUT: api/SearchRentOfficeSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchRentOfficeSubs/5
        public void Delete(int id)
        {
        }
    }
}
