﻿using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchElectronicssController : ApiController
    {
        // GET: api/SearchElectronicss
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchElectronicss/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchElectronicss
        public IHttpActionResult Post(SearchElectronicss value)
        {
            return null;
        }

        // PUT: api/SearchElectronicss/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchElectronicss/5
        public void Delete(int id)
        {
        }
    }
}
