using KlassyCafe.Models;
using KlassyCafe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product{ID=1, Name="Çikolatalı Kek",Description="Ürünlerimiz güzeldir", Picture="1.jpg", Price=10 },
                new Product{ID=2, Name="Sucuklu Tost",Description="Ürünlerimiz iyidir", Picture="2.jpg", Price=20 },
                new Product{ID=3, Name="Kıyamlı Börek",Description="Ürünlerimiz kalitelidir", Picture="3.jpg", Price=30 },
                new Product{ID=4, Name="Patatesli Börek",Description="Ürünlerimiz tazedir", Picture="4.jpg", Price=40 },
                new Product{ID=5, Name="Kuru Fasulye",Description="Ürünlerimiz günlüktür", Picture="5.jpg", Price=50 },
                new Product{ID=6, Name="Dürüm Döner",Description="Ürünlerimiz ucuzdur", Picture="6.jpg", Price=60 },
                new Product{ID=7, Name="İçli Köfte",Description="Ürünlerimiz harikadır", Picture="7.jpg", Price=70 },
            };

            HomeVM homeVM = new HomeVM
            {
                Product = products,
                Reservation = new Reservation()
            };
            return View(homeVM);
        }

        [HttpPost]
        public IActionResult MakeReservation(HomeVM modelim)
        {
            return View();
        }

    }
}
