using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Controllers
{
    public class AboutController : Controller
    {
        [Route("/hakkimizda")]
        public IActionResult Index()
        {
            string[] ulkeler = {"tr", "abd", "rs", "fr", "ing", "çin", "yn" };
            ViewBag.ulkeler = ulkeler;
            return View();
        }
    }
}
