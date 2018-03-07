using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterCarRidingsController : ApiController
    {
        // GET: api/RegisterCarRidings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterCarRidings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterCarRidings
        public void Post(RegisterCarRidings value)
        {
        }

        // PUT: api/RegisterCarRidings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterCarRidings/5
        public void Delete(int id)
        {
        }
    }
}
