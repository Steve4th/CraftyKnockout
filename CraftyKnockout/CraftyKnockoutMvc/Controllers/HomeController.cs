using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class HomeController : Controller
    {
        const string ApplicationAbstract = "A look into crafting web application with KnockoutJS and ASP.NET MVC. Discussing what knockout brings to the toolbox and when to use it.";

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Abstract = ApplicationAbstract;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Crafty Knockout";
            ViewBag.Message = "Crafty Knockout is an ASP.NET application created to facilitate a presentation about KnockuutJS";
            ViewBag.Abstract = ApplicationAbstract;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "This presentation application has been created by Steve Forth";

            return View();
        }
    }
}