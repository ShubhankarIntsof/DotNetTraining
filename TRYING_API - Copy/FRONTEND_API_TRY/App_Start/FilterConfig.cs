﻿using System.Web;
using System.Web.Mvc;

namespace FRONTEND_API_TRY
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
