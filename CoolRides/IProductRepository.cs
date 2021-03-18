using CoolRides.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRides
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
;