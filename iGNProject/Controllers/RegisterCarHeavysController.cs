using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class RegisterCarHeavysController : ApiController
    {
        // GET: api/RegisterCarHeavys
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterCarHeavys/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterCarHeavys
        public void Post(RegisterCarHeavys value)
        {
        }

        // PUT: api/RegisterCarHeavys/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterCarHeavys/5
        public void Delete(int id)
        {
        }
    }
}
