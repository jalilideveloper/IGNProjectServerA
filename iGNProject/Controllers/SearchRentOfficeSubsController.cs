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
    public class SearchRentOfficeSubsController : ApiController
    {
        // GET: api/SearchRentOfficeSubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SearchRentOfficeSubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SearchRentOfficeSubs
        public IHttpActionResult Post(SearchRentOfficeSubs value)
        {
            SelectQueryBuilder query = new SelectQueryBuilder();
            query.SelectFromTable("tblAgahi");

            query.AddJoin(JoinType.InnerJoin,
                         "tblAgahiHomeDetail", "AgahiID",
                         Comparison.Equals,
                         "tblAgahi", "AgahiID");


            if (value.CategoryID > 0)
            {
                query.AddWhere("CategoryAgahiID", Comparison.Equals, value.CategoryID, 1);
            }
            if (value.SearchInput != "")
            {
                query.AddWhere("tblAgahi.AgahiTitle", Comparison.Like, value.SearchInput);
                query.AddWhere("tblAgahi.Description", Comparison.Like, value.SearchInput);

            }
            if (value.UserTypeID > 0)
            {
                query.AddWhere("tblAgahi.UserAgahiTypeID", Comparison.Equals, value.UserTypeID);
            }


            if (value.ShahrSelectID > 0)
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
            if (value.HasImage)
            {
                query.AddWhere("tblAgahi.HasImage", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahi.HasImage", Comparison.Equals, false);
            }

            if (value.Kind > 0)
            {
                query.AddWhere("tblAgahi.AgahiServiceID", Comparison.Equals, value.Kind);
            }

            if (value.KindRentPriceID > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.GharardadTypeID", Comparison.Equals, value.KindRentPriceID);
                //KindRentPrice نوع ودیعه
                //KindDepositPrice نوع اجاره ماهانه
            }

            if (value.FromRentPrice >= 0 && value.FromRentPrice < value.UntillRentPrice)
            {
                query.AddWhere("tblAgahiHomeDetail.MablagheKole", Comparison.GreaterThan, value.FromRentPrice);
                query.AddWhere("tblAgahiHomeDetail.MablagheKole", Comparison.LessThan, value.UntillRentPrice);
            }

            if (value.FromDepositPrice >= 0 && value.FromDepositPrice < value.UntillDepositPrice)
            {
                query.AddWhere("tblAgahiHomeDetail.MablagheMahane", Comparison.GreaterThan, value.FromRentPrice);
                query.AddWhere("tblAgahiHomeDetail.MablagheMahane", Comparison.LessThan, value.UntillRentPrice);
            }

            if (value.FromYear >= 0 && value.FromYear < value.UntillYear)
            {
                query.AddWhere("tblAgahiHomeDetail.SaleSakht", Comparison.GreaterThan, value.FromYear);
                query.AddWhere("tblAgahiHomeDetail.SaleSakht", Comparison.LessThan, value.UntillYear);
            }

            if (value.FromArea >= 0 && value.FromArea < value.UntillArea)
            {
                query.AddWhere("tblAgahiHomeDetail.Area", Comparison.GreaterThan, value.FromArea);
                query.AddWhere("tblAgahiHomeDetail.Area", Comparison.LessThan, value.UntillArea);
            }

            if (value.Countryside > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.CitySideTypeID", Comparison.Equals, value.Countryside);
            }

            if (value.RoomNumber > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.OtaghKhab", Comparison.Equals, value.RoomNumber);
            }
            if (value.FloorNumber > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.Tabaghe", Comparison.Equals, value.RoomNumber);
            }

            if (value.KindBottomID > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.JeneskafID", Comparison.Equals, value.KindBottomID);
            }

            if (value.KindHeatingID > 0)
            {
                query.AddWhere("tblAgahiHomeDetail.GarmayeshTypeID", Comparison.Equals, value.KindHeatingID);
            }

            //---------------------------
            if (value.HasParking)
            {
                query.AddWhere("tblAgahiHomeDetail.Parking", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Parking", Comparison.Equals, false);
            }

            if (value.HasElevator)
            {
                query.AddWhere("tblAgahiHomeDetail.Asansor", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Asansor", Comparison.Equals, false);
            }


            if (value.HasIranianService)
            {
                query.AddWhere("tblAgahiHomeDetail.ServiceIrani", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.ServiceIrani", Comparison.Equals, false);
            }

            if (value.HasForeignService)
            {
                query.AddWhere("tblAgahiHomeDetail.ServiceKhareji", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.ServiceKhareji", Comparison.Equals, false);
            }


            if (value.HasBalcony)
            {
                query.AddWhere("tblAgahiHomeDetail.Balkon", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Balkon", Comparison.Equals, false);
            }


            if (value.HasPool)
            {
                query.AddWhere("tblAgahiHomeDetail.Estakhr", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Estakhr", Comparison.Equals, false);
            }



            if (value.HasUnderground)
            {
                query.AddWhere("tblAgahiHomeDetail.Zirzamin", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Zirzamin", Comparison.Equals, false);
            }


            if (value.HasYard)
            {
                query.AddWhere("tblAgahiHomeDetail.Hayat", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Hayat", Comparison.Equals, false);
            }

            if (value.HasSauna)
            {
                query.AddWhere("tblAgahiHomeDetail.Sona", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Sona", Comparison.Equals, false);
            }


            if (value.HasJacuzzi)
            {
                query.AddWhere("tblAgahiHomeDetail.Jakozi", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Jakozi", Comparison.Equals, false);
            }



            if (value.HasSleepMaster)
            {
                query.AddWhere("tblAgahiHomeDetail.Khabmaster", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Khabmaster", Comparison.Equals, false);
            }



            if (value.HasRoofGarden)
            {
                query.AddWhere("tblAgahiHomeDetail.Roofgarden", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Roofgarden", Comparison.Equals, false);
            }



            if (value.HasChiller)
            {
                query.AddWhere("tblAgahiHomeDetail.Chiler", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Chiler", Comparison.Equals, false);
            }


            if (value.HasBarbecue)
            {
                query.AddWhere("tblAgahiHomeDetail.Barbikio", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Barbikio", Comparison.Equals, false);
            }


            if (value.HasAltar)
            {
                query.AddWhere("tblAgahiHomeDetail.Alachigh", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Alachigh", Comparison.Equals, false);
            }


            if (value.HasLobby)
            {
                query.AddWhere("tblAgahiHomeDetail.Labi", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Labi", Comparison.Equals, false);
            }
            if (value.HasBabyPlayground)
            {
                query.AddWhere("tblAgahiHomeDetail.MohavateBaziKodak", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.MohavateBaziKodak", Comparison.Equals, false);
            }


            if (value.HasGym)
            {
                query.AddWhere("tblAgahiHomeDetail.Badansazi", Comparison.Equals, true);
            }
            else
            {
                query.AddWhere("tblAgahiHomeDetail.Badansazi", Comparison.Equals, false);
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

        // PUT: api/SearchRentOfficeSubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchRentOfficeSubs/5
        public void Delete(int id)
        {
        }
    }
}
