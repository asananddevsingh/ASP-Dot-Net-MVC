using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_005_Views.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* This will print the type of the list insted of list of countries. ( return type of function should be List<String>) */
            //return new List<string> () 
            //{  
            //    "India", 
            //    "US",
            //    "UK",
            //    "Canada"
            //};

            ViewBag.Countries = new List<string>() 
            {  
                "India",
                "US",
                "UK",
                "Canada"
            };
            return View();
                 
        }

    }
}
