using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // return View();
            return RedirectToAction("ListAllCustomers", "Customer"); 
        }
        
        // GET: Customer ID
        public ActionResult CustomerNumber(string id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your temporary customer number is: " + id);
            return View();
        }

        // GET: Company Name
        public string Company(string name)
        {
            return HttpUtility.HtmlEncode("Your company name is " + name);

        }

        // Create List of Customers
        public string ListAllCustomers()
        {
            return @"<ul>
            <li>Sameul Dravis</li>
            <li>President Suzuki</li>    
            <li>MD 1032</li>
            <li>MD 1033</li>
            </ul>";

        }

    }
}