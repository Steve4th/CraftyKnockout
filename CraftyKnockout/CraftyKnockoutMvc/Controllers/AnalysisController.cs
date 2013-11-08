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
            ViewBag.Title = "Part II - Getting started with KnockoutJS";
            ViewBag.Message = "KnockoutJS can be a very useful way to extend the functionality of an MVC web application. In this part we will explore some basic techniques to integrate KnockoutJS within an MVC.";

            return View();
        }
	}
}