using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Handlers.DestinationHandlers;
using TraversalProject.CQRS.Queries.DestinationQuerys;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIDQueryJandler _getDestinationByIDQueryJandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetDestinationByIDQueryJandler getDestinationByIDQueryJandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getDestinationByIDQueryJandler = getDestinationByIDQueryJandler;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryJandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
    }
}
