using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterMobileTabletsController : ApiController
    {
        // GET: api/RegisterMobileTablets
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterMobileTablets/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterMobileTablets
        public void Post(RegisterMobileTablets value)
        {
        }

        // PUT: api/RegisterMobileTablets/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterMobileTablets/5
        public void Delete(int id)
        {
        }
    }
}
