using System.Web;
using System.Web.Mvc;

namespace _50325_2_Kalinets
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
