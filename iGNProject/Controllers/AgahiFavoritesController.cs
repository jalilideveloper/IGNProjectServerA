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
    public class AgahiFavoritesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiFavorites
        public IHttpActionResult GettblAgahiFavorite()
        {
            return Json(db.tblAgahiFavorite.Select(p=> new { AgahiID = p.AgahiID , FavoriteAgahiID = p.FavoriteAgahiID, IsDeteled = p.IsDeteled, UserID = p.UserID}).ToList());
        }

        // GET: api/AgahiFavorites/5
        [ResponseType(typeof(tblAgahiFavorite))]
        public IHttpActionResult GettblAgahiFavorite(int id)
        {
            var tblAgahiFavorite = db.tblAgahiFavorite.Where(o=> o.FavoriteAgahiID ==id ).Select(p => new { AgahiID = p.AgahiID, FavoriteAgahiID = p.FavoriteAgahiID, IsDeteled = p.IsDeteled, UserID = p.UserID });
            if (tblAgahiFavorite == null)
            {
                return NotFound();
            }
            return Json(tblAgahiFavorite);
        }

        // PUT: api/AgahiFavorites/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiFavorite(int id, tblAgahiFavorite tblAgahiFavorite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiFavorite.FavoriteAgahiID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiFavorite).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiFavoriteExists(id))
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

        // POST: api/AgahiFavorites
        [ResponseType(typeof(tblAgahiFavorite))]
        public IHttpActionResult PosttblAgahiFavorite(tblAgahiFavorite tblAgahiFavorite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiFavorite.Add(tblAgahiFavorite);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiFavorite.FavoriteAgahiID }, tblAgahiFavorite);
        }

        // DELETE: api/AgahiFavorites/5
        [ResponseType(typeof(tblAgahiFavorite))]
        public IHttpActionResult DeletetblAgahiFavorite(int id)
        {
            tblAgahiFavorite tblAgahiFavorite = db.tblAgahiFavorite.Find(id);
            if (tblAgahiFavorite == null)
            {
                return NotFound();
            }

            db.tblAgahiFavorite.Remove(tblAgahiFavorite);
            db.SaveChanges();

            return Ok(tblAgahiFavorite);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiFavoriteExists(int id)
        {
            return db.tblAgahiFavorite.Count(e => e.FavoriteAgahiID == id) > 0;
        }
    }
}