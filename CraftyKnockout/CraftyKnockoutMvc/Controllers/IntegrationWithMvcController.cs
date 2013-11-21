using System.Web.Helpers;
using CraftyKnockoutMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using CraftyKnockoutMvc.Attributes;
using CraftyKnockoutMvc.Repository;
using System.Diagnostics;
using System;

namespace CraftyKnockoutMvc.Controllers
{
    public class IntegrationWithMvcController : Controller
    {
        private readonly IRepository<FamousCoder> famousCoderRepository;

        public IntegrationWithMvcController(IRepository<FamousCoder> coderRepository)
        {
            famousCoderRepository = coderRepository;
            famousCoderRepository.SeedRepository();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Part II - Getting started with KnockoutJS";
            ViewBag.Message = "KnockoutJS can be a very useful way to extend the functionality of an MVC web application. In this part we will explore some basic techniques to integrate KnockoutJS within an MVC.";
            return View();
        }

        public ActionResult HallOfFame()
        {
            var model = new HallOfFameModel();

            var listOfFamousCoders = famousCoderRepository.GetAll().OrderBy(m => m.FameScore * -1);

            foreach (var coder in listOfFamousCoders)
            {
                model.FamousCoders.Add(coder);
            }

            return View(model);
        }


        public ActionResult HallOfFameAjax()
        {
            return View();
        }

        [HttpGet]
        public JsonResult HallOfFameAjaxModel()
        {

            //For illustration I want to slow the data return down a bit.
            System.Threading.Thread.Sleep(2000);


            var model = new HallOfFameModel();

            var listOfFamousCoders = famousCoderRepository.GetAll().OrderBy(m => m.FameScore * -1);

            foreach (var coder in listOfFamousCoders)
            {
                model.FamousCoders.Add(coder);
            }

            // Use Newtonsoft to encode the class as a JSON. 
            var jsonEncodedModel = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            //Return a JsonResult. You must included the behavior or else it does not get back to the client
            return Json(jsonEncodedModel, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult EditHallOfFame()
        {
            var listOfFamousCoders = famousCoderRepository.GetAll().AsEnumerable();

           return View(listOfFamousCoders);
        }


        [HttpPost]
        public ActionResult EditHallOfFame([FromJson] IList<FamousCoder> model)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model)
                {
                    Debug.WriteLine("CoderName: {0}; Famous For:{1}; Scored: {2}", item.CoderName, item.FamousFor, item.FameScore);
                }

                famousCoderRepository.UpdateToMatchList(model);
            }

            return RedirectToAction("EditHallOfFame");
        }

        [HttpGet]
        public ActionResult KnockoutIsland()
        {
            var model = new KnockoutIslandModel();
            model.Event = new Event();
            model.Event.Speakers = new List<FamousCoder>();
            model.PossibleSpeakers = famousCoderRepository.GetAll().AsEnumerable();

            return View(model);
        }

        [HttpPost]
        public ActionResult KnockoutIsland(KnockoutIslandModel model)
        {


            return View("EventView", model);
        }
	}
}