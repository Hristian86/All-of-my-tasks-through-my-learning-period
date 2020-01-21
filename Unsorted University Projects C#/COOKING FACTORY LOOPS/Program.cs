using System;

namespace COOKING_FACTORY_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numberses = num;
            int i = 1;
            int counter = 0;
            while (numberses > 0)
            {
                if (counter == num)
                {
                    break;
                }
                bool ingridEggs = false;
                bool ingridSugar = false;
                bool ingridFlour = false;
                //string ingrid = "";
                while (true)
                {
                    if (counter == num)
                    {
                        break;
                    }        
                    string ingrid = Console.ReadLine();
                    if (ingrid == "eggs")
                    {
                        ingridEggs = true;
                    }
                    else if (ingrid == "flour")
                    {
                        ingridFlour = true;
                    }
                    else if (ingrid == "sugar")
                    {
                        ingridSugar = true;
                    }
                    else if (ingrid == "Bake!")
                    {
                        if (ingridEggs && ingridFlour && ingridSugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            i++;
                            counter++;
                            ingridEggs = false;
                            ingridFlour = false;
                            ingridSugar = false;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            numberses--;
                        }
                    }
                }    
            }            
        }
    }
}
