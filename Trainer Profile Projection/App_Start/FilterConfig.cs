using System.Web;
using System.Web.Mvc;

namespace Trainer_Profile_Projection
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
