using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
           
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            }
           
            else
            {
                return View();
            }
            
        }

        // Confirmation Page
        [HttpPost]
        public ActionResult NewEmployee(string firstName, string lastName, string title)
        {
            ViewBag.Message = "Name: " + firstName + " " + lastName;
            ViewBag.Message += "   Title: " + title;

            return View("ConfirmEmployee");
        }

        // GET: New Employee Info
        public ActionResult NewEmployee()
        {
            return View("NewEmployeeForm");
        }
  
        // GET Employee Number
        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }

        // Create List of Customers
        public string ListAllCustomers()
        {
            return @"<ul>
            <li>Sameul Dravis</li>
            <li>President Suzuki</li>    
            <li>MD 1032</li>
            <li>MD 1033</li>
            </ul>"; ;

        }

        
        

    }
}