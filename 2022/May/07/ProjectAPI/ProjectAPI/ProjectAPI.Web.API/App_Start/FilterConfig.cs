using System.Web;
using System.Web.Http;

namespace ProjectAPI.Web.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpConfiguration config)
        {
            config.Filters.Add(new AuthorizeAttribute());
        }
    }
}
