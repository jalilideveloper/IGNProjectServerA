using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchUserTypeIDalEntertainmentsController : ApiController
    {
        // GET: api/SearchUserTypeIDalEntertainments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchUserTypeIDalEntertainments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchUserTypeIDalEntertainments
        public IHttpActionResult Post(SearchPersonalEntertainments value)
        {
            return null;
        }

        // PUT: api/SearchUserTypeIDalEntertainments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchUserTypeIDalEntertainments/5
        public void Delete(int id)
        {
        }
    }
}
