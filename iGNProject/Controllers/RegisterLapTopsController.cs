using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterLapTopsController : ApiController
    {
        // GET: api/RegisterLapTops
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterLapTops/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterLapTops
        public void Post(RegisterLapTops value)
        {
        }

        // PUT: api/RegisterLapTops/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterLapTops/5
        public void Delete(int id)
        {
        }
    }
}
