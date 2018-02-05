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
    public class ProvincesController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/Provinces
        public IHttpActionResult GettblProvince()
        {
            return Json(db.tblProvince.ToList().Select(p=> new {p.ProvinceID,p.ProvinceName }));
        }

        // GET: api/Provinces/5
        [ResponseType(typeof(tblProvince))]
        public IHttpActionResult GettblProvince(int id)
        {
            tblProvince tblProvince = db.tblProvince.Find(id);
            if (tblProvince == null)
            {
                return NotFound();
            }

            return Json(tblProvince);
        }

     

     

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblProvinceExists(int id)
        {
            return db.tblProvince.Count(e => e.ProvinceID == id) > 0;
        }
    }
}