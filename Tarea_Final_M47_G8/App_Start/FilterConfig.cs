using System.Web;
using System.Web.Mvc;

namespace Tarea_Final_M47_G8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
