using iGNProject.Models.Search;

using System.Collections.Generic;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchController : ApiController
    {
        // GET: api/Search
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Search/5
        public string Get(IHttpActionResult Json)
        {
            return "value";
        }

     

        // POST: api/Search
        public void Post(SearchAllAgahis value)
        {
        }


        // PUT: api/Search/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Search/5
        public void Delete(int id)
        {
        }
    }
}
