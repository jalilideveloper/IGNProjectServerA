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
    public class AgahiRangsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiRangs
        public IHttpActionResult GettblAgahiRang()
        {
            return Json(db.tblAgahiRang.Select(p=>new { AgahiRangID = p.AgahiRangID, ColorName   =p.ColorName }).ToList());
        }

        // GET: api/AgahiRangs/5
        [ResponseType(typeof(tblAgahiRang))]
        public IHttpActionResult GettblAgahiRang(int id)
        {
            var tblAgahiRang = db.tblAgahiRang.Where(p=> p.AgahiRangID == id).Select(p => new { AgahiRangID = p.AgahiRangID, ColorName = p.ColorName }).ToList();
            if (tblAgahiRang == null)
            {
                return NotFound();
            }

            return Json(tblAgahiRang);
        }

        // PUT: api/AgahiRangs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiRang(int id, tblAgahiRang tblAgahiRang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiRang.AgahiRangID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiRang).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiRangExists(id))
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

        // POST: api/AgahiRangs
        [ResponseType(typeof(tblAgahiRang))]
        public IHttpActionResult PosttblAgahiRang(tblAgahiRang tblAgahiRang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiRang.Add(tblAgahiRang);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiRang.AgahiRangID }, tblAgahiRang);
        }

        // DELETE: api/AgahiRangs/5
        [ResponseType(typeof(tblAgahiRang))]
        public IHttpActionResult DeletetblAgahiRang(int id)
        {
            tblAgahiRang tblAgahiRang = db.tblAgahiRang.Find(id);
            if (tblAgahiRang == null)
            {
                return NotFound();
            }

            db.tblAgahiRang.Remove(tblAgahiRang);
            db.SaveChanges();

            return Ok(tblAgahiRang);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiRangExists(int id)
        {
            return db.tblAgahiRang.Count(e => e.AgahiRangID == id) > 0;
        }
    }
}