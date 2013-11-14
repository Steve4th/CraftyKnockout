using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class AnalysisController : Controller
    {
        //
        // GET: /Analysis/
        public ActionResult Index()
        {
            ViewBag.Title = "Part III - Why use KnockoutJS?";
            ViewBag.Message = "As with all *JS libraries there are competitors, advantages and disadvantages; this section will discuss some of these.";

            return View();
        }
	}
}