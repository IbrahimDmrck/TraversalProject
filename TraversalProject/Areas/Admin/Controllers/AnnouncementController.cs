using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();

            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.ID = item.AnnouncementID;
                announcementListViewModel.Title = item.Tİtle;
                announcementListViewModel.Content = item.Content;

                model.Add(announcementListViewModel);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
