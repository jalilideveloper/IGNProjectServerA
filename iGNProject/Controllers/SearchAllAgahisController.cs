using CodeEngine.Framework.QueryBuilder;
using CodeEngine.Framework.QueryBuilder.Enums;
using iGNProject.Models;
using iGNProject.Models.RelApiClass;
using iGNProject.Models.Search;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchAllAgahisController : ApiController
    {
        // GET: api/SearchAllAgahis
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchAllAgahis/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchAllAgahis
        public IHttpActionResult Post(SearchAllAgahis value)
        {
            SelectQueryBuilder query = new SelectQueryBuilder();
            query.SelectFromTable("tblAgahi");

            if (value.CategoryID >= 0)
            {
                query.AddWhere("CategoryAgahiID", Comparison.Equals, value.CategoryID, 1);
            }
            if (value.SearchInput != "")
            {
                query.AddWhere("tblAgahi.AgahiTitle", Comparison.Like, value.SearchInput);
                query.AddWhere("tblAgahi.Description", Comparison.Like, value.SearchInput);

            }
            if (value.ShahrSelectID >= 0)
            {
                query.AddWhere("tblAgahi.RegionID", Comparison.Equals, value.ShahrSelectID);
            }
            if (value.HasFast)
            {
                query.AddWhere("tblAgahi.SpecialAgahi", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahi.SpecialAgahi", Comparison.Equals, false);
            }
            query.AddWhere("tblAgahi.HasImage", Comparison.Equals, value.HasImage);

            if (value.Kind >= 0)
            {
                query.AddWhere("tblAgahi.AgahiServiceID", Comparison.Equals, value.Kind);
            }

            var q = query.BuildQuery();
            using (var context = new DBEWDiGNEntities())
            {
                List<Agahi> studentList = context.tblAgahi
                                  .SqlQuery(q)
                                  .Select(p => new Agahi
                                  {
                                      AdminAgreeDate = p.AdminAgreeDate,
                                      AdminUserID = p.AdminUserID,
                                      AgahiID = p.AgahiID,
                                      AgahiServiceID = p.AgahiServiceID,
                                      AgahiStatus = p.AgahiStatus,
                                      PlanShowAgahiID = p.PlanShowAgahiID,
                                      AgahiTitle = p.AgahiTitle,
                                      CategoryAgahiID = p.CategoryAgahiID,
                                      Chatable = p.Chatable,
                                      Description = p.Description,
                                      HasImage = p.HasImage,
                                      Price = p.Price,
                                      LanguageID = p.LanguageID,
                                      Location = p.Location,
                                      Mobile = p.Mobile,
                                      OnTime = p.OnTime,
                                      PriceTypeID = p.PriceTypeID,
                                      ProvinceID = p.ProvinceID,
                                      RegionID = p.RegionID,
                                      RegisterDate = p.RegisterDate,
                                      SpecialAgahi = p.SpecialAgahi,
                                      Tell = p.Tell,
                                      UserID = p.UserID
                                  }).ToList<Agahi>();
                return Json(studentList);


            }
        }

        // PUT: api/SearchAllAgahis/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchAllAgahis/5
        public void Delete(int id)
        {
        }
    }
}
