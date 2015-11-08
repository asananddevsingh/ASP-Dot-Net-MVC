using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Part_007_Models.Models;

namespace Part_007_Models.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetDetails()
        {
            Employee employee = new Employee()
            {
                EmployeeID = 101,
                Name = "Anand Singh",
                Gender = "Male",
                City = "Alld"
            };
            return View(employee);
        }

    }
}
