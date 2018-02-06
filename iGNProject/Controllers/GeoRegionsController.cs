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
    public class GeoRegionsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/GeoRegions
        public IHttpActionResult GettblGeoRegion()
        {
            return Json(db.tblGeoRegion.Select(p=>new { GeoRegionID =  p.GeoRegionID, GeoTitle = p.GeoTitle}).ToList());
        }

        // GET: api/GeoRegions/5
        [ResponseType(typeof(tblGeoRegion))]
        public IHttpActionResult GettblGeoRegion(int id)
        {
            var tblGeoRegion = db.tblGeoRegion.Where(p=> p.GeoRegionID ==  id).Select(p => new { GeoRegionID = p.GeoRegionID, GeoTitle = p.GeoTitle }).ToList();
            if (tblGeoRegion == null)
            {
                return NotFound();
            }
            return Json(tblGeoRegion);
        }

        // PUT: api/GeoRegions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblGeoRegion(int id, tblGeoRegion tblGeoRegion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblGeoRegion.GeoRegionID)
            {
                return BadRequest();
            }

            db.Entry(tblGeoRegion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblGeoRegionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GeoRegions
        [ResponseType(typeof(tblGeoRegion))]
        public IHttpActionResult PosttblGeoRegion(tblGeoRegion tblGeoRegion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblGeoRegion.Add(tblGeoRegion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblGeoRegion.GeoRegionID }, tblGeoRegion);
        }

        // DELETE: api/GeoRegions/5
        [ResponseType(typeof(tblGeoRegion))]
        public IHttpActionResult DeletetblGeoRegion(int id)
        {
            tblGeoRegion tblGeoRegion = db.tblGeoRegion.Find(id);
            if (tblGeoRegion == null)
            {
                return NotFound();
            }

            db.tblGeoRegion.Remove(tblGeoRegion);
            db.SaveChanges();

            return Ok(tblGeoRegion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblGeoRegionExists(int id)
        {
            return db.tblGeoRegion.Count(e => e.GeoRegionID == id) > 0;
        }
    }
}