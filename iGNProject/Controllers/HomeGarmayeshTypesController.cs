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
    public class HomeGarmayeshTypesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/HomeGarmayeshTypes
        public IHttpActionResult GettblHomeGarmayeshType()
        {
            return Json(db.tblHomeGarmayeshType.Select(p=> new { GarmayeshType = p.GarmayeshType, GarmayeshTypeID = p.GarmayeshTypeID }).ToList());
        }

        // GET: api/HomeGarmayeshTypes/5
        [ResponseType(typeof(tblHomeGarmayeshType))]
        public IHttpActionResult GettblHomeGarmayeshType(int id)
        {
            var tblHomeGarmayeshType = db.tblHomeGarmayeshType.Where(p=> p.GarmayeshTypeID==id).Select(p => new { GarmayeshType = p.GarmayeshType, GarmayeshTypeID = p.GarmayeshTypeID }).ToList();
            if (tblHomeGarmayeshType == null)
            {
                return NotFound();
            }

            return Json(tblHomeGarmayeshType);
        }

        // PUT: api/HomeGarmayeshTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblHomeGarmayeshType(int id, tblHomeGarmayeshType tblHomeGarmayeshType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblHomeGarmayeshType.GarmayeshTypeID)
            {
                return BadRequest();
            }

            db.Entry(tblHomeGarmayeshType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblHomeGarmayeshTypeExists(id))
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

        // POST: api/HomeGarmayeshTypes
        [ResponseType(typeof(tblHomeGarmayeshType))]
        public IHttpActionResult PosttblHomeGarmayeshType(tblHomeGarmayeshType tblHomeGarmayeshType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblHomeGarmayeshType.Add(tblHomeGarmayeshType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblHomeGarmayeshType.GarmayeshTypeID }, tblHomeGarmayeshType);
        }

        // DELETE: api/HomeGarmayeshTypes/5
        [ResponseType(typeof(tblHomeGarmayeshType))]
        public IHttpActionResult DeletetblHomeGarmayeshType(int id)
        {
            tblHomeGarmayeshType tblHomeGarmayeshType = db.tblHomeGarmayeshType.Find(id);
            if (tblHomeGarmayeshType == null)
            {
                return NotFound();
            }

            db.tblHomeGarmayeshType.Remove(tblHomeGarmayeshType);
            db.SaveChanges();

            return Ok(tblHomeGarmayeshType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblHomeGarmayeshTypeExists(int id)
        {
            return db.tblHomeGarmayeshType.Count(e => e.GarmayeshTypeID == id) > 0;
        }
    }
}