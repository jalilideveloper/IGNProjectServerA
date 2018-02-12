using CodeEngine.Framework.QueryBuilder;
using CodeEngine.Framework.QueryBuilder.Enums;
using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchAccessoriesDetailsController : ApiController
    {
        // GET: api/SearchAccessoriesDetails
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchAccessoriesDetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchAccessoriesDetails
        public IHttpActionResult Post(SearchAccessoriesDetails value)
        {
            SelectQueryBuilder query = new SelectQueryBuilder();
            query.SelectFromTable("Orders");

            query.AddJoin(JoinType.InnerJoin,
                          "Customers", "CustomerID",
                          Comparison.Equals,
                          "Orders", "CustomerID");

            query.AddWhere("Customers.City", Comparison.Equals, "London");
            



            return null;
        }

        // PUT: api/SearchAccessoriesDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchAccessoriesDetails/5
        public void Delete(int id)
        {
        }
    }
}
