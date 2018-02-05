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
    public class tblPriceTypesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/tblPriceTypes
        public IHttpActionResult GettblPriceType()
        {
            return Json(db.tblPriceType.Select(p=> new {p.PriceTypeID,p.PriceTypeName}).ToList());
        }

        // GET: api/tblPriceTypes/5
        [ResponseType(typeof(tblPriceType))]
        public IHttpActionResult GettblPriceType(int id)
        {
            tblPriceType tblPriceType = db.tblPriceType.Find(id);
            if (tblPriceType == null)
            {
                return NotFound();
            }

            return Json(tblPriceType);
        }

        // PUT: api/tblPriceTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblPriceType(int id, tblPriceType tblPriceType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblPriceType.PriceTypeID)
            {
                return BadRequest();
            }

            db.Entry(tblPriceType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblPriceTypeExists(id))
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

        // POST: api/tblPriceTypes
        [ResponseType(typeof(tblPriceType))]
        public IHttpActionResult PosttblPriceType(tblPriceType tblPriceType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblPriceType.Add(tblPriceType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblPriceType.PriceTypeID }, tblPriceType);
        }

        // DELETE: api/tblPriceTypes/5
        [ResponseType(typeof(tblPriceType))]
        public IHttpActionResult DeletetblPriceType(int id)
        {
            tblPriceType tblPriceType = db.tblPriceType.Find(id);
            if (tblPriceType == null)
            {
                return NotFound();
            }

            db.tblPriceType.Remove(tblPriceType);
            db.SaveChanges();

            return Ok(tblPriceType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblPriceTypeExists(int id)
        {
            return db.tblPriceType.Count(e => e.PriceTypeID == id) > 0;
        }
    }
}