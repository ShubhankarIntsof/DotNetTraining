using System.Web;
using System.Web.Mvc;

namespace DEMO_LOGIN_IV_AC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
