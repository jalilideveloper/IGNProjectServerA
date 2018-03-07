using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterServicesEmploymentsController : ApiController
    {
        // GET: api/RegisterServicesEmployments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterServicesEmployments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterServicesEmployments
        public void Post(RegisterServicesEmployments value)
        {
        }

        // PUT: api/RegisterServicesEmployments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterServicesEmployments/5
        public void Delete(int id)
        {
        }
    }
}
