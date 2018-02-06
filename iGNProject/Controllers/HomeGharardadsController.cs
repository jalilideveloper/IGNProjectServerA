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
    public class HomeGharardadsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/HomeGharardads
        public IHttpActionResult GettblHomeGharardad()
        {
            return Json(db.tblHomeGharardad.Select(p=> new { GharardadTypeID =p.GharardadTypeID , TypeName = p.TypeName}).ToList());
        }

        // GET: api/HomeGharardads/5
        [ResponseType(typeof(tblHomeGharardad))]
        public IHttpActionResult GettblHomeGharardad(int id)
        {
            var tblHomeGharardad = db.tblHomeGharardad.Where(p=> p.GharardadTypeID == id).Select(p => new { GharardadTypeID = p.GharardadTypeID, TypeName = p.TypeName }).ToList();
            if (tblHomeGharardad == null)
            {
                return NotFound();
            }

            return Json(tblHomeGharardad);
        }

        // PUT: api/HomeGharardads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblHomeGharardad(int id, tblHomeGharardad tblHomeGharardad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblHomeGharardad.GharardadTypeID)
            {
                return BadRequest();
            }

            db.Entry(tblHomeGharardad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblHomeGharardadExists(id))
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

        // POST: api/HomeGharardads
        [ResponseType(typeof(tblHomeGharardad))]
        public IHttpActionResult PosttblHomeGharardad(tblHomeGharardad tblHomeGharardad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblHomeGharardad.Add(tblHomeGharardad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblHomeGharardad.GharardadTypeID }, tblHomeGharardad);
        }

        // DELETE: api/HomeGharardads/5
        [ResponseType(typeof(tblHomeGharardad))]
        public IHttpActionResult DeletetblHomeGharardad(int id)
        {
            tblHomeGharardad tblHomeGharardad = db.tblHomeGharardad.Find(id);
            if (tblHomeGharardad == null)
            {
                return NotFound();
            }

            db.tblHomeGharardad.Remove(tblHomeGharardad);
            db.SaveChanges();

            return Ok(tblHomeGharardad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblHomeGharardadExists(int id)
        {
            return db.tblHomeGharardad.Count(e => e.GharardadTypeID == id) > 0;
        }
    }
}