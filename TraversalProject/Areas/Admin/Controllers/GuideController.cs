﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            ViewBag.TotalGuide = values.Count();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {

            _guideService.TAdd(guide);
            return RedirectToAction("Index","Guide");
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values=_guideService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {

            _guideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide");
        }

        public IActionResult ChangeToTrue(int id)
        {
            return RedirectToAction("Index", "Guide");
        }
        public IActionResult ChangeToFalse(int id)
        {
            return RedirectToAction("Index", "Guide");
        }
    }
}
