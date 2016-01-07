using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ProductA : IProduct
    {
        private static  readonly  ProductA ProductAInstance = new ProductA();

        private ProductA()
        {

        }

        public static ProductA GetProductAInstance()
        {
            return ProductAInstance;
        }

        public string GetProductName()
        {
            return "ProductA";
        }
    }
}
