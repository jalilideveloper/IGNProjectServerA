using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterRentHouseSubsController : ApiController
    {
        // GET: api/RegisterRentHouseSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterRentHouseSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterRentHouseSubs
        public void Post(RegisterRentHouseSubs value)
        {
        }

        // PUT: api/RegisterRentHouseSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterRentHouseSubs/5
        public void Delete(int id)
        {
        }
    }
}
