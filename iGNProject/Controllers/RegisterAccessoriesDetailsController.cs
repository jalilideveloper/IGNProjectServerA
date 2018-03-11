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

        public System.Data.Entity.Core.Objects.ObjectParameter IDs { get; set; }
        // POST: api/RegisterAccessoriesDetails
        public void Post(RegisterAccessoriesDetails value)
        {
            
            using (DBEWDiGNEntities db = new DBEWDiGNEntities())
            {

             var q =   db.sp_AddAgahi_AccessoriesAndElectronicAndPerson(value.CategoryID, value.AgahiServiceID, value.TitleAgahi, false, value.AgahiDescription, "Key", DateTime.Now.Date.ToShortDateString(), value.UserID, 1, null, 0, value.Location
                    , value.CityID, value.RegionID, "No. ", value.AdvertiserMobile, value.KindTotalPriceID, value.TotalPrice, value.KindAdsID, false, false, value.OnTime, value.SpecialAgahi, 0, value.LanguageID, 0,
                    value.uploadimageone, value.uploadimagetwo, value.uploadimagethree, value.uploadimagefour,IDs);
            }


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
