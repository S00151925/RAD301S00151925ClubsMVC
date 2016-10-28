using System.Web;
using System.Web.Mvc;

namespace RAD301S00151925Clubs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
