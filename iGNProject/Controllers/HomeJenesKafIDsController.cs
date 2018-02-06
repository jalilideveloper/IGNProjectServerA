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
    public class HomeJenesKafIDsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/HomeJenesKafIDs
        public IHttpActionResult GettblHomeJenesKafID()
        {
            return Json(db.tblHomeJenesKafID.Select(p=> new { JeneskafID = p.JeneskafID, JeneskafName = p.JeneskafName }).ToList());
        }

        // GET: api/HomeJenesKafIDs/5
        [ResponseType(typeof(tblHomeJenesKafID))]
        public IHttpActionResult GettblHomeJenesKafID(int id)
        {
            var tblHomeJenesKafID = db.tblHomeJenesKafID.Where(p=> p.JeneskafID ==id).Select(p => new { JeneskafID = p.JeneskafID, JeneskafName = p.JeneskafName }).ToList();
            if (tblHomeJenesKafID == null)
            {
                return NotFound();
            }

            return Json(tblHomeJenesKafID);
        }

        // PUT: api/HomeJenesKafIDs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblHomeJenesKafID(int id, tblHomeJenesKafID tblHomeJenesKafID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblHomeJenesKafID.JeneskafID)
            {
                return BadRequest();
            }

            db.Entry(tblHomeJenesKafID).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblHomeJenesKafIDExists(id))
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

        // POST: api/HomeJenesKafIDs
        [ResponseType(typeof(tblHomeJenesKafID))]
        public IHttpActionResult PosttblHomeJenesKafID(tblHomeJenesKafID tblHomeJenesKafID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblHomeJenesKafID.Add(tblHomeJenesKafID);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblHomeJenesKafID.JeneskafID }, tblHomeJenesKafID);
        }

        // DELETE: api/HomeJenesKafIDs/5
        [ResponseType(typeof(tblHomeJenesKafID))]
        public IHttpActionResult DeletetblHomeJenesKafID(int id)
        {
            tblHomeJenesKafID tblHomeJenesKafID = db.tblHomeJenesKafID.Find(id);
            if (tblHomeJenesKafID == null)
            {
                return NotFound();
            }

            db.tblHomeJenesKafID.Remove(tblHomeJenesKafID);
            db.SaveChanges();

            return Ok(tblHomeJenesKafID);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblHomeJenesKafIDExists(int id)
        {
            return db.tblHomeJenesKafID.Count(e => e.JeneskafID == id) > 0;
        }
    }
}