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
    public class AgahiCarDetailsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiCarDetails
        public IHttpActionResult GettblAgahiCarDetails()
        {
            return Json(db.tblAgahiCarDetails.Select(p=>  new { AgahiDetailCar = p.AgahiDetailCarID , AgahiID  =p.AgahiID, AirBagNumber = p.AirBagNumber, CarTipID = p.CarTipID, ChanMaheID = p.ChanMaheID,
                DandehNumber = p.DandehNumber, GirboxAuto = p.GirboxAuto, karkardDaghigh = p.karkardDaghigh, MablagheKole = p.MablagheKole, Mahane = p.Mahane, MotorHajmID = p.MotorHajmID,
                PishPardakht  = p.PishPardakht, RangeDakheliID = p.CarColorIDInside, RangeKharegiID = p.CarColorIDOutSide, Remote = p.Remote, RokeshTypeID = p.RokeshTypeID, SaleSakht = p.SaleSakht,
                SandaliBarghi = p.SandaliBarghi, SokhtID = p.SokhtID, SopapID = p.SopapID, SunRoof = p.SunRoof}).ToList());
        }

        // GET: api/AgahiCarDetails/5
        [ResponseType(typeof(tblAgahiCarDetails))]
        public IHttpActionResult GettblAgahiCarDetails(int id)
        {
            var tblAgahiCarDetails = db.tblAgahiCarDetails.Where(i=> i.AgahiDetailCarID == id).Select(p => new {
                AgahiDetailCar = p.AgahiDetailCarID,
                AgahiID = p.AgahiID,
                AirBagNumber = p.AirBagNumber,
                CarTipID = p.CarTipID,
                ChanMaheID = p.ChanMaheID,
                DandehNumber = p.DandehNumber,
                GirboxAuto = p.GirboxAuto,
                karkardDaghigh = p.karkardDaghigh,
                MablagheKole = p.MablagheKole,
                Mahane = p.Mahane,
                MotorHajmID = p.MotorHajmID,
                PishPardakht = p.PishPardakht,
                RangeDakheliID = p.CarColorIDInside,
                RangeKharegiID = p.CarColorIDOutSide,
                Remote = p.Remote,
                RokeshTypeID = p.RokeshTypeID,
                SaleSakht = p.SaleSakht,
                SandaliBarghi = p.SandaliBarghi,
                SokhtID = p.SokhtID,
                SopapID = p.SopapID,
                SunRoof = p.SunRoof
            }).ToList();
            if (tblAgahiCarDetails == null)
            {
                return NotFound();
            }

            return Json(tblAgahiCarDetails);
        }

        // PUT: api/AgahiCarDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiCarDetails(int id, tblAgahiCarDetails tblAgahiCarDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiCarDetails.AgahiDetailCarID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiCarDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiCarDetailsExists(id))
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

        // POST: api/AgahiCarDetails
        [ResponseType(typeof(tblAgahiCarDetails))]
        public IHttpActionResult PosttblAgahiCarDetails(tblAgahiCarDetails tblAgahiCarDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiCarDetails.Add(tblAgahiCarDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiCarDetails.AgahiDetailCarID }, tblAgahiCarDetails);
        }

        // DELETE: api/AgahiCarDetails/5
        [ResponseType(typeof(tblAgahiCarDetails))]
        public IHttpActionResult DeletetblAgahiCarDetails(int id)
        {
            tblAgahiCarDetails tblAgahiCarDetails = db.tblAgahiCarDetails.Find(id);
            if (tblAgahiCarDetails == null)
            {
                return NotFound();
            }

            db.tblAgahiCarDetails.Remove(tblAgahiCarDetails);
            db.SaveChanges();

            return Ok(tblAgahiCarDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiCarDetailsExists(int id)
        {
            return db.tblAgahiCarDetails.Count(e => e.AgahiDetailCarID == id) > 0;
        }
    }
}