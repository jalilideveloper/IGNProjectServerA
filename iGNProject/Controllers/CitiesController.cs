using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using iGNProject.Models;

namespace iGNProject.Controllers
{
    public class CitiesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/tblCities
        public IHttpActionResult GettblCity()
        {
            return Json(db.tblCity.Select(p => new { p.CityID, p.CityName, p.ProvinceId }).ToList());
        }

        // GET: api/tblCities/5
        [ResponseType(typeof(tblCity))]
        public IHttpActionResult GettblCity(int id)
        {
            var tblCity = db.tblCity.Where(p => p.ProvinceId == id).Select(p=> new {p.CityID,p.CityName,p.ProvinceId }).ToList() ;
            if (tblCity == null)
            {
                return NotFound();
            }

            return Json(tblCity);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCityExists(int id)
        {
            return db.tblCity.Count(e => e.CityID == id) > 0;
        }
    }
}