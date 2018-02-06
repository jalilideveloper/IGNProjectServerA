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
    public class CarTipsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/CarTips
        public IHttpActionResult GettblCarTip()
        {
            return Json(db.tblCarTip.Select(p=> new { CarTipID = p.CarTipID, TipName = p.TipName }).ToList());
        }

        // GET: api/CarTips/5
        [ResponseType(typeof(tblCarTip))]
        public IHttpActionResult GettblCarTip(int id)
        {
            var tblCarTip = db.tblCarTip.Where(p=> p.CarTipID == id).Select(p => new { CarTipID = p.CarTipID, TipName = p.TipName }).ToList();
            if (tblCarTip == null)
            {
                return NotFound();
            }
            return Json(tblCarTip);
        }

        // PUT: api/CarTips/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCarTip(int id, tblCarTip tblCarTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCarTip.CarTipID)
            {
                return BadRequest();
            }

            db.Entry(tblCarTip).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarTipExists(id))
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

        // POST: api/CarTips
        [ResponseType(typeof(tblCarTip))]
        public IHttpActionResult PosttblCarTip(tblCarTip tblCarTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCarTip.Add(tblCarTip);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblCarTip.CarTipID }, tblCarTip);
        }

        // DELETE: api/CarTips/5
        [ResponseType(typeof(tblCarTip))]
        public IHttpActionResult DeletetblCarTip(int id)
        {
            tblCarTip tblCarTip = db.tblCarTip.Find(id);
            if (tblCarTip == null)
            {
                return NotFound();
            }

            db.tblCarTip.Remove(tblCarTip);
            db.SaveChanges();

            return Ok(tblCarTip);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCarTipExists(int id)
        {
            return db.tblCarTip.Count(e => e.CarTipID == id) > 0;
        }
    }
}