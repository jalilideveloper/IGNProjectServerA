using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterSaleLandSubsController : ApiController
    {
        // GET: api/RegisterSaleLandSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterSaleLandSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterSaleLandSubs
        public void Post(RegisterSaleLandSubs value)
        {
        }

        // PUT: api/RegisterSaleLandSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterSaleLandSubs/5
        public void Delete(int id)
        {
        }
    }
}
