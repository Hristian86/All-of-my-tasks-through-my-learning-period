using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_7_CLASSES_STORE_BOXES
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Boxes>();
            while (true)
            {
                var elements = Console.ReadLine().Split(" ");
                if (elements[0] == "end")
                {
                    break;
                }
                int serialNumber = int.Parse(elements[0]);
                string item = elements[1];
                int quantity = int.Parse(elements[2]);
                double price = double.Parse(elements[3]);

                Boxes arenged = new Boxes()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    Quantity = quantity,
                    Price = price,
                    TotalPrice = quantity * price
                };
                boxes.Add(arenged);
            }
            var orderboxes = boxes.OrderByDescending(x => x.TotalPrice);
            foreach (var box in orderboxes)
            {
                double sum = box.Price;
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${box.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
    class Boxes
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
    }
}
