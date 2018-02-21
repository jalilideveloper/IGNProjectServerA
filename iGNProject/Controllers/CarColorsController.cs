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
    public class CarColorsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarColors
        public IHttpActionResult GettblCarColors()
        {
            return Json(db.tblCarColors.Select(p=> new tblCarColors {CarColorID  = p.CarColorID,ColorName = p.ColorName }).ToList());
        }

        // GET: api/CarColors/5
        [ResponseType(typeof(tblCarColors))]
        public IHttpActionResult GettblCarColors(int id)
        {
            tblCarColors tblCarColors = db.tblCarColors.Where(p=> p.CarColorID == id).FirstOrDefault();
            if (tblCarColors == null)
            {
                return NotFound();
            }

            return Json(tblCarColors);
        }

        // PUT: api/tblCarColors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarColors(int id, tblCarColors tblCarColors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarColors.CarColorID)
            {
                return BadRequest();
            }

            db.Entry(tblCarColors).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarColorsExists(id))
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

        // POST: api/tblCarColors
        [ResponseType(typeof(tblCarColors))]
        public IHttpActionResult PosttblCarColors(tblCarColors tblCarColors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarColors.Add(tblCarColors);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarColors.CarColorID }, tblCarColors);
        }

        // DELETE: api/tblCarColors/5
        [ResponseType(typeof(tblCarColors))]
        public IHttpActionResult DeletetblCarColors(int id)
        {
            tblCarColors tblCarColors = db.tblCarColors.Find(id);
            if (tblCarColors == null)
            {
                return NotFound();
            }

            db.tblCarColors.Remove(tblCarColors);
            db.SaveChanges();

            return Ok(tblCarColors);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarColorsExists(int id)
        {
            return db.tblCarColors.Count(e => e.CarColorID == id) > 0;
        }
    }
}