using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotRods.Models
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
        public int SpdN60 {get; set;}
        public int Price {get; set;}


}
}
