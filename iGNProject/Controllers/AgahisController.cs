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
    public class AgahisController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/Agahis
        public IHttpActionResult GettblAgahi()
        {
            return Json(db.tblAgahi.Select(o=>  new  {o.AdminAgreeDate,o.AdminUserID,o.AgahiID,o.AgahiServiceID,o.AgahiStatus, o.AgahiTitle,o.CategoryAgahiID,o.Chatable,o.RegionID,o.Description,o.HasImage,o.Keyword,o.LanguageID,o.Location,o.Mobile,o.NewOrUsed,o.PlanShowAgahiID,o.Price,o.PriceTypeID,o.ProvinceID,o.RegisterDate,o.Tell,o.UserID,o.OnTime }));
        }

        // GET: api/Agahis/5
        [ResponseType(typeof(tblAgahi))]
        public IHttpActionResult GettblAgahi(int id)
        {
            tblAgahi tblAgahi = db.tblAgahi.Find(id);
            if (tblAgahi == null)
            {
                return NotFound();
            }

            return Json(tblAgahi);
        }

        // PUT: api/Agahis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahi(int id, tblAgahi tblAgahi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahi.AgahiID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiExists(id))
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

        // POST: api/Agahis
        [ResponseType(typeof(tblAgahi))]
        public IHttpActionResult PosttblAgahi(tblAgahi tblAgahi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahi.Add(tblAgahi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahi.AgahiID }, tblAgahi);
        }

        // DELETE: api/Agahis/5
        [ResponseType(typeof(tblAgahi))]
        public IHttpActionResult DeletetblAgahi(int id)
        {
            tblAgahi tblAgahi = db.tblAgahi.Find(id);
            if (tblAgahi == null)
            {
                return NotFound();
            }

            db.tblAgahi.Remove(tblAgahi);
            db.SaveChanges();

            return Json(tblAgahi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiExists(int id)
        {
            return db.tblAgahi.Count(e => e.AgahiID == id) > 0;
        }
    }
}