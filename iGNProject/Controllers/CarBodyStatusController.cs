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
    public class CarBodyStatusController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarBodyStatus
        public IHttpActionResult GettblCarBodyStatus()
        {
            return Json(db.tblCarBodyStatus.ToList());
        }

        // GET: api/CarBodyStatus/5
        [ResponseType(typeof(tblCarBodyStatus))]
        public IHttpActionResult GettblCarBodyStatus(int id)
        {
            tblCarBodyStatus tblCarBodyStatus = db.tblCarBodyStatus.Where(p=> p.CarBodyStatusID == id).FirstOrDefault();
            if (tblCarBodyStatus == null)
            {
                return NotFound();
            }

            return Json(tblCarBodyStatus);
        }

        // PUT: api/CarBodyStatus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarBodyStatus(int id, tblCarBodyStatus tblCarBodyStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarBodyStatus.CarBodyStatusID)
            {
                return BadRequest();
            }

            db.Entry(tblCarBodyStatus).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarBodyStatusExists(id))
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

        // POST: api/CarBodyStatus
        [ResponseType(typeof(tblCarBodyStatus))]
        public IHttpActionResult PosttblCarBodyStatus(tblCarBodyStatus tblCarBodyStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarBodyStatus.Add(tblCarBodyStatus);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarBodyStatus.CarBodyStatusID }, tblCarBodyStatus);
        }

        // DELETE: api/CarBodyStatus/5
        [ResponseType(typeof(tblCarBodyStatus))]
        public IHttpActionResult DeletetblCarBodyStatus(int id)
        {
            tblCarBodyStatus tblCarBodyStatus = db.tblCarBodyStatus.Find(id);
            if (tblCarBodyStatus == null)
            {
                return NotFound();
            }

            db.tblCarBodyStatus.Remove(tblCarBodyStatus);
            db.SaveChanges();

            return Ok(tblCarBodyStatus);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarBodyStatusExists(int id)
        {
            return db.tblCarBodyStatus.Count(e => e.CarBodyStatusID == id) > 0;
        }
    }
}