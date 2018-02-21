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
    public class BrandsController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/Brands
        public IHttpActionResult GettblBrands()
        {
            return Json(db.tblBrands.Select (p=> new tblBrands{BrandID = p.BrandID,BrandName = p.BrandName,ParrentID = p.ParrentID , BrandTypeID = p.BrandTypeID }).ToList());
        }

        // GET: api/Brands/5
        [ResponseType(typeof(tblBrands))]
        public IHttpActionResult GettblBrands(int id)
        {
            List<tblBrands> tblBrands = db.tblBrands.Where(p=> p.BrandTypeID == id).Select(p => new tblBrands{ BrandID = p.BrandID, BrandName = p.BrandName, ParrentID = p.ParrentID, BrandTypeID = p.BrandTypeID }).ToList();
            if (tblBrands == null)
            {
                return NotFound();
            }
            return Json(tblBrands);
        }

        // PUT: api/Brands/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblBrands(int id, tblBrands tblBrands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblBrands.BrandID)
            {
                return BadRequest();
            }

            db.Entry(tblBrands).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblBrandsExists(id))
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

        // POST: api/Brands
        [ResponseType(typeof(tblBrands))]
        public IHttpActionResult PosttblBrands(tblBrands tblBrands)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblBrands.Add(tblBrands);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblBrands.BrandID }, tblBrands);
        }

        // DELETE: api/Brands/5
        [ResponseType(typeof(tblBrands))]
        public IHttpActionResult DeletetblBrands(int id)
        {
            tblBrands tblBrands = db.tblBrands.Find(id);
            if (tblBrands == null)
            {
                return NotFound();
            }

            db.tblBrands.Remove(tblBrands);
            db.SaveChanges();

            return Ok(tblBrands);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblBrandsExists(int id)
        {
            return db.tblBrands.Count(e => e.BrandID == id) > 0;
        }
    }
}