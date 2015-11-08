using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_006_ViewDataAndViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["countries"] = new List<String>()
            {
                "India",
                "US",
                "Australia"
            };
            return View();
        }

    }
}
