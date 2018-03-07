using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterPersonalEntertainmentsController : ApiController
    {
        // GET: api/RegisterPersonalEntertainments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterPersonalEntertainments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterPersonalEntertainments
        public void Post(RegisterPersonalEntertainments value)
        {
        }

        // PUT: api/RegisterPersonalEntertainments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterPersonalEntertainments/5
        public void Delete(int id)
        {
        }
    }
}
