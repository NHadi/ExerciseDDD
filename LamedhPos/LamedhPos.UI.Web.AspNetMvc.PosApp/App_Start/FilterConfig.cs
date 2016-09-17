using System.Web;
using System.Web.Mvc;

namespace LamedhPos.UI.Web.AspNetMvc.PosApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
