using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterSaleApartSubsController : ApiController
    {
        // GET: api/RegisterSaleApartSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterSaleApartSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterSaleApartSubs
        public void Post(RegisterSaleApartSubs value)
        {
        }

        // PUT: api/RegisterSaleApartSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterSaleApartSubs/5
        public void Delete(int id)
        {
        }
    }
}
