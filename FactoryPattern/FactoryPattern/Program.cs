using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IProduct product = factory.GetProduct(1);
            Console.WriteLine("Product Instance: " + product.GetProductName());

            
            product = factory.GetProduct(2);
            Console.WriteLine("Product Instance: " + product.GetProductName());

            Console.ReadLine();

        }
    }
}
