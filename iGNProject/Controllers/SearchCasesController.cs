using CodeEngine.Framework.QueryBuilder;
using CodeEngine.Framework.QueryBuilder.Enums;
using iGNProject.Models;
using iGNProject.Models.RelApiClass;
using iGNProject.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iGNProject.Controllers
{
    public class SearchCasesController : ApiController
    {
        // GET: api/SearchCases
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCases/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCases
        public IHttpActionResult Post(SearchCases value)
        {

            SelectQueryBuilder query = new SelectQueryBuilder();
            query.SelectFromTable("tblAgahi");

            query.AddJoin(JoinType.InnerJoin,
                          "tblAgahiMobCompDetails", "AgahiID",
                          Comparison.Equals,
                          "tblAgahi", "AgahiID");

     
           



            if (value.CategoryID >= 0)
            {
                query.AddWhere("tblAgahi.CategoryAgahiID", Comparison.Equals, value.CategoryID, 1);
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

            if (value.KindTotalPrice >= 0)
            {
                query.AddWhere("tblAgahi.PriceTypeID", Comparison.Equals, value.KindTotalPrice);
            }

            if (value.FromTotalPrice >= 0 && value.FromTotalPrice < value.UntillTotalPrice)
            {
                query.AddWhere("tblAgahi.Price", Comparison.GreaterThan, value.FromTotalPrice);
                query.AddWhere("tblAgahi.Price", Comparison.LessThan, value.UntillTotalPrice);
            }


           

            if (value.MeasureRAM > 0)
            {
                query.AddWhere("tblAgahiMobCompDetails.Ram", Comparison.Equals, value.MeasureRAM);
            }

            if (value.MeasureCPU > 0)
            {
                query.AddWhere("tblAgahiMobCompDetails.Cpu", Comparison.Equals, value.MeasureCPU);
            }

            
            if (value.MeasureHard > 0)
            {
                query.AddWhere("tblAgahiMobCompDetails.HDDMeasure", Comparison.Equals, value.MeasureHard);
            }


            if (value.MeasureGraphic > 0)
            {
                query.AddWhere("tblAgahiMobCompDetails.Graphic", Comparison.Equals, value.MeasureGraphic);
            }


            if (value.HasUSB3)
            {
                query.AddWhere("tblAgahiMobCompDetails.HasUSB3", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiMobCompDetails.HasUSB3", Comparison.Equals, false);
            }



            if (value.HasDVDRW)
            {
                query.AddWhere("tblAgahiMobCompDetails.HasDVDRW", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiMobCompDetails.HasDVDRW", Comparison.Equals, false);
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

        // PUT: api/SearchCases/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCases/5
        public void Delete(int id)
        {
        }
    }
}
