using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _AdminGuideList : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
