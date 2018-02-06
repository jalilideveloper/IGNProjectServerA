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
    public class JeansBadanesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/JeansBadanes
        public IHttpActionResult GettblJeansBadane()
        {
            return Json(db.tblJeansBadane.Select(p=> new { JeansBadaneID = p.JeansBadaneID, JeansBadaneType = p.JeansBadaneType}).ToList());
        }

        // GET: api/JeansBadanes/5
        [ResponseType(typeof(tblJeansBadane))]
        public IHttpActionResult GettblJeansBadane(int id)
        {
            var tblJeansBadane = db.tblJeansBadane.Where(p=> p.JeansBadaneID== id).Select(p => new { JeansBadaneID = p.JeansBadaneID, JeansBadaneType = p.JeansBadaneType }).ToList();
            if (tblJeansBadane == null)
            {
                return NotFound();
            }
            return Json(tblJeansBadane);
        }

        // PUT: api/JeansBadanes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblJeansBadane(int id, tblJeansBadane tblJeansBadane)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblJeansBadane.JeansBadaneID)
            {
                return BadRequest();
            }

            db.Entry(tblJeansBadane).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblJeansBadaneExists(id))
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

        // POST: api/JeansBadanes
        [ResponseType(typeof(tblJeansBadane))]
        public IHttpActionResult PosttblJeansBadane(tblJeansBadane tblJeansBadane)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblJeansBadane.Add(tblJeansBadane);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblJeansBadane.JeansBadaneID }, tblJeansBadane);
        }

        // DELETE: api/JeansBadanes/5
        [ResponseType(typeof(tblJeansBadane))]
        public IHttpActionResult DeletetblJeansBadane(int id)
        {
            tblJeansBadane tblJeansBadane = db.tblJeansBadane.Find(id);
            if (tblJeansBadane == null)
            {
                return NotFound();
            }

            db.tblJeansBadane.Remove(tblJeansBadane);
            db.SaveChanges();

            return Ok(tblJeansBadane);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblJeansBadaneExists(int id)
        {
            return db.tblJeansBadane.Count(e => e.JeansBadaneID == id) > 0;
        }
    }
}