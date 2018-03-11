using iGNProject.Models.AdsRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Models
{
    public class RegisterAccessoriesDetailsController : ApiController
    {
        // GET: api/RegisterAccessoriesDetails
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterAccessoriesDetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterAccessoriesDetails
        public void Post(RegisterAccessoriesDetails value)
        {

        }

        // PUT: api/RegisterAccessoriesDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterAccessoriesDetails/5
        public void Delete(int id)
        {
        }
    }
}
