using System.Web.Mvc;

namespace MvcApplication1.Areas.Usage
{
    public class UsageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Usage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Usage_default",
                "Usage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
