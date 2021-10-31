using KlassyCafe.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Social socials = new Social { Twitter = "https://twitter.com/infotechakademi", Facebook = "https://www.facebook.com/infotechakademi", Instagram = "https://www.instagram.com/infotechakademi/", Linkedin = "https://www.linkedin.com/company/infotechacademy/" };
            
            return View(socials);
        }
    }
}
