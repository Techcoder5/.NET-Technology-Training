using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_APPLICATION_CONTROLLERS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public string Index()
        {
            return "Welcome to New MVC Controller";
        }
        public string share_feedback(int id)
        {
            return "Share your Feedback"+ id;
        }
    }
}