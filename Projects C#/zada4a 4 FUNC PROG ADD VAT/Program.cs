using System;
using System.Linq;

namespace zada4a_4_FUNC_PROG_ADD_VAT
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Multyplayer calc = (x, y) => x * y;
            int result = calc(5, 3);
            Console.WriteLine(result);
        }
        public delegate int Multyplayer(int x, int y);
    }
}
