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
    public class CarSokhtsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarSokhts
        public IHttpActionResult GettblCarSokht()
        {
            return Json(db.tblCarSokht.Select(p=> new { SokhName = p.SokhName , SokhtID = p.SokhtID}).ToList());
        }

        // GET: api/CarSokhts/5
        [ResponseType(typeof(tblCarSokht))]
        public IHttpActionResult GettblCarSokht(int id)
        {
            var tblCarSokht = db.tblCarSokht.Where(p=> p.SokhtID == id).Select(p => new { SokhName = p.SokhName, SokhtID = p.SokhtID }).ToList();
            if (tblCarSokht == null)
            {
                return NotFound();
            }
            return Json(tblCarSokht);
        }

        // PUT: api/CarSokhts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarSokht(int id, tblCarSokht tblCarSokht)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarSokht.SokhtID)
            {
                return BadRequest();
            }

            db.Entry(tblCarSokht).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarSokhtExists(id))
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

        // POST: api/CarSokhts
        [ResponseType(typeof(tblCarSokht))]
        public IHttpActionResult PosttblCarSokht(tblCarSokht tblCarSokht)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarSokht.Add(tblCarSokht);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarSokht.SokhtID }, tblCarSokht);
        }

        // DELETE: api/CarSokhts/5
        [ResponseType(typeof(tblCarSokht))]
        public IHttpActionResult DeletetblCarSokht(int id)
        {
            tblCarSokht tblCarSokht = db.tblCarSokht.Find(id);
            if (tblCarSokht == null)
            {
                return NotFound();
            }

            db.tblCarSokht.Remove(tblCarSokht);
            db.SaveChanges();

            return Ok(tblCarSokht);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarSokhtExists(int id)
        {
            return db.tblCarSokht.Count(e => e.SokhtID == id) > 0;
        }
    }
}