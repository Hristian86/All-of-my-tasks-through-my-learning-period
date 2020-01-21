using System;

namespace Zada4a_1_IF_STATE_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine().ToLower();
            string outfit = "";
            string shoes = "";

            switch (timeOfTheDay)
            {
                case "morning":
                    if (degrees <=18 && degrees >= 10)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24 && degrees > 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    break;
                case "afternoon":
                    if (degrees <= 18 && degrees >= 10)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24 && degrees > 18)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    break;
                case "evening":
                    if (degrees <= 18 && degrees >= 10)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24 && degrees > 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    break;
            }
        }
    }
}
