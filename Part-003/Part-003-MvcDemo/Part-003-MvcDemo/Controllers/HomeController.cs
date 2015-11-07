using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_003_MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            /*
             * If you are not able to create vertual directory, or it is showing warning then try this.
             * Go to the visual studio command line tools as an administrator
             * run the command:- aspnet_regiis -i
             * URL: http://stackoverflow.com/questions/5836228/asp-net-4-0-has-not-been-registered
             */
            return "Hello from MVC application.";
        }

        public String GetDetails ()
        {
            return "GetDetails() function is called.";
        }
    }
}
