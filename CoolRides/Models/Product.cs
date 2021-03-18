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

        public int ProductID {get; set;}
        public string Make {get; set;}
        public int Model {get; set;}
        public int ReviewID {get; set;}
        public int Year {get; set;}
        public int In60 {get; set;}
        public double Price {get; set;}


}
}
