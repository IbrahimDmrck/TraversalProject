using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
            var value = featureManager.TGetList();
            return View();
        }
    }
}
