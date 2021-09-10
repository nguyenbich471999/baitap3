using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap3.Models;

namespace baitap3.Controllers
{
    public class StudentController : Controller
    {
        LapTrinhQuanLyDbcontext db = new LapTrinhQuanLyDbcontext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList()''
            return View(Modol)
        }
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }

}