using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Crafty Knockout";
            ViewBag.Message = "Crafty Knockout is an ASP.NET application created to facilite a presentation about KnockuutJS";
            ViewBag.Abstract = "A look into crafting web apps with KnockoutJS and ASP.NET MVC. Discussing what knockout brings to the toolbax and when to use it.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}