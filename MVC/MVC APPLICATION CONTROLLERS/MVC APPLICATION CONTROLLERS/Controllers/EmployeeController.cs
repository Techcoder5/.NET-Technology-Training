using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_APPLICATION_CONTROLLERS.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Index(int emp_id)
        {
            return "Employee Details as follows";
        }
    }
}