using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterCasesController : ApiController
    {
        // GET: api/RegisterCases
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterCases/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterCases
        public void Post(RegisterCases value)
        {
        }

        // PUT: api/RegisterCases/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterCases/5
        public void Delete(int id)
        {
        }
    }
}
