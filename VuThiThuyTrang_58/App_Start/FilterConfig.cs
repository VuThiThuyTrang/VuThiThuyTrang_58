using System.Web;
using System.Web.Mvc;

namespace VuThiThuyTrang_58
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
