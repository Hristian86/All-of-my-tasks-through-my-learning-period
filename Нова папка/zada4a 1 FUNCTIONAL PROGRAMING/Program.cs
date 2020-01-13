using System;
using System.Linq;

namespace zada4a_1_FUNCTIONAL_PROGRAMING
{
    class Program
    {
        static Action<string> print = massage => Console.WriteLine(massage);
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            //print(numbers.Length.ToString());
            //int numb = numbers.Sum();
            //print(numb.ToString());

            
            Func<string, bool> cheker = x => x[0] == x.ToUpper()[0];
            //string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x[0] == x.ToUpper()[0]).ToArray();

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(cheker).ToArray();

            foreach (var item in words)
            {
                print(item);
            }



            //int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            //Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
