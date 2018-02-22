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
using System.Web.Script.Serialization;

namespace iGNProject.Controllers
{
    public class UsersController : ApiController
    {
        private DBEWDiGNEntities db = new DBEWDiGNEntities();

        // GET: api/Users
        public IQueryable<tblUsers> GettblUsers()
        {
            return db.tblUsers;
        }

        // GET: api/Users/5
        [ResponseType(typeof(tblUsers))]
        public string GetUsers(string id)
        {
            string[] arr = id.Split('-');
            tblUsers tblUsers = db.CheckUserPass(arr[0],arr[1]).Select(p=> new tblUsers {UserName = p.UserName,Password = p.Password,UserID = p.UserID ,Address = p.Address, BirthDate = p.BirthDate,BussinessFieldID = p.BussinessFieldID,Email = p.Email, FirstName = p.FirstName,IsDeleted = p.IsDeleted,LanguageID = p.LanguageID,Lastname = p.Lastname,LocationID = p.LocationID,Mobile = p.Mobile,NationalityID = p.NationalityID,NickName = p.NickName,PostalCode = p.PostalCode,RegisterDate = p.RegisterDate,SecondryPass = p.SecondryPass,UserLinkPage = p.UserLinkPage,UserTypeID= p.UserType,Tell = p.Tell,PersonelImageUrl = p.UserTypeIDelImageUrl}).FirstOrDefault();
            if (tblUsers == null)
            {
                return "No";
            }
            return new JavaScriptSerializer().Serialize(tblUsers); 
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblUsers(int id, tblUsers tblUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblUsers.UserID)
            {
                return BadRequest();
            }

            db.Entry(tblUsers).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblUsersExists(id))
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

        // POST: api/Users
        [ResponseType(typeof(tblUsers))]
        public IHttpActionResult PosttblUsers(tblUsers tblUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sp_Add_tblUsers(tblUsers.UserName, tblUsers.FirstName, tblUsers.Lastname, tblUsers.Email, tblUsers.Tell, tblUsers.Mobile, tblUsers.Address, tblUsers.Password, tblUsers.SecondryPass, tblUsers.UserLinkPage, tblUsers.PersonelImageUrl, DateTime.Now.Date.ToShortDateString(), tblUsers.NationalityID, tblUsers.PostalCode, tblUsers.BussinessFieldID, tblUsers.BirthDate, tblUsers.NickName, tblUsers.LanguageID, (byte)tblUsers.UserTypeID, tblUsers.LocationID, false);
            
            return CreatedAtRoute("DefaultApi", new { id = tblUsers.UserID }, tblUsers);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(tblUsers))]
        public IHttpActionResult DeletetblUsers(int id)
        {
            db.sp_DeltblUsers(id);
            return Ok(true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblUsersExists(int id)
        {
            return db.tblUsers.Count(e => e.UserID == id) > 0;
        }
    }
}