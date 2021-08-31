using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap3.Controllers
{
    public class GiaiphuongtrinhController : Controller
    {
        // GET: Giaiphuongtrinh
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string sothunhat,string sothuhai)
        {
            return View();

        }
        
    }

}