﻿using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchCarRidingsController : ApiController
    {
        // GET: api/SearchCarRidings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCarRidings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCarRidings
        public IHttpActionResult Post(SearchCarRidings value)
        {
            return null;
        }

        // PUT: api/SearchCarRidings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCarRidings/5
        public void Delete(int id)
        {
        }
    }
}
