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
    public class PartAApplicationAffectedsController : Controller
    {
        //set values for the High/Med/Low dropdown from DropDowns.cs
        DropDownHighMediumLow HML = new DropDownHighMediumLow();

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PartAApplicationAffecteds
        public ActionResult Index()
        {
            var partAApplicationAffecteds = db.PartAApplicationAffecteds.Include(p => p.PartA);
            return View(partAApplicationAffecteds.ToList());
        }

        // GET: PartAApplicationAffecteds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAApplicationAffected partAApplicationAffected = db.PartAApplicationAffecteds.Find(id);
            if (partAApplicationAffected == null)
            {
                return HttpNotFound();
            }
            return View(partAApplicationAffected);
        }

        // GET: PartAApplicationAffecteds/Create
        public ActionResult Create()
        {
            ViewBag.dropDownList = new SelectList(HML.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle");

            return View();
        }

        // POST: PartAApplicationAffecteds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PartAApplicationAffectedID,PartAID,ApplicationName,CertaintyOfAffect,ImpactOfAffect")] PartAApplicationAffected partAApplicationAffected)
        {
            if (ModelState.IsValid)
            {
                db.PartAApplicationAffecteds.Add(partAApplicationAffected);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dropDownList = new SelectList(HML.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAApplicationAffected.PartAID);
            return View(partAApplicationAffected);
        }

        // GET: PartAApplicationAffecteds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAApplicationAffected partAApplicationAffected = db.PartAApplicationAffecteds.Find(id);
            if (partAApplicationAffected == null)
            {
                return HttpNotFound();
            }

            ViewBag.dropDownList = new SelectList(HML.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAApplicationAffected.PartAID);
            return View(partAApplicationAffected);
        }

        // POST: PartAApplicationAffecteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartAApplicationAffectedID,PartAID,ApplicationName,CertaintyOfAffect,ImpactOfAffect")] PartAApplicationAffected partAApplicationAffected)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partAApplicationAffected).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dropDownList = new SelectList(HML.values);
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAApplicationAffected.PartAID);
            return View(partAApplicationAffected);
        }

        // GET: PartAApplicationAffecteds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAApplicationAffected partAApplicationAffected = db.PartAApplicationAffecteds.Find(id);
            if (partAApplicationAffected == null)
            {
                return HttpNotFound();
            }
            return View(partAApplicationAffected);
        }

        // POST: PartAApplicationAffecteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartAApplicationAffected partAApplicationAffected = db.PartAApplicationAffecteds.Find(id);
            db.PartAApplicationAffecteds.Remove(partAApplicationAffected);
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
