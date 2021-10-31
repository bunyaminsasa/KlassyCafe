using KlassyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.ViewModels
{
    public class HomeVM
    {
        public List<Product> Product { get; set; }
        public Reservation Reservation { get; set; }
    }
}
