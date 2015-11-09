using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Part_008_DataAccessByEntityFramework.Models;

namespace Part_008_DataAccessByEntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();
            return View(employees);
        }

        public ActionResult Details(int id = 1)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeID == id);
            return View(employee);
        }

    }
}
