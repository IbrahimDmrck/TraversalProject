﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass{CityID=1,CityName="Üsküp",CityCountry="Makedonya"},
            new CityClass{CityID=2,CityName="Üsküp",CityCountry="Makedonya"},
            new CityClass{ CityID=3,CityName="Üsküp",CityCountry="Makedonya"},
            new CityClass{ CityID=4,CityName="Üsküp",CityCountry="Makedonya"},
        };
    }
}
