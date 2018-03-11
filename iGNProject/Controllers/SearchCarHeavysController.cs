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
    public class SearchCarHeavysController : ApiController
    {
        // GET: api/SearchCarHeavys
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchCarHeavys/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchCarHeavys
        public IHttpActionResult Post(SearchCarHeavys value)
        {

            SelectQueryBuilder query = new SelectQueryBuilder();
            query.SelectFromTable("tblAgahi");

            query.AddJoin(JoinType.InnerJoin,
                          "tblAgahiCarDetails", "AgahiID",
                          Comparison.Equals,
                          "tblAgahi", "AgahiID");

            query.AddJoin(JoinType.InnerJoin,
                         "tblVam", "VamID",
                         Comparison.Equals,
                         "tblAgahiCarDetails", "VamID");

            query.AddJoin(JoinType.InnerJoin,
                     "tblCarConditions", "CarConditionID",
                     Comparison.Equals,
                     "tblAgahiCarDetails", "CarConditionID");

            query.AddJoin(JoinType.InnerJoin,
                   "tblCarChassis", "CarChassisTypeID",
                   Comparison.Equals,
                   "tblAgahiCarDetails", "CarChassisTypeID");



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


            if (value.FromMonthlyInstallment >= 0 && value.FromMonthlyInstallment < value.UntillMonthlyInstallment)
            {
                query.AddWhere("tblVam.MahanePrice", Comparison.GreaterThan, value.FromMonthlyInstallment);
                query.AddWhere("tblVam.MahanePrice", Comparison.LessThan, value.UntillMonthlyInstallment);
            }

            if (value.FNumberMonthlyInstallment >= 0 && value.FNumberMonthlyInstallment< value.UNumberMonthlyInstallment)
            {
                query.AddWhere("tblVam.Teadad", Comparison.GreaterThan, value.FromMonthlyInstallment);
                query.AddWhere("tblVam.Teadad", Comparison.LessThan, value.UntillMonthlyInstallment);
            }


            if (value.FromYear >= 0 && value.FromYear < value.UntillYear)
            {
                query.AddWhere("tblAgahiCarDetails.SaleSakht", Comparison.GreaterThan, value.FromMonthlyInstallment);
                query.AddWhere("tblAgahiCarDetails.SaleSakht", Comparison.LessThan, value.UntillMonthlyInstallment);
            }

            if (value.BrandID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.BrandID", Comparison.Equals, value.BrandID);
            }


            if (value.FromCarFunction >= 0 && value.FromCarFunction < value.UntillCarFunction)
            {
                query.AddWhere("tblAgahiCarDetails.karkardDaghigh", Comparison.GreaterThan, value.FromCarFunction);
                query.AddWhere("tblAgahiCarDetails.karkardDaghigh", Comparison.LessThan, value.UntillCarFunction);
            }


            

            if (value.KindConditionID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.CarConditionID", Comparison.Equals, value.KindConditionID);
            }


            if (value.KindChassisID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.CarChassisTypeID", Comparison.Equals, value.KindChassisID);
            }
            if (value.KindDiffID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.DiffType", Comparison.Equals, value.KindDiffID);
            }
            if (value.KindColorInID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.RangeDakheliID", Comparison.Equals, value.KindColorInID);
            }


            if (value.KindColorOutID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.RangeKharegiID", Comparison.Equals, value.KindColorOutID);
            }



            if (value.KindModelTipID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.CarTipID", Comparison.Equals, value.KindModelTipID);
            }
            if (value.KindFuelID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.SokhtID", Comparison.Equals, value.KindFuelID);
            }
            if (value.KindCrashID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.CarCrashTypeID", Comparison.Equals, value.KindCrashID);
            }


            if (value.KindPelakID >= 0)
            {
                query.AddWhere("tblAgahiCarDetails.CarPelakTypeID", Comparison.Equals, value.KindPelakID);
            }

            if (value.HasSound)
            {
                query.AddWhere("tblAgahiCarDetails.SunRoof", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiCarDetails.SunRoof", Comparison.Equals, false);
            }

            if (value.HasAlarm)
            {
                query.AddWhere("tblAgahiCarDetails.HasAlarm", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiCarDetails.HasAlarm", Comparison.Equals, false);
            }
            if (value.HasSound)
            {
                query.AddWhere("tblAgahiCarDetails.HasSound", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiCarDetails.HasSound", Comparison.Equals, false);

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
                                      CityID = p.CityID,
                                      RegionID = p.RegionID,
                                      RegisterDate = p.RegisterDate,
                                      SpecialAgahi = p.SpecialAgahi,
                                      Tell = p.Tell,
                                      UserID = p.UserID
                                  }).ToList<Agahi>();
                return Json(studentList);


            }


        }

        // PUT: api/SearchCarHeavys/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchCarHeavys/5
        public void Delete(int id)
        {
        }
    }
}
