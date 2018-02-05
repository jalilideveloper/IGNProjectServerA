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
    public class RegionsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/Regions
        public IHttpActionResult GettblRegions()
        {
            return Json(db.tblRegions.Select(p => new { p.CityID, p.RegionID, p.RegionName }).ToList());
        }

        // GET: api/Regions/5
        [ResponseType(typeof(tblRegions))]
        public IHttpActionResult GettblRegions(int id)
        {
            var tblRegions = db.tblRegions.Where(p=> p.CityID == id).Select(p=> new {p.CityID,p.RegionID,p.RegionName }).ToList();
            if (tblRegions == null)
            {
                return NotFound();
            }

            return Json(tblRegions);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblRegionsExists(int id)
        {
            return db.tblRegions.Count(e => e.RegionID == id) > 0;
        }
    }
}