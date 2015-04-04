using System.Web.Mvc;

namespace MainApplication2.Areas.BlogApp
{
  public class BlogAppAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "BlogApp";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "BlogApp_default",
          "BlogApp/{controller}/{action}/{id}",
          new { action = "Index", id = UrlParameter.Optional },
          new string[] { "BlogApp.Controllers" }
      );
    }
  }
}
