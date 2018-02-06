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
    public class AgahiMobCompDetailsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiMobCompDetails
        public IHttpActionResult GettblAgahiMobCompDetails()
        {
            return Json(db.tblAgahiMobCompDetails.Select(p=> new { AgahiID = p.AgahiID, AgahiMobCopID = p.AgahiMobCopID, AllinOne = p.AllinOne, AntiWater = p.AntiWater, BrandID  =p.BrandID,
                Cpu  = p.Cpu , DisplaySize = p.DisplaySize, Four4K = p.Four4K, Garanti = p.Garanti,Graphic = p.Graphic, JeansBadaneID = p.JeansBadaneID, LabTop = p.LabTop
                , LCD = p.LCD, LED = p.LED, Mobile = p.Mobile, Ram  = p.Ram, Touch = p.Touch, USB3 = p.USB3, Waranty = p.Waranty}).ToList());
        }

        // GET: api/AgahiMobCompDetails/5
        [ResponseType(typeof(tblAgahiMobCompDetails))]
        public IHttpActionResult GettblAgahiMobCompDetails(int id)
        {
            var tblAgahiMobCompDetails = db.tblAgahiMobCompDetails.Where(p=> p.AgahiMobCopID == id).Select(p => new {
                AgahiID = p.AgahiID,
                AgahiMobCopID = p.AgahiMobCopID,
                AllinOne = p.AllinOne,
                AntiWater = p.AntiWater,
                BrandID = p.BrandID,
                Cpu = p.Cpu,
                DisplaySize = p.DisplaySize,
                Four4K = p.Four4K,
                Garanti = p.Garanti,
                Graphic = p.Graphic,
                JeansBadaneID = p.JeansBadaneID,
                LabTop = p.LabTop
                ,
                LCD = p.LCD,
                LED = p.LED,
                Mobile = p.Mobile,
                Ram = p.Ram,
                Touch = p.Touch,
                USB3 = p.USB3,
                Waranty = p.Waranty
            }).ToList();

            if (tblAgahiMobCompDetails == null)
            {
                return NotFound();
            }

            return Json(tblAgahiMobCompDetails);
        }

        // PUT: api/AgahiMobCompDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiMobCompDetails(int id, tblAgahiMobCompDetails tblAgahiMobCompDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiMobCompDetails.AgahiMobCopID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiMobCompDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiMobCompDetailsExists(id))
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

        // POST: api/AgahiMobCompDetails
        [ResponseType(typeof(tblAgahiMobCompDetails))]
        public IHttpActionResult PosttblAgahiMobCompDetails(tblAgahiMobCompDetails tblAgahiMobCompDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiMobCompDetails.Add(tblAgahiMobCompDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiMobCompDetails.AgahiMobCopID }, tblAgahiMobCompDetails);
        }

        // DELETE: api/AgahiMobCompDetails/5
        [ResponseType(typeof(tblAgahiMobCompDetails))]
        public IHttpActionResult DeletetblAgahiMobCompDetails(int id)
        {
            tblAgahiMobCompDetails tblAgahiMobCompDetails = db.tblAgahiMobCompDetails.Find(id);
            if (tblAgahiMobCompDetails == null)
            {
                return NotFound();
            }

            db.tblAgahiMobCompDetails.Remove(tblAgahiMobCompDetails);
            db.SaveChanges();

            return Ok(tblAgahiMobCompDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiMobCompDetailsExists(int id)
        {
            return db.tblAgahiMobCompDetails.Count(e => e.AgahiMobCopID == id) > 0;
        }
    }
}