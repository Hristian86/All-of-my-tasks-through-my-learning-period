using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_DICT_EX_ORDERS
{
    class Program
    {
        static void Main(string[] args)
        {
            var productDict = new Dictionary<string, List<Prices>>();
            while (true)
            {
                string[] products = Console.ReadLine().Split(" ").ToArray();
                string product = products[0];
                if (product == "buy")
                {
                    break;
                }
                double price = double.Parse(products[1]);
                double quantity = int.Parse(products[2]);
                if (!productDict.ContainsKey(product))
                {
                    productDict[product] = new List<Prices>();
                }
                var currentPrices = new Prices(price, quantity);
                productDict[product].Add(currentPrices);
            }
            double prise = 0;
            double quanty = 0;
            double sums = 0;
            foreach (var item in productDict)
            {
                foreach (var items in item.Value)
                {
                    prise = items.Price;
                    quanty += items.Quantity;
                }
                sums = prise * quanty;
                Console.WriteLine($"{item.Key} -> {sums:f2}");
                quanty = 0;
            }
        }
    }
    public class Prices
    {
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Prices(double price,double quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}