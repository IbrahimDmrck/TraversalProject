using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _Card2Statistics : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
