using SAMS.DAL;
using SAMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SAMS.Controllers
{
    public class CourseUnitsController : Controller
    {

        private SchoolContext db = new SchoolContext();

        // GET: CourseUnits
        public ActionResult Index()
        {
            return View(db.CourseUnits.ToList());
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([Bind(Include ="Id,Title,Credits")]  CourseUnit courseUnit)
        {
            if (ModelState.IsValid)
            {
                db.CourseUnits.Add(courseUnit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseUnit);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CourseUnit courseUnit = db.CourseUnits.Find(id);

            if (courseUnit == null)
            {
                return HttpNotFound();
            }

            return View(courseUnit);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CourseUnit courseUnit = db.CourseUnits.Find(id);

            if (courseUnit == null)
            {
                return HttpNotFound();
            }
            return View(courseUnit);
        }

        [HttpPost]
        public ActionResult Edit( [Bind(Include = "Id,Title,Credits")] CourseUnit courseUnit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseUnit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseUnit);
        }
    }
}