using CraftyKnockoutMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class IntegrationWithMvcController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Part II - Getting started with KnockoutJS";
            ViewBag.Message = "KnockoutJS can be a very useful way to extend the functionality of an MVC web application. In this part we will explore some basic techniques to integrate KnockoutJS within an MVC.";
            return View();
        }

        public ActionResult HallOfFame()
        {
            var model = new HallOfFameModel();

            var coder = new FamousCoder()
            {
                CoderName = "Jon Skeet",
                FameScore = 20,
                FamousFor = "Stack overflow"
            };
            
            var coder2 = new FamousCoder()
            {
                CoderName = "Douglas Crockford",
                FameScore = 10,
                FamousFor = "JavaScript"
            };

            var coder3 = new FamousCoder()
            {
                CoderName = "Scott Guthrie",
                FameScore = 25,
                FamousFor = "Red Shirt"
            };

            model.FamousCoders.Add(coder);
            model.FamousCoders.Add(coder2);
            model.FamousCoders.Add(coder3);

            return View(model);
        }
	}
}