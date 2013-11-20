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

            var listOfFamousCoders = famousCoderRepository.GetAll();

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
            var model = new HallOfFameModel();

            var listOfFamousCoders = famousCoderRepository.GetAll();

            foreach (var coder in listOfFamousCoders)
            {
                model.FamousCoders.Add(coder);
            }

            //return model.JsonSerialize();
            var jsonEncodedModel = Newtonsoft.Json.JsonConvert.SerializeObject(model);

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