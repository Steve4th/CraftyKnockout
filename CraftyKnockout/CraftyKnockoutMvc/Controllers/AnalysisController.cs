using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class AnalysisController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Part III - Why use KnockoutJS?";
            ViewBag.Message = "So what are the good bad and ugly parts of KnockoutJS?";

            return View();
        }


        public ActionResult Comparisons()
        {
            ViewBag.Title = "Part III - Alternatives to KnockoutJS?";
            ViewBag.Message = "As with all *JS libraries there are competitors this section will discuss some of these.";

            return View();
        }
	}
}