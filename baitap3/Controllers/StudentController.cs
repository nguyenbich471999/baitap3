using baitap3.Models;
using System.Linq;
using System.Web.Mvc;

namespace baitap3.Controllers
{
    public class StudentController : Controller
    {
        LapTrinhQuanLyDbcontext db = new LapTrinhQuanLyDbcontext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
     
        }
    }

