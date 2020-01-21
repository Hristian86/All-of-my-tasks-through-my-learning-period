using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace zada4a_2_STREAMREADER
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var read = new StreamReader(@"C:\Users\Pencho\Desktop\readers\Input.txt"))
            {
                string line = read.ReadLine();

                using (var write = new StreamWriter(@"C:\Users\Pencho\Desktop\readers\Output.txt"))
                {
                    int i = 1;
                    while (true)
                    {
                        if (line == null)
                        {
                            break;
                        }
                        write.WriteLine($"{i}. {line}");
                        line = read.ReadLine();
                        i++;
                    }
                }
            }
        }
    }
}