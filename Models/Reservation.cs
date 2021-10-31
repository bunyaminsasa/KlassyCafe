using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Models
{
    public class Reservation
    {
       
        public int ID { get; set; }
        [Required(ErrorMessage ="Ad Bilgisi Boş Geçilemez"), MinLength(10), MaxLength(50)]
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public int Quest { get; set; }
        public DateTime RecDate { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }

    }
}
