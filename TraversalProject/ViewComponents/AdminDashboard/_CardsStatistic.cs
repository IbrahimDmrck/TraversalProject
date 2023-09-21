using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _CardsStatistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.Tours = context.Destinations.Count();
            ViewBag.Users = context.Users.Count();
            return View();
        }
    }
}
