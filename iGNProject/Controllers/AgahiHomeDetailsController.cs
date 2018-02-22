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
    public class AgahiHomeDetailsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/AgahiHomeDetails
        public IHttpActionResult GettblAgahiHomeDetail()
        {
            return Json(db.tblAgahiHomeDetail.Select(o=> new { AgahiDetailHomeID = o.AgahiDetailHomeID , AgahiID = o.AgahiID, Alachigh = o.Alachigh, Asansor = o.Asansor,
                Badansazi = o.Badansazi, Balkon = o.Balkon, Barbikio = o.Barbikio, Chiler = o.Chiler, CodeMelk = o.CodeMelk, Estakhr = o.Estakhr, GarmayeshTypeID = o.GarmayeshTypeID,
                GharardadTypeID = o.GharardadTypeID, Hayat = o.Hayat, Jakozi=o.Jakozi, JeneskafID = o.JeneskafID, Khabmaster = o.Khabmaster, Labi = o.Labi, MablagheKole = o.MablagheKole,
                MablagheMahane = o.MablagheMahane, Mablaghevam = o.Mablaghevam, MelkTypeID = o.MelkTypeID, MohavateBaziKodak = o.MohavateBaziKodak,
                NSEWID = o.NSEWID, OtaghKhab = o.OtaghKhab, Parking = o.Parking, Roofgarden = o.Roofgarden, SaleSakht = o.SaleSakht, ServiceIrani = o.ServiceIrani, ServiceKhareji =o.ServiceKhareji,
                Sona = o.Sona, Tabaghe = o.Tabaghe, TakBarg = o.TakBarg, Vam = o.Vam, Varaseiye =o.Varaseiye, Zirbana =o.Zirbana, Zirzamin = o.Zirzamin}).ToList());
        }

        // GET: api/AgahiHomeDetails/5
        [ResponseType(typeof(tblAgahiHomeDetail))]
        public IHttpActionResult GettblAgahiHomeDetail(int id)
        {
            var tblAgahiHomeDetail = db.tblAgahiHomeDetail.Where(o=> o.AgahiDetailHomeID == id).Select(o => new {
                AgahiDetailHomeID = o.AgahiDetailHomeID,
                AgahiID = o.AgahiID,
                Alachigh = o.Alachigh,
                Asansor = o.Asansor,
                Badansazi = o.Badansazi,
                Balkon = o.Balkon,
                Barbikio = o.Barbikio,
                Chiler = o.Chiler,
                CodeMelk = o.CodeMelk,
                Estakhr = o.Estakhr,
                GarmayeshTypeID = o.GarmayeshTypeID,
                GharardadTypeID = o.GharardadTypeID,
                Hayat = o.Hayat,
                Jakozi = o.Jakozi,
                JeneskafID = o.JeneskafID,
                Khabmaster = o.Khabmaster,
                Labi = o.Labi,
                MablagheKole = o.MablagheKole,
                MablagheMahane = o.MablagheMahane,
                Mablaghevam = o.Mablaghevam,
                MelkTypeID = o.MelkTypeID,
                MohavateBaziKodak = o.MohavateBaziKodak,
                NSEWID = o.NSEWID,
                OtaghKhab = o.OtaghKhab,
                Parking = o.Parking,
                Roofgarden = o.Roofgarden,
                SaleSakht = o.SaleSakht,
                ServiceIrani = o.ServiceIrani,
                ServiceKhareji = o.ServiceKhareji,
                Sona = o.Sona,
                Tabaghe = o.Tabaghe,
                TakBarg = o.TakBarg,
                Vam = o.Vam,
                Varaseiye = o.Varaseiye,
                Zirbana = o.Zirbana,
                Zirzamin = o.Zirzamin
            }).ToList();
            if (tblAgahiHomeDetail == null)
            {
                return NotFound();
            }

            return Ok(tblAgahiHomeDetail);
        }

        // PUT: api/AgahiHomeDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblAgahiHomeDetail(int id, tblAgahiHomeDetail tblAgahiHomeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblAgahiHomeDetail.AgahiDetailHomeID)
            {
                return BadRequest();
            }

            db.Entry(tblAgahiHomeDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblAgahiHomeDetailExists(id))
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

        // POST: api/AgahiHomeDetails
        [ResponseType(typeof(tblAgahiHomeDetail))]
        public IHttpActionResult PosttblAgahiHomeDetail(tblAgahiHomeDetail tblAgahiHomeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblAgahiHomeDetail.Add(tblAgahiHomeDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblAgahiHomeDetail.AgahiDetailHomeID }, tblAgahiHomeDetail);
        }

        // DELETE: api/AgahiHomeDetails/5
        [ResponseType(typeof(tblAgahiHomeDetail))]
        public IHttpActionResult DeletetblAgahiHomeDetail(int id)
        {
            tblAgahiHomeDetail tblAgahiHomeDetail = db.tblAgahiHomeDetail.Find(id);
            if (tblAgahiHomeDetail == null)
            {
                return NotFound();
            }

            db.tblAgahiHomeDetail.Remove(tblAgahiHomeDetail);
            db.SaveChanges();

            return Ok(tblAgahiHomeDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblAgahiHomeDetailExists(int id)
        {
            return db.tblAgahiHomeDetail.Count(e => e.AgahiDetailHomeID == id) > 0;
        }
    }
}