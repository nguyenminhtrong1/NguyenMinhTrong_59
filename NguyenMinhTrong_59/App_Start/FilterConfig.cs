using System.Web;
using System.Web.Mvc;

namespace NguyenMinhTrong_59
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
