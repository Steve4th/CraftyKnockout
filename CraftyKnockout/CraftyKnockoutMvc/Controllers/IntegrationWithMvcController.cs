using CraftyKnockoutMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using CraftyKnockoutMvc.Attributes;
using System.Diagnostics;

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


        [HttpGet]
        public ActionResult EditHallOfFame()
        {
            var model = new EditHallOfFameModel();

            var listOfFamousCoders = GetFamousCoders();

            foreach (var coder in listOfFamousCoders)
            {
                model.FamousCoders.Add(coder);
            }

            return View(model);
        }


        [HttpPost]
        public ActionResult EditHallOfFame([FromJson] HallOfFameModel model)
        {
            if (ModelState.IsValid)
            {
                //you would save the model contents here....
                foreach (var item in model.FamousCoders)
                {
                    Debug.WriteLine("CoderName: {0}; Famous For:{1}; Scored: {2}", item.CoderName, item.FamousFor, item.FameScore);
                }
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