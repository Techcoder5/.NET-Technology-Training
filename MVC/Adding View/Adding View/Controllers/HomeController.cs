using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adding_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("~/View/Updated/Updated");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult without_view()
        {
            return View();
        }
    }
}