﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_W04_CodeFirst_Second_Edition_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
