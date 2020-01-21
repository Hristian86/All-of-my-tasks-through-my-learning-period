using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace zada4a_1_STREAMREADER
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var read = new StreamReader(@"C:\Users\Pencho\Desktop\readers\Input.txt"))
            {
                int i = 1;
                string line = read.ReadLine();

                using (var write = new StreamWriter(@"C:\Users\Pencho\Desktop\readers\Output.txt"))
                {
                    while (line != null)
                    {
                        if (i % 2 == 0)
                        {
                            write.WriteLine(line);
                        }
                        i++;
                        line = read.ReadLine();
                    }
                }
            }
        }
    }
}