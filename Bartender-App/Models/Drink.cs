using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public class Drink
    {
        [Key]
        public int id { get; set; }
        public string drinkName { get; set; }
        public string drinkDescription { get; set; }
        public double drinkPrice { get; set; }
        public string drinkImage { get; set; }
    }
}
