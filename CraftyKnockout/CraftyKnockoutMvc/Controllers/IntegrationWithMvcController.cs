﻿using CraftyKnockoutMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CraftyKnockoutMvc.Controllers
{
    public class IntegrationWithMvcController : Controller
    {
        //
        // GET: /IntegrationWithMvc/
        public ActionResult Index()
        {
            ViewBag.Title = "Part II - Getting started with KnockoutJS";
            ViewBag.Message = "KnockoutJS can be a very useful way to extend the functionality of an MVC web application. In this part we will explore some basic techniques to integrate KnockoutJS within an MVC.";
            return View();
        }

        public ActionResult HallOfFame()
        {
            var model = new List<FamousCoder>();

            model.Add(new FamousCoder() { CoderName = "Ian Russel", FameScore = 10, FamousFor = "Dependency Injection talks and doing stuff with F#" });

            return View(model);
        }
	}
}