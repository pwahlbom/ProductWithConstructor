using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    public class Product {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description{get; set;}

        public Product(string name, decimal price, int unitsinstock)
        {
            Name = name;
            Price = price;
            UnitsInStock = unitsinstock;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myProduct1 = new Product("Phine", 195.99m, 24);
            myProduct1.Name = "Phone";

            var myProduct2 = new Product("Hammer", 19.99m, 16);
            myProduct2.Description = "22 oz";

            Console.WriteLine(string.Format("Product1 name: {0}\n price:{2}\n quantity:{3}\n description:{4}\n\n", myProduct1.Name, myProduct1.Price, myProduct1.UnitsInStock, myProduct1.Description));
            Console.WriteLine(string.Format("Product2 name: {0}\n price:{2}\n quantity:{3}\n description:{4}\n\n", myProduct2.Name, myProduct2.Price, myProduct2.UnitsInStock, myProduct2.Description));
            //Console.WriteLine(string.Format("Product2 descripting: {0}\n", myProduct2.Description));
            Console.ReadLine();
        }
    }
}
