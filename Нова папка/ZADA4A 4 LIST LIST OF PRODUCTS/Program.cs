using System;
using System.Linq;
using System.Collections.Generic;

namespace ZADA4A_4_LIST_LIST_OF_PRODUCTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //var products = Console.ReadLine().Split(" ").ToList();
            var products = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string inputProduct = Console.ReadLine();
                products.Add(inputProduct);
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
