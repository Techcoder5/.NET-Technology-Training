using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_Controller.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
        public string Index(string name)
        {
            string n = "";
            n = "Welcome to MVC " + name;
            return n;
        }
        public string full_name(string first_name,string last_name=null)
        {
            string full_name1;
            full_name1 = first_name +" " +last_name;
            //return full_name1;
            return full_name1;
        }
    }
}