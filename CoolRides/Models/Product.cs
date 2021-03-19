using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRides.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ReviewID { get; set; }
        public int Year { get; set; }
        public int TopSpdMPH { get; set; }
        public int Price { get; set; }


    }
}

