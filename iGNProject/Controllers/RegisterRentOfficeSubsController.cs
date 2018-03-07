using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterRentOfficeSubsController : ApiController
    {
        // GET: api/RegisterRentOfficeSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterRentOfficeSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterRentOfficeSubs
        public void Post(RegisterRentOfficeSubs value)
        {
        }

        // PUT: api/RegisterRentOfficeSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterRentOfficeSubs/5
        public void Delete(int id)
        {
        }
    }
}
