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
    public class AgahiCategoriesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiCategories
        public IHttpActionResult GettblAgahiCategories()
        {
            return Json(db.tblAgahiCategories.Select(p=> new {p.AgahiCategoryID,p.AgahiCategoryName,p.ParrentID,p.Priority }).ToList());
        }

        // GET: api/AgahiCategories/5
        [ResponseType(typeof(tblAgahiCategories))]
        public IHttpActionResult GettblAgahiCategories(int id)
        {
            tblAgahiCategories tblAgahiCategories = db.tblAgahiCategories.Find(id);
            if (tblAgahiCategories == null)
            {
                return NotFound();
            }

            return Json(tblAgahiCategories);
        }

        // PUT: api/AgahiCategories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiCategories(int id, tblAgahiCategories tblAgahiCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiCategories.AgahiCategoryID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiCategories).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiCategoriesExists(id))
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

        // POST: api/AgahiCategories
        [ResponseType(typeof(tblAgahiCategories))]
        public IHttpActionResult PosttblAgahiCategories(tblAgahiCategories tblAgahiCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiCategories.Add(tblAgahiCategories);
            db.SaveChanges();

            return Json(tblAgahiCategories);
        }

        // DELETE: api/AgahiCategories/5
        [ResponseType(typeof(tblAgahiCategories))]
        public IHttpActionResult DeletetblAgahiCategories(int id)
        {
            tblAgahiCategories tblAgahiCategories = db.tblAgahiCategories.Find(id);
            if (tblAgahiCategories == null)
            {
                return NotFound();
            }

            db.tblAgahiCategories.Remove(tblAgahiCategories);
            db.SaveChanges();

            return Ok(tblAgahiCategories);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiCategoriesExists(int id)
        {
            return db.tblAgahiCategories.Count(e => e.AgahiCategoryID == id) > 0;
        }
    }
}