using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentManager commentManager = new CommentManager(new EfCommentDal());
            var value = commentManager.TGetDestinationById(id);
            return View(value);
        }
    }
}
