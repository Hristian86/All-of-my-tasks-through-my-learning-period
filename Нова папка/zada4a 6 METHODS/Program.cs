using System;

namespace zada4a_6_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangle(width, height);
            Console.WriteLine(area);
        }
        static double GetRectangle(double width,double height)
        {
            return width * height;
        }
    }
}
