﻿using System.Web;
using System.Web.Mvc;

namespace _P_MVC_EF_Orr
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
