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
    public class AgahiBrandMobileCopmutersController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiBrandMobileCopmuters
        public IHttpActionResult GettblAgahiBrandMobileCopmuter()
        {
            return Json(db.tblAgahiBrandMobileCopmuter.Select(p=> new { AllinOne = p.AllinOne, BrandID = p.BrandID, BrandName = p.BrandName , Computer = p.Computer, Labtop = p.Labtop, Mobile = p.Mobile, ParrentID = p.ParrentID}));
        }

        // GET: api/AgahiBrandMobileCopmuters/5
        [ResponseType(typeof(tblAgahiBrandMobileCopmuter))]
        public IHttpActionResult GettblAgahiBrandMobileCopmuter(int id)
        {
            var tblAgahiBrandMobileCopmuter = db.tblAgahiBrandMobileCopmuter.Where(i=> i.BrandID == id).Select(p => new { AllinOne = p.AllinOne, BrandID = p.BrandID, BrandName = p.BrandName, Computer = p.Computer, Labtop = p.Labtop, Mobile = p.Mobile, ParrentID = p.ParrentID }).ToList();
            if (tblAgahiBrandMobileCopmuter == null)
            {
                return NotFound();
            }
            return Json(tblAgahiBrandMobileCopmuter);
        }

        // PUT: api/AgahiBrandMobileCopmuters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiBrandMobileCopmuter(int id, tblAgahiBrandMobileCopmuter tblAgahiBrandMobileCopmuter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiBrandMobileCopmuter.BrandID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiBrandMobileCopmuter).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiBrandMobileCopmuterExists(id))
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

        // POST: api/AgahiBrandMobileCopmuters
        [ResponseType(typeof(tblAgahiBrandMobileCopmuter))]
        public IHttpActionResult PosttblAgahiBrandMobileCopmuter(tblAgahiBrandMobileCopmuter tblAgahiBrandMobileCopmuter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiBrandMobileCopmuter.Add(tblAgahiBrandMobileCopmuter);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiBrandMobileCopmuter.BrandID }, tblAgahiBrandMobileCopmuter);
        }

        // DELETE: api/AgahiBrandMobileCopmuters/5
        [ResponseType(typeof(tblAgahiBrandMobileCopmuter))]
        public IHttpActionResult DeletetblAgahiBrandMobileCopmuter(int id)
        {
            tblAgahiBrandMobileCopmuter tblAgahiBrandMobileCopmuter = db.tblAgahiBrandMobileCopmuter.Find(id);
            if (tblAgahiBrandMobileCopmuter == null)
            {
                return NotFound();
            }

            db.tblAgahiBrandMobileCopmuter.Remove(tblAgahiBrandMobileCopmuter);
            db.SaveChanges();

            return Ok(tblAgahiBrandMobileCopmuter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiBrandMobileCopmuterExists(int id)
        {
            return db.tblAgahiBrandMobileCopmuter.Count(e => e.BrandID == id) > 0;
        }
    }
}