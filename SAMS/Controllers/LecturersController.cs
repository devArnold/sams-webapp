using SAMS.DAL;
using SAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAMS.Controllers
{
    public class LecturersController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Lecturers
        public ActionResult Index()
        {
            return View();
        }
    }
}