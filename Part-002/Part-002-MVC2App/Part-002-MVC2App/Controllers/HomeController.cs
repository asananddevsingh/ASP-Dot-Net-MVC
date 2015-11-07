using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_002_MVC2App.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public String Index()
        {
            return "<b>To know the version of MVC</b><br />Go to Project > References > System.Web.Mvc > Right click > Properties > Version. " + typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
