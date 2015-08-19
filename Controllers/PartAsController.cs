using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMProjects.Models;

namespace PMProjects.Controllers
{
    public class PartAsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PartAs
        public ActionResult Index()
        {
            var partAs = db.PartAs.Include(p => p.Project).Include(p => p.Sponsor);
            return View(partAs.ToList());
        }

        // GET: PartAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartA partA = db.PartAs.Find(id);
            if (partA == null)
            {
                return HttpNotFound();
            }
            return View(partA);
        }

        // GET: PartAs/Create
        public ActionResult Create()
        {
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName");
            ViewBag.SponsorID = new SelectList(db.Sponsors, "SponsorID", "SponsorName");
            return View();
        }

        // POST: PartAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PartAID,ProjectID,ProposalTitle,ProposalNumber,SponsorID,PrimaryContact,DesiredDateComplete,SVPApproved,LongerThanTwoWeeks,ProjectOverview,BusinessCase,CoreInterfaces,BusinessRisks")] PartA partA)
        {
            if (ModelState.IsValid)
            {
                db.PartAs.Add(partA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", partA.ProjectID);
            ViewBag.SponsorID = new SelectList(db.Sponsors, "SponsorID", "SponsorName", partA.SponsorID);
            return View(partA);
        }

        // GET: PartAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartA partA = db.PartAs.Find(id);
            if (partA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", partA.ProjectID);
            ViewBag.SponsorID = new SelectList(db.Sponsors, "SponsorID", "SponsorName", partA.SponsorID);
            return View(partA);
        }

        // POST: PartAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartAID,ProjectID,ProposalTitle,ProposalNumber,SponsorID,PrimaryContact,DesiredDateComplete,SVPApproved,LongerThanTwoWeeks,ProjectOverview,BusinessCase,CoreInterfaces,BusinessRisks")] PartA partA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", partA.ProjectID);
            ViewBag.SponsorID = new SelectList(db.Sponsors, "SponsorID", "SponsorName", partA.SponsorID);
            return View(partA);
        }

        // GET: PartAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartA partA = db.PartAs.Find(id);
            if (partA == null)
            {
                return HttpNotFound();
            }
            return View(partA);
        }

        // POST: PartAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartA partA = db.PartAs.Find(id);
            db.PartAs.Remove(partA);
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
