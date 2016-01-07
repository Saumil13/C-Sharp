using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ProductB : IProduct
    {
        private static readonly ProductB ProductBInstance = new ProductB();

        private ProductB()
        {

        }

        public static ProductB GetProductAInstance()
        {
            return ProductBInstance;
        }

        public string GetProductName()
        {
            return "ProductB";
        }
    }
}
