using CraftyKnockoutMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

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

            var listOfFamousCoders = GetFamousCoders();

            foreach (var coder in listOfFamousCoders)
            {
                model.FamousCoders.Add(coder);
            }

            return View(model);
        }

        private static IList<FamousCoder> GetFamousCoders()
        {
            var returnList = new List<FamousCoder>()
            {
                new FamousCoder()
                {
                    CoderName = "Jon Skeet",
                    FameScore = 20,
                    FamousFor = "Stack overflow"
                },
                new FamousCoder()
                {
                    CoderName = "Douglas Crockford",
                    FameScore = 10,
                    FamousFor = "JavaScript"
                },
                new FamousCoder()
                   {
                       CoderName = "Scott Guthrie",
                       FameScore = 25,
                       FamousFor = "Red Shirt"
                   }
            };

            return returnList;
        }
	}
}