﻿using IGN.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchRentHomesController : ApiController
    {
        // GET: api/SearchRentHomes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchRentHomes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchRentHomes
        public IHttpActionResult Post(SearchRentHomes value)
        {
        }

        // PUT: api/SearchRentHomes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchRentHomes/5
        public void Delete(int id)
        {
        }
    }
}
