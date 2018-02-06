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
    public class CarMotorHajmesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarMotorHajmes
        public IHttpActionResult GettblCarMotorHajme()
        {
            return Json(db.tblCarMotorHajme.Select(p=> new { HajmCC = p.HajmCC , HamjName = p.HamjName, MotorHajmID = p.MotorHajmID}).ToList());
        }

        // GET: api/CarMotorHajmes/5
        [ResponseType(typeof(tblCarMotorHajme))]
        public IHttpActionResult GettblCarMotorHajme(int id)
        {
            var tblCarMotorHajme = db.tblCarMotorHajme.Where(p=> p.MotorHajmID == id).Select(p => new { HajmCC = p.HajmCC, HamjName = p.HamjName, MotorHajmID = p.MotorHajmID }).ToList();
            if (tblCarMotorHajme == null)
            {
                return NotFound();
            }

            return Json(tblCarMotorHajme);
        }

        // PUT: api/CarMotorHajmes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarMotorHajme(int id, tblCarMotorHajme tblCarMotorHajme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarMotorHajme.MotorHajmID)
            {
                return BadRequest();
            }

            db.Entry(tblCarMotorHajme).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarMotorHajmeExists(id))
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

        // POST: api/CarMotorHajmes
        [ResponseType(typeof(tblCarMotorHajme))]
        public IHttpActionResult PosttblCarMotorHajme(tblCarMotorHajme tblCarMotorHajme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarMotorHajme.Add(tblCarMotorHajme);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarMotorHajme.MotorHajmID }, tblCarMotorHajme);
        }

        // DELETE: api/CarMotorHajmes/5
        [ResponseType(typeof(tblCarMotorHajme))]
        public IHttpActionResult DeletetblCarMotorHajme(int id)
        {
            tblCarMotorHajme tblCarMotorHajme = db.tblCarMotorHajme.Find(id);
            if (tblCarMotorHajme == null)
            {
                return NotFound();
            }

            db.tblCarMotorHajme.Remove(tblCarMotorHajme);
            db.SaveChanges();

            return Ok(tblCarMotorHajme);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarMotorHajmeExists(int id)
        {
            return db.tblCarMotorHajme.Count(e => e.MotorHajmID == id) > 0;
        }
    }
}