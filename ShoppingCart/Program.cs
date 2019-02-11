using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Enter the price of the 1st product");
            double firstProduct = double.Parse(Console.ReadLine());

            total += firstProduct;

            Console.WriteLine("Enter the price of the 2nd product");
            double secondProduct = double.Parse(Console.ReadLine());

            total += secondProduct;

            Console.WriteLine("Enter the price of the 3rd product");
            double thirdProduct = double.Parse(Console.ReadLine());

            total += thirdProduct;

            Console.WriteLine("Enter the price of the 4th product");
            double forthProduct = double.Parse(Console.ReadLine());

            total += forthProduct;

            Console.WriteLine("Enter the price of the 5th product");
            double fifthProduct = double.Parse(Console.ReadLine());

            total += fifthProduct;

            Console.WriteLine($"The total price for your purchase is {total}");
        }
    }
}
