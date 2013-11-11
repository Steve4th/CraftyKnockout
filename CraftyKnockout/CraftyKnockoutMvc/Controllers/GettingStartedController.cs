using System.Collections;
using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class GettingStartedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Part I - Getting started with KnockoutJS";
            ViewBag.Message = "An introduction to the KnockoutJS basics. A reminder for those familiar and an introduction for the uninitiated.";
            return View();
        }

        public ActionResult Resources()
        {
            return View();
        }

        public ActionResult HelloCraftyCoders()
        {
            return View();
        }

        public ActionResult Observable()
        {
            return View();
        }

        public ActionResult ObservableArray()
        {
            return View();
        }

        public ActionResult Computed()
        {
            return View();
        }
	}
}