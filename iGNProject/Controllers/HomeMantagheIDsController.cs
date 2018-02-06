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
    public class HomeMantagheIDsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/HomeMantagheIDs
        public IHttpActionResult GettblHomeMantagheID()
        {
            return Json(db.tblHomeMantagheID.Select(p=> new { MantagheID = p.MantagheID , MantagheNumber = p.MantagheNumber}).ToList());
        }

        // GET: api/HomeMantagheIDs/5
        [ResponseType(typeof(tblHomeMantagheID))]
        public IHttpActionResult GettblHomeMantagheID(int id)
        {
            var tblHomeMantagheID = db.tblHomeMantagheID.Where(p=> p.MantagheID == id).Select(p => new { MantagheID = p.MantagheID, MantagheNumber = p.MantagheNumber }).ToList();
            if (tblHomeMantagheID == null)
            {
                return NotFound();
            }

            return Json(tblHomeMantagheID);
        }

        // PUT: api/HomeMantagheIDs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblHomeMantagheID(int id, tblHomeMantagheID tblHomeMantagheID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblHomeMantagheID.MantagheID)
            {
                return BadRequest();
            }

            db.Entry(tblHomeMantagheID).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblHomeMantagheIDExists(id))
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

        // POST: api/HomeMantagheIDs
        [ResponseType(typeof(tblHomeMantagheID))]
        public IHttpActionResult PosttblHomeMantagheID(tblHomeMantagheID tblHomeMantagheID)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblHomeMantagheID.Add(tblHomeMantagheID);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblHomeMantagheID.MantagheID }, tblHomeMantagheID);
        }

        // DELETE: api/HomeMantagheIDs/5
        [ResponseType(typeof(tblHomeMantagheID))]
        public IHttpActionResult DeletetblHomeMantagheID(int id)
        {
            tblHomeMantagheID tblHomeMantagheID = db.tblHomeMantagheID.Find(id);
            if (tblHomeMantagheID == null)
            {
                return NotFound();
            }

            db.tblHomeMantagheID.Remove(tblHomeMantagheID);
            db.SaveChanges();

            return Ok(tblHomeMantagheID);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblHomeMantagheIDExists(int id)
        {
            return db.tblHomeMantagheID.Count(e => e.MantagheID == id) > 0;
        }
    }
}