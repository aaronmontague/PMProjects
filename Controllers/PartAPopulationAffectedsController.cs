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
    public class PartAPopulationAffectedsController : Controller
    {
        //set values for the High/Med/Low/None dropdown from DropDowns.cs
        DropDownHighMediumLowNone HMLN = new DropDownHighMediumLowNone();

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PartAPopulationAffecteds
        public ActionResult Index()
        {
            var partAPopulationAffecteds = db.PartAPopulationAffecteds.Include(p => p.PartA);
            return View(partAPopulationAffecteds.ToList());
        }

        // GET: PartAPopulationAffecteds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAPopulationAffected partAPopulationAffected = db.PartAPopulationAffecteds.Find(id);
            if (partAPopulationAffected == null)
            {
                return HttpNotFound();
            }
            return View(partAPopulationAffected);
        }

        // GET: PartAPopulationAffecteds/Create
        public ActionResult Create()
        {
            ViewBag.dropDownList = new SelectList(HMLN.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle");
            return View();
        }

        // POST: PartAPopulationAffecteds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PartAPopulationAffectedID,PartAID,PopulationName,SpecificImpact,ImpactLevel")] PartAPopulationAffected partAPopulationAffected)
        {
            if (ModelState.IsValid)
            {
                db.PartAPopulationAffecteds.Add(partAPopulationAffected);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dropDownList = new SelectList(HMLN.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAPopulationAffected.PartAID);
            return View(partAPopulationAffected);
        }

        // GET: PartAPopulationAffecteds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAPopulationAffected partAPopulationAffected = db.PartAPopulationAffecteds.Find(id);
            if (partAPopulationAffected == null)
            {
                return HttpNotFound();
            }
            ViewBag.dropDownList = new SelectList(HMLN.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAPopulationAffected.PartAID);
            return View(partAPopulationAffected);
        }

        // POST: PartAPopulationAffecteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartAPopulationAffectedID,PartAID,PopulationName,SpecificImpact,ImpactLevel")] PartAPopulationAffected partAPopulationAffected)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partAPopulationAffected).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dropDownList = new SelectList(HMLN.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAPopulationAffected.PartAID);
            return View(partAPopulationAffected);
        }

        // GET: PartAPopulationAffecteds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAPopulationAffected partAPopulationAffected = db.PartAPopulationAffecteds.Find(id);
            if (partAPopulationAffected == null)
            {
                return HttpNotFound();
            }
            return View(partAPopulationAffected);
        }

        // POST: PartAPopulationAffecteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartAPopulationAffected partAPopulationAffected = db.PartAPopulationAffecteds.Find(id);
            db.PartAPopulationAffecteds.Remove(partAPopulationAffected);
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
