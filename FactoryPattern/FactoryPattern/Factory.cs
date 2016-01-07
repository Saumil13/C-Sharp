using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factory
    {
        public IProduct GetProduct(int productNumber)
        {
            if (productNumber == 1)
            {
                return ProductA.GetProductAInstance();
            }
            else
            {
                return ProductB.GetProductAInstance();
            }
        }
    }
}
