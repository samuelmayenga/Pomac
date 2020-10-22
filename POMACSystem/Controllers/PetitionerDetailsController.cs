using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POMACSystem.Models;
using Microsoft.AspNet.Identity;

namespace POMACSystem.Controllers
{
    public class PetitionerDetailsController : Controller
    {
        private PomacDBEntities1 db = new PomacDBEntities1();

        // GET: PetitionerDetails
        public ActionResult Index()
        {
            var petitionerDetails = db.PetitionerDetails.Include(p => p.AspNetUser).Include(p => p.County1).Include(p => p.DateKnown).Include(p => p.EducationLevel).Include(p => p.Gender1).Include(p => p.Location1).Include(p => p.MaritalStatu).Include(p => p.Nationality1).Include(p => p.NextOfKin1).Include(p => p.SubCounty1).Include(p => p.Sublocation1).Include(p => p.Tribe);
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
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName");
            ViewBag.DateOfBirthKnown = new SelectList(db.DateKnowns, "DateKnownID", "DateKnown1");
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation");
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName");
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName");
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital");
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country");
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation");
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName");
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName");
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName");
            return View();
        }


        // Json Call to get Subcounties 
        public ActionResult GetStates(string id)

        {
            return Content("success");

        }
        public JsonResult GetSubcountiesList(string id)

        {
            List<SelectListItem> subcounties = new List<SelectListItem>();
            var subcountiesList = this.Getsubcounties(Convert.ToInt32(id));
            // var subbc = db.SubCounties.Where(m => m.CountyId == id).ToList();

            var SubcountiesData = subcountiesList.Select(m => new SelectListItem()
            {
                Text = m.SubCountyName,
                Value = m.SubCountyId.ToString(),
            });
            return Json(SubcountiesData, JsonRequestBehavior.AllowGet);
        }
        // Get Subcounties from DB by county ID
        public IList<SubCounty> Getsubcounties(int CountryId)
        {
            PomacDBEntities1 db = new PomacDBEntities1();

            return db.SubCounties.Where(m => m.CountyId == CountryId).ToList();
        }

        public JsonResult GetLocationsList(string id)

        {
            List<SelectListItem> locations = new List<SelectListItem>();
            var locationsList = this.GetLocations(Convert.ToInt32(id));
            var LocationsData = locationsList.Select(m => new SelectListItem()
            {
                Text = m.LocationName,
                Value = m.LocationId.ToString(),
            });
            return Json(LocationsData, JsonRequestBehavior.AllowGet);
        }
        // Get Subcounties from DB by county ID
        public IList<Location> GetLocations(int SubCountyId)
        {
            PomacDBEntities1 db = new PomacDBEntities1();

            return db.Locations.Where(m => m.SubCountyId == SubCountyId).ToList();
        }

        public JsonResult GetSubLocationsList(string id)

        {
            List<SelectListItem> sublocations = new List<SelectListItem>();
            var sublocationsList = this.GetsubLocations(Convert.ToInt32(id));
            var subLocationsData = sublocationsList.Select(m => new SelectListItem()

            {
                Text = m.SubLocationName,
                Value = m.SubLocationId.ToString(),
            });
            return Json(subLocationsData, JsonRequestBehavior.AllowGet);
        }
        // Get Subcounties from DB by county ID
        public IList<Sublocation> GetsubLocations(int LocationId)
        {
            PomacDBEntities1 db = new PomacDBEntities1();

            return db.Sublocations.Where(m => m.LocationId == LocationId).ToList();
        }

        //Generate Petition Number
       
        public string GenPetitionNumber()
        {
            string firstpart = "POM/PET/";
            var time = DateTime.Now.Year;
            var incremental = getnumbers();
            var petitionnumber = "";
            if(incremental <10)
            {
                petitionnumber = firstpart + time + "/00" + incremental;
            }
            else if (incremental ==10 || incremental <100)
            {
                petitionnumber = firstpart + time + "/0" + incremental;
            }
            else
            {
                petitionnumber = firstpart + time + "/" + incremental;
            }
            return petitionnumber;
        }

        public int getnumbers()
        {
            int lastrecordid = db.PetitionerDetails.Max(i => i.PetitionerDetailId);
            var currentrecord = lastrecordid + 1;
            return currentrecord;
        }

       //static void getnumbers()

       // {
       //     PomacDBEntities1 db = new PomacDBEntities1();
       //     // Taking a string 
       //     string lastr = db.PetitionerDetails.ToList().Last().PetitionNumber;
       //     String[] spearator = { "/" };
       //     Int32 count = 2;

       //     // using the method 
       //     String[] strlist = lastr.Split(spearator, count,
       //            StringSplitOptions.RemoveEmptyEntries);

       //     foreach (String s in strlist)
       //     {
       //         Console.WriteLine(s);
       //     }
       // }
        // POST: PetitionerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PetitionerDetailId,PetitionerFirstName,PetionerMidName,PetitionerLastName,PetitionerAliasName,Gender,MaritalStatus,DateOfBirth,DateOfBirthKnown,Nationality,IdNumber,County,SubCounty,Location,SubLocation,Village,EthnicityId,Ocupation,LevelOfEducation,NearestChurch,NearestSchool,NearestMarket,HomeCheif,NextOfKin,NextOfKinContact,NextOfKinRelation,ContactPersonName,ContactPersonPhone,DateModified")] PetitionerDetail petitionerDetail)
        {
            if (ModelState.IsValid)
            {
                petitionerDetail.UserId = User.Identity.GetUserId();
                petitionerDetail.DateCreated = DateTime.Now;
                petitionerDetail.PetitionNumber = GenPetitionNumber();
                db.PetitionerDetails.Add(petitionerDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionerDetail.UserId);
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.DateOfBirthKnown = new SelectList(db.DateKnowns, "DateKnownID", "DateKnown1", petitionerDetail.DateOfBirthKnown);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
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
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.DateOfBirthKnown = new SelectList(db.DateKnowns, "DateKnownID", "DateKnown1", petitionerDetail.DateOfBirthKnown);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
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
            ViewBag.County = new SelectList(db.Counties, "CountyId", "CountyName", petitionerDetail.County);
            ViewBag.DateOfBirthKnown = new SelectList(db.DateKnowns, "DateKnownID", "DateKnown1", petitionerDetail.DateOfBirthKnown);
            ViewBag.LevelOfEducation = new SelectList(db.EducationLevels, "LevelOfEducationId", "LevelOfEducation", petitionerDetail.LevelOfEducation);
            ViewBag.Gender = new SelectList(db.Genders, "GenderId", "GenderName", petitionerDetail.Gender);
            ViewBag.Location = new SelectList(db.Locations, "LocationId", "LocationName", petitionerDetail.Location);
            ViewBag.MaritalStatus = new SelectList(db.MaritalStatus, "MaritalId", "Marital", petitionerDetail.MaritalStatus);
            ViewBag.Nationality = new SelectList(db.Nationalities, "NationalityId", "Country", petitionerDetail.Nationality);
            ViewBag.NextOfKin = new SelectList(db.NextOfKins, "NextOfKinID", "Relation", petitionerDetail.NextOfKin);
            ViewBag.SubCounty = new SelectList(db.SubCounties, "SubCountyId", "SubCountyName", petitionerDetail.SubCounty);
            ViewBag.SubLocation = new SelectList(db.Sublocations, "SubLocationId", "SubLocationName", petitionerDetail.SubLocation);
            ViewBag.EthnicityId = new SelectList(db.Tribes, "TribeId", "TribeName", petitionerDetail.EthnicityId);
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
