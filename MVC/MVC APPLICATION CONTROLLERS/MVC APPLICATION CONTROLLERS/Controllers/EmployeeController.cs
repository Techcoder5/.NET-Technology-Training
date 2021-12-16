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
        public string Index(int id)
        {
            if (id == 1)
            {
                return "Employee 1 Details";
            }
            else if (id == 2)
            {
                return "Employee 2 Details";
            }
            else
            {
                return "Employee 3 Details";
            }
            //return "Employee Details as follows";
        }
        //Passing two parameters via call by browser
        public string address(string dept,int id)
        {
            return "id = " + id + " dept = " + dept;
        }
        //creating Nullabe variable so that if we dont require it the program works fine even if we dont pass that variable via call by browser as a parameter
        /*public int phone_number(int id,int? phn=null)
        {
            return "id = " + id + " phone = " + Convert.ToInt32(phn);`
   
        }*/
    }
}