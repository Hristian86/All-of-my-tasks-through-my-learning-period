using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace zada4a_3_REGEX_EXER
{
    class Program
    {
        static void Main(string[] args)
        {
            BigEnginre();
        }
        static void BigEnginre()
        {

            string patr1 = @"%(?<name>[A-Z][a-z]+)%<(?<type>[A-Z][a-z]+)>(\w+|\|)(?<count>[0-9]+)\|(?<curPrice>[0-9]+\.?[0-9])\$";
            string patr2 = @"%(?<name>[A-Z][a-z]+)%<(?<type>[A-Z][a-z]+)>\w+\|(?<count>\d+)\|(([a-z]+)(?<curPrice>[0-9]+))\$";
            var dict = new Dictionary<string, Items>();

            //double totalPrice = 0;

            while (true)
            {

                string text = Console.ReadLine().Trim('^');
                if (text == "end of shift")
                {
                    break;
                }

                MatchCollection match1 = Regex.Matches(text, patr1);
                MatchCollection match2 = Regex.Matches(text, patr2);

                if (match2 != null)
                {
                    dict = Engine(match2, dict);
                }
                if (match1 != null)
                {
                    dict = Engine(match1, dict);
                }
            }
            Display(dict);
        }
        static void Display(Dictionary<string,Items> dict)
        {
            double finish = 0;
            foreach (var item in dict)
            {
                var st = item.Value;
                Console.WriteLine($"{item.Key}: {st.Products} - {st.Quantity * st.Price:f2}");
                finish += st.Quantity * st.Price;
            }
            Console.WriteLine($"Total income: {finish:f2}");
        }
        static Dictionary<string,Items> Engine(MatchCollection match2, Dictionary<string,Items> dict)
        {
            foreach (Match item in match2)
            {
               var name = item.Groups["name"].Value;
               var type = item.Groups["type"].Value;
               double count = double.Parse(item.Groups["count"].Value);
               double curPrice = double.Parse(item.Groups["curPrice"].Value);
                if (dict.ContainsKey(name))
                {
                    dict[name].Edit(count);
                    dict[name].EditPrice(curPrice);
                }
                else
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = new Items();
                    }
                    Items itm = new Items()
                    {
                        Products = type,
                        Quantity = count,
                        Price = curPrice
                    };
                    dict[name] = itm;
                }
            }
            return dict;
        }
    }
    public class Items  
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Products { get; set; }
        public double Edit(double quantity)
        {
            this.Quantity += quantity;
            return this.Quantity;
        }
        public double EditPrice(double price)
        {
            this.Price += price;
            return this.Price;
        }
    }
}