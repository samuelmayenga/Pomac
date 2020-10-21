using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POMACSystem.Models;

namespace POMACSystem.Controllers
{
    public class PetitionerDetailsController : Controller
    {
        private PomacDBEntities db = new PomacDBEntities();

        // GET: PetitionerDetails
        public ActionResult Index()
        {
            var petitionerDetails = db.PetitionerDetails.Include(p => p.AspNetUser).Include(p => p.EducationLevel).Include(p => p.Gender1).Include(p => p.MaritalStatu).Include(p => p.Nationality1).Include(p => p.NextOfKin1).Include(p => p.Tribe).Include(p => p.County1).Include(p => p.Location1).Include(p => p.SubCounty1).Include(p => p.Sublocation1);
            return View(petitionerDetails.ToList());
        }

        // GET: PetitionerDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionerDetail petitionerDetail = db.PetitionerDetails.Find(id);
            if (petitionerDetail == null)
            {
                return HttpNotFound();
            }
            return View(petitionerDetail);
        }

        // GET: PetitionerDetails/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId");
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation");
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName");
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital");
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country");
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation");
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName");
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName");
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName");
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName");
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName");
            return View();
        }

        // POST: PetitionerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PetitionerDetailId,UserId,PetitionNumber,PetitionerFirstName,PetionerMidName,PetitionerLastName,PetitionerAliasName,Gender,MaritalStatus,DateOfBirth,DateOfBirthKnown,Nationality,IdNumber,County,SubCounty,Location,SubLocation,Village,EthnicityId,Ocupation,LevelOfEducation,NearestChurch,NearestSchool,NearestMarket,HomeCheif,NextOfKin,NextOfKinContact,NextOfKinRelation,ContactPersonName,ContactPersonPhone,DateCreated,DateModified")] PetitionerDetail petitionerDetail)
        {
            if (ModelState.IsValid)
            {
                db.PetitionerDetails.Add(petitionerDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionerDetail.UserId);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            return View(petitionerDetail);
        }

        // GET: PetitionerDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionerDetail petitionerDetail = db.PetitionerDetails.Find(id);
            if (petitionerDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionerDetail.UserId);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            return View(petitionerDetail);
        }

        // POST: PetitionerDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PetitionerDetailId,UserId,PetitionNumber,PetitionerFirstName,PetionerMidName,PetitionerLastName,PetitionerAliasName,Gender,MaritalStatus,DateOfBirth,DateOfBirthKnown,Nationality,IdNumber,County,SubCounty,Location,SubLocation,Village,EthnicityId,Ocupation,LevelOfEducation,NearestChurch,NearestSchool,NearestMarket,HomeCheif,NextOfKin,NextOfKinContact,NextOfKinRelation,ContactPersonName,ContactPersonPhone,DateCreated,DateModified")] PetitionerDetail petitionerDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petitionerDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionerDetail.UserId);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            return View(petitionerDetail);
        }

        // GET: PetitionerDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionerDetail petitionerDetail = db.PetitionerDetails.Find(id);
            if (petitionerDetail == null)
            {
                return HttpNotFound();
            }
            return View(petitionerDetail);
        }

        // POST: PetitionerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetitionerDetail petitionerDetail = db.PetitionerDetails.Find(id);
            db.PetitionerDetails.Remove(petitionerDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
