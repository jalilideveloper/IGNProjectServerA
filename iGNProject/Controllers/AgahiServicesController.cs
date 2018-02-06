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
    public class AgahiServicesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiServices
        public IHttpActionResult GettblAgahiService()
        {
            return Json(db.tblAgahiService.Select(p=> new { AgahiServiceID = p.AgahiServiceID , AgahiServiceType = p.AgahiServiceType}).ToList());
        }

        // GET: api/AgahiServices/5
        [ResponseType(typeof(tblAgahiService))]
        public IHttpActionResult GettblAgahiService(int id)
        {
            var tblAgahiService = db.tblAgahiService.Where(p=> p.AgahiServiceID == id).Select(p => new { AgahiServiceID = p.AgahiServiceID, AgahiServiceType = p.AgahiServiceType }).ToList();
            if (tblAgahiService == null)
            {
                return NotFound();
            }

            return Json(tblAgahiService);
        }

        // PUT: api/AgahiServices/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiService(int id, tblAgahiService tblAgahiService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiService.AgahiServiceID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiService).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiServiceExists(id))
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

        // POST: api/AgahiServices
        [ResponseType(typeof(tblAgahiService))]
        public IHttpActionResult PosttblAgahiService(tblAgahiService tblAgahiService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiService.Add(tblAgahiService);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiService.AgahiServiceID }, tblAgahiService);
        }

        // DELETE: api/AgahiServices/5
        [ResponseType(typeof(tblAgahiService))]
        public IHttpActionResult DeletetblAgahiService(int id)
        {
            tblAgahiService tblAgahiService = db.tblAgahiService.Find(id);
            if (tblAgahiService == null)
            {
                return NotFound();
            }

            db.tblAgahiService.Remove(tblAgahiService);
            db.SaveChanges();

            return Ok(tblAgahiService);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiServiceExists(int id)
        {
            return db.tblAgahiService.Count(e => e.AgahiServiceID == id) > 0;
        }
    }
}