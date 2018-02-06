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
    public class AgahiPlansController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiPlans
        public IHttpActionResult GettblAgahiPlans()
        {
            return Json(db.tblAgahiPlans.Select(p=> new { NumberDayShow = p.NumberDayShow, PlanName = p.PlanName, PlanShowAgahiID = p.PlanShowAgahiID, Price = p.Price  }).ToList());
        }

        // GET: api/AgahiPlans/5
        [ResponseType(typeof(tblAgahiPlans))]
        public IHttpActionResult GettblAgahiPlans(int id)
        {
            var tblAgahiPlans = db.tblAgahiPlans.Where(o=> o.PlanShowAgahiID == id).Select(p => new { NumberDayShow = p.NumberDayShow, PlanName = p.PlanName, PlanShowAgahiID = p.PlanShowAgahiID, Price = p.Price }).ToList();
            if (tblAgahiPlans == null)
            {
                return NotFound();
            }

            return Json(tblAgahiPlans);
        }

        // PUT: api/AgahiPlans/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiPlans(int id, tblAgahiPlans tblAgahiPlans)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiPlans.PlanShowAgahiID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiPlans).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiPlansExists(id))
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

        // POST: api/AgahiPlans
        [ResponseType(typeof(tblAgahiPlans))]
        public IHttpActionResult PosttblAgahiPlans(tblAgahiPlans tblAgahiPlans)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiPlans.Add(tblAgahiPlans);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiPlans.PlanShowAgahiID }, tblAgahiPlans);
        }

        // DELETE: api/AgahiPlans/5
        [ResponseType(typeof(tblAgahiPlans))]
        public IHttpActionResult DeletetblAgahiPlans(int id)
        {
            tblAgahiPlans tblAgahiPlans = db.tblAgahiPlans.Find(id);
            if (tblAgahiPlans == null)
            {
                return NotFound();
            }

            db.tblAgahiPlans.Remove(tblAgahiPlans);
            db.SaveChanges();

            return Ok(tblAgahiPlans);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiPlansExists(int id)
        {
            return db.tblAgahiPlans.Count(e => e.PlanShowAgahiID == id) > 0;
        }
    }
}