using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Models;
using appProperty.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace appProperty.Controllers
{
    public class OfferContextController : Controller
    {
        private readonly IAdminContextRepository _adminContextRepository;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OfferContext()
        {
            ViewBag.Item= _adminContextRepository.GetOfferContextList();
            return View();
        }

        [HttpPost]
        public IActionResult OfferContext(OfferContextView OffeContextViewModel)
        {
            ViewBag.Item = _adminContextRepository.GetOfferContextList();
            var result = _adminContextRepository.AddOfferContext(OffeContextViewModel);
            ModelState.Clear();
            return View();
        }
    }

}
