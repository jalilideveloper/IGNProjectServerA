using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchCarHeavysController : ApiController
    {
        // GET: api/SearchCarHeavys
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCarHeavys/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCarHeavys
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SearchCarHeavys/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCarHeavys/5
        public void Delete(int id)
        {
        }
    }
}
