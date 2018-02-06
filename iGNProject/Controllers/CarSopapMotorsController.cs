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
    public class CarSopapMotorsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarSopapMotors
        public IHttpActionResult GettblCarSopapMotor()
        {
            return Json(db.tblCarSopapMotor.Select(p=> new { SopapID = p.SopapID, SopapName = p.SopapName, SopapNumber = p.SopapNumber }).ToList());
        }

        // GET: api/CarSopapMotors/5
        [ResponseType(typeof(tblCarSopapMotor))]
        public IHttpActionResult GettblCarSopapMotor(int id)
        {
            var tblCarSopapMotor = db.tblCarSopapMotor.Where(p=> p.SopapID==id).Select(p => new { SopapID = p.SopapID, SopapName = p.SopapName, SopapNumber = p.SopapNumber }).ToList();
            if (tblCarSopapMotor == null)
            {
                return NotFound();
            }
            return Json(tblCarSopapMotor);
        }

        // PUT: api/CarSopapMotors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarSopapMotor(int id, tblCarSopapMotor tblCarSopapMotor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarSopapMotor.SopapID)
            {
                return BadRequest();
            }

            db.Entry(tblCarSopapMotor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarSopapMotorExists(id))
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

        // POST: api/CarSopapMotors
        [ResponseType(typeof(tblCarSopapMotor))]
        public IHttpActionResult PosttblCarSopapMotor(tblCarSopapMotor tblCarSopapMotor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarSopapMotor.Add(tblCarSopapMotor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarSopapMotor.SopapID }, tblCarSopapMotor);
        }

        // DELETE: api/CarSopapMotors/5
        [ResponseType(typeof(tblCarSopapMotor))]
        public IHttpActionResult DeletetblCarSopapMotor(int id)
        {
            tblCarSopapMotor tblCarSopapMotor = db.tblCarSopapMotor.Find(id);
            if (tblCarSopapMotor == null)
            {
                return NotFound();
            }

            db.tblCarSopapMotor.Remove(tblCarSopapMotor);
            db.SaveChanges();

            return Ok(tblCarSopapMotor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarSopapMotorExists(int id)
        {
            return db.tblCarSopapMotor.Count(e => e.SopapID == id) > 0;
        }
    }
}