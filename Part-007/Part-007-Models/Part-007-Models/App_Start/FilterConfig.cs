﻿using System.Web;
using System.Web.Mvc;

namespace Part_007_Models
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}