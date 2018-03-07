using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterMotorcyclesController : ApiController
    {
        // GET: api/RegisterMotorcycles
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterMotorcycles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterMotorcycles
        public void Post(RegisterMotorcycles value)
        {
        }

        // PUT: api/RegisterMotorcycles/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterMotorcycles/5
        public void Delete(int id)
        {
        }
    }
}
