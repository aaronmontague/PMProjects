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
    public class ProjectSizingWorksheetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ProjectSizingWorksheets
        public ActionResult Index()
        {
            var projectSizingWorksheets = db.ProjectSizingWorksheets.Include(p => p.Project);
            return View(projectSizingWorksheets.ToList());
        }

        // GET: ProjectSizingWorksheets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSizingWorksheet projectSizingWorksheet = db.ProjectSizingWorksheets.Find(id);
            if (projectSizingWorksheet == null)
            {
                return HttpNotFound();
            }
            return View(projectSizingWorksheet);
        }

        // GET: ProjectSizingWorksheets/Create
        public ActionResult Create()
        {
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName");
            return View();
        }

        // POST: ProjectSizingWorksheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectSizingWorksheetID,ProjectID,Question1Value,Question2Value,Question3Value,Question4Value,Question5Value,Question6Value,Question7Value,Question8Value,Question9Value,Question10Value")] ProjectSizingWorksheet projectSizingWorksheet)
        {
            if (ModelState.IsValid)
            {
                db.ProjectSizingWorksheets.Add(projectSizingWorksheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", projectSizingWorksheet.ProjectID);
            return View(projectSizingWorksheet);
        }

        // GET: ProjectSizingWorksheets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSizingWorksheet projectSizingWorksheet = db.ProjectSizingWorksheets.Find(id);
            if (projectSizingWorksheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", projectSizingWorksheet.ProjectID);
            return View(projectSizingWorksheet);
        }

        // POST: ProjectSizingWorksheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectSizingWorksheetID,ProjectID,Question1Value,Question2Value,Question3Value,Question4Value,Question5Value,Question6Value,Question7Value,Question8Value,Question9Value,Question10Value")] ProjectSizingWorksheet projectSizingWorksheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectSizingWorksheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "ProjectName", projectSizingWorksheet.ProjectID);
            return View(projectSizingWorksheet);
        }

        // GET: ProjectSizingWorksheets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectSizingWorksheet projectSizingWorksheet = db.ProjectSizingWorksheets.Find(id);
            if (projectSizingWorksheet == null)
            {
                return HttpNotFound();
            }
            return View(projectSizingWorksheet);
        }

        // POST: ProjectSizingWorksheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectSizingWorksheet projectSizingWorksheet = db.ProjectSizingWorksheets.Find(id);
            db.ProjectSizingWorksheets.Remove(projectSizingWorksheet);
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
