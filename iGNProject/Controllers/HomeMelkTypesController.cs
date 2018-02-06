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
    public class HomeMelkTypesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/HomeMelkTypes
        public IHttpActionResult GettblHomeMelkType()
        {
            return Json(db.tblHomeMelkType.Select(p=> new { MelkType = p.MelkType, MelkTypeID = p.MelkTypeID}).ToList());
        }

        // GET: api/HomeMelkTypes/5
        [ResponseType(typeof(tblHomeMelkType))]
        public IHttpActionResult GettblHomeMelkType(int id)
        {
            var tblHomeMelkType = db.tblHomeMelkType.Where(p=> p.MelkTypeID == id).Select(p => new { MelkType = p.MelkType, MelkTypeID = p.MelkTypeID }).ToList();
            if (tblHomeMelkType == null)
            {
                return NotFound();
            }
            return Json(tblHomeMelkType);
        }

        // PUT: api/HomeMelkTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblHomeMelkType(int id, tblHomeMelkType tblHomeMelkType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblHomeMelkType.MelkTypeID)
            {
                return BadRequest();
            }

            db.Entry(tblHomeMelkType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblHomeMelkTypeExists(id))
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

        // POST: api/HomeMelkTypes
        [ResponseType(typeof(tblHomeMelkType))]
        public IHttpActionResult PosttblHomeMelkType(tblHomeMelkType tblHomeMelkType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblHomeMelkType.Add(tblHomeMelkType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblHomeMelkType.MelkTypeID }, tblHomeMelkType);
        }

        // DELETE: api/HomeMelkTypes/5
        [ResponseType(typeof(tblHomeMelkType))]
        public IHttpActionResult DeletetblHomeMelkType(int id)
        {
            tblHomeMelkType tblHomeMelkType = db.tblHomeMelkType.Find(id);
            if (tblHomeMelkType == null)
            {
                return NotFound();
            }

            db.tblHomeMelkType.Remove(tblHomeMelkType);
            db.SaveChanges();

            return Ok(tblHomeMelkType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblHomeMelkTypeExists(int id)
        {
            return db.tblHomeMelkType.Count(e => e.MelkTypeID == id) > 0;
        }
    }
}