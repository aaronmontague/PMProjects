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
    public class PartAResourcesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PartAResources
        public ActionResult Index()
        {
            var partAResources = db.PartAResources.Include(p => p.PartA);
            return View(partAResources.ToList());
        }

        // GET: PartAResources/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAResource partAResource = db.PartAResources.Find(id);
            if (partAResource == null)
            {
                return HttpNotFound();
            }
            return View(partAResource);
        }

        // GET: PartAResources/Create
        public ActionResult Create()
        {
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle");
            return View();
        }

        // POST: PartAResources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PartAResourceID,PartAID,ResourceName,InitialCost,RecurringCost,FundingSource")] PartAResource partAResource)
        {
            if (ModelState.IsValid)
            {
                db.PartAResources.Add(partAResource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAResource.PartAID);
            return View(partAResource);
        }

        // GET: PartAResources/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAResource partAResource = db.PartAResources.Find(id);
            if (partAResource == null)
            {
                return HttpNotFound();
            }
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAResource.PartAID);
            return View(partAResource);
        }

        // POST: PartAResources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartAResourceID,PartAID,ResourceName,InitialCost,RecurringCost,FundingSource")] PartAResource partAResource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partAResource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PartAID = new SelectList(db.PartAs, "PartAID", "ProposalTitle", partAResource.PartAID);
            return View(partAResource);
        }

        // GET: PartAResources/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartAResource partAResource = db.PartAResources.Find(id);
            if (partAResource == null)
            {
                return HttpNotFound();
            }
            return View(partAResource);
        }

        // POST: PartAResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartAResource partAResource = db.PartAResources.Find(id);
            db.PartAResources.Remove(partAResource);
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
