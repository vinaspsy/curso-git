using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> prod = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    prod.Add(new ImportedProduct(name, price, customsFee));

                }else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    prod.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    prod.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prods in prod) {
                Console.WriteLine(prods.PriceTag());
            }
            
        }
    }
}