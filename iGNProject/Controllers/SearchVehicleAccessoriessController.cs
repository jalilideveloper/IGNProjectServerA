using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchVehicleAccessoriessController : ApiController
    {
        // GET: api/SearchVehicleAccessoriess
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchVehicleAccessoriess/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchVehicleAccessoriess
        public IHttpActionResult Post(SearchVehicleAccessoriess value)
        {
        }

        // PUT: api/SearchVehicleAccessoriess/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchVehicleAccessoriess/5
        public void Delete(int id)
        {
        }
    }
}
