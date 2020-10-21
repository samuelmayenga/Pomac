using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using POMACSystem.Models;

namespace POMACSystem.Controllers
{
    public class PetitionDetailsController : Controller
    {
        private PomacDBEntities db = new PomacDBEntities();

        // GET: PetitionDetails
        public ActionResult Index()
        {
            var petitionDetails = db.PetitionDetails.Include(p => p.AspNetUser).Include(p => p.Court).Include(p => p.PetitionerDetail).Include(p => p.Relief);
            return View(petitionDetails.ToList());
        }

        // GET: PetitionDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionDetail petitionDetail = db.PetitionDetails.Find(id);
            if (petitionDetail == null)
            {
                return HttpNotFound();
            }
            return View(petitionDetail);
        }

        // GET: PetitionDetails/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId");
            ViewBag.TrialCourt = new SelectList(db.Courts, "CourtId", "CourtName");
            ViewBag.PetitionerDetailsID = new SelectList(db.PetitionerDetails, "PetitionerDetailId", "UserId");
            ViewBag.ReliefsID = new SelectList(db.Reliefs, "ReliefID", "ReliefName");
            return View();
        }

        // POST: PetitionDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PetitionDetailsID,PetitionerDetailsID,CourtCaseNumber,DateOfConviction,DateOfOffence,PlaceOfOffence,DateOfArrest,DateOfRemand,EarliestPossibleDateOfDischarge,LatestPossibleDateOfDischarge,TrialCourt,CountsImplementation,Resentenced,ResentencingOutcome,PendingCourtMatter,PendingCourtMattersExplanation,ReliefsID,Skills,NatureParticularsCircumstancesOfOffence,PreviousPetitions,Trustee,DateOfTrusteePromotion,Achievement,Attributes,AreYouPrisoner,NameOfRepresentativeOrAdvocate,RelationshipWithConvict,TelephoneNumber,IDNumber,EmailAddress,DateModified")] PetitionDetail petitionDetail)
        {
            if (ModelState.IsValid)
            {
                db.PetitionDetails.Add(petitionDetail);
                petitionDetail.DateCreated = DateTime.Now;
                petitionDetail.UserId= User.Identity.GetUserId();
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionDetail.UserId);
            ViewBag.TrialCourt = new SelectList(db.Courts, "CourtId", "CourtName", petitionDetail.TrialCourt);
            ViewBag.PetitionerDetailsID = new SelectList(db.PetitionerDetails, "PetitionerDetailId", "UserId", petitionDetail.PetitionerDetailsID);
            ViewBag.ReliefsID = new SelectList(db.Reliefs, "ReliefID", "ReliefName", petitionDetail.ReliefsID);
            return View(petitionDetail);
        }

        // GET: PetitionDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionDetail petitionDetail = db.PetitionDetails.Find(id);
            if (petitionDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionDetail.UserId);
            ViewBag.TrialCourt = new SelectList(db.Courts, "CourtId", "CourtName", petitionDetail.TrialCourt);
            ViewBag.PetitionerDetailsID = new SelectList(db.PetitionerDetails, "PetitionerDetailId", "UserId", petitionDetail.PetitionerDetailsID);
            ViewBag.ReliefsID = new SelectList(db.Reliefs, "ReliefID", "ReliefName", petitionDetail.ReliefsID);
            return View(petitionDetail);
        }

        // POST: PetitionDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PetitionDetailsID,UserId,PetitionerDetailsID,CourtCaseNumber,DateOfConviction,DateOfOffence,PlaceOfOffence,DateOfArrest,DateOfRemand,EarliestPossibleDateOfDischarge,LatestPossibleDateOfDischarge,TrialCourt,CountsImplementation,Resentenced,ResentencingOutcome,PendingCourtMatter,PendingCourtMattersExplanation,ReliefsID,Skills,NatureParticularsCircumstancesOfOffence,PreviousPetitions,Trustee,DateOfTrusteePromotion,Achievement,Attributes,AreYouPrisoner,NameOfRepresentativeOrAdvocate,RelationshipWithConvict,TelephoneNumber,IDNumber,EmailAddress,DateCreated,DateModified")] PetitionDetail petitionDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petitionDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "RoleId", petitionDetail.UserId);
            ViewBag.TrialCourt = new SelectList(db.Courts, "CourtId", "CourtName", petitionDetail.TrialCourt);
            ViewBag.PetitionerDetailsID = new SelectList(db.PetitionerDetails, "PetitionerDetailId", "UserId", petitionDetail.PetitionerDetailsID);
            ViewBag.ReliefsID = new SelectList(db.Reliefs, "ReliefID", "ReliefName", petitionDetail.ReliefsID);
            return View(petitionDetail);
        }

        // GET: PetitionDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetitionDetail petitionDetail = db.PetitionDetails.Find(id);
            if (petitionDetail == null)
            {
                return HttpNotFound();
            }
            return View(petitionDetail);
        }

        // POST: PetitionDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetitionDetail petitionDetail = db.PetitionDetails.Find(id);
            db.PetitionDetails.Remove(petitionDetail);
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
