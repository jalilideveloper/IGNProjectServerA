using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterServicesHouseSubsController : ApiController
    {
        // GET: api/RegisterServicesHouseSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterServicesHouseSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterServicesHouseSubs
        public void Post(RegisterServicesHouseSubs value)
        {
        }

        // PUT: api/RegisterServicesHouseSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterServicesHouseSubs/5
        public void Delete(int id)
        {
        }
    }
}
