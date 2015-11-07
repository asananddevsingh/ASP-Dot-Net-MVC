using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_004_MvcApp.Controllers
{
    public class HomeController : Controller
    {        
        public String Index(String id, String name)
        {
            // Using queristring
            //return "Hello from MVC App, id = <b>" + id + "</b>, Name = <b>" + Request.QueryString["name"] + "</b>";

            return "Hello from MVC App, id = <b>" + id + "</b>, Name = <b>" + name + "</b>";
        }

    }
}
