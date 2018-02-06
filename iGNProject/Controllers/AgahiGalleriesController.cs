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
    public class AgahiGalleriesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiGalleries
        public IHttpActionResult GettblAgahiGalleries()
        {
            return Json(db.tblAgahiGalleries.Select(p=> new { AgahiID = p.AgahiID , GalleryID = p.GalleryID, ImageAddress = p.ImageAddress}).ToList());
        }

        // GET: api/AgahiGalleries/5
        [ResponseType(typeof(tblAgahiGalleries))]
        public IHttpActionResult GettblAgahiGalleries(int id)
        {
            var tblAgahiGalleries = db.tblAgahiGalleries.Where(p=> p.GalleryID == id).Select(p=> new { GalleryID = p.GalleryID, AgahiID = p.AgahiID, ImageAddress = p.ImageAddress }).ToList();
            if (tblAgahiGalleries == null)
            {
                return NotFound();
            }

            return Ok(tblAgahiGalleries);
        }

        // PUT: api/AgahiGalleries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiGalleries(int id, tblAgahiGalleries tblAgahiGalleries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiGalleries.GalleryID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiGalleries).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiGalleriesExists(id))
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

        // POST: api/AgahiGalleries
        [ResponseType(typeof(tblAgahiGalleries))]
        public IHttpActionResult PosttblAgahiGalleries(tblAgahiGalleries tblAgahiGalleries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiGalleries.Add(tblAgahiGalleries);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tblAgahiGalleriesExists(tblAgahiGalleries.GalleryID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiGalleries.GalleryID }, tblAgahiGalleries);
        }

        // DELETE: api/AgahiGalleries/5
        [ResponseType(typeof(tblAgahiGalleries))]
        public IHttpActionResult DeletetblAgahiGalleries(int id)
        {
            tblAgahiGalleries tblAgahiGalleries = db.tblAgahiGalleries.Find(id);
            if (tblAgahiGalleries == null)
            {
                return NotFound();
            }

            db.tblAgahiGalleries.Remove(tblAgahiGalleries);
            db.SaveChanges();

            return Ok(tblAgahiGalleries);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiGalleriesExists(int id)
        {
            return db.tblAgahiGalleries.Count(e => e.GalleryID == id) > 0;
        }
    }
}