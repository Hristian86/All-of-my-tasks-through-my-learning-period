using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zada4a_4_STREAMREADER
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Pencho\Desktop\readers\sliceMe.txt";
            int pieces = 4;
            List<string> pages = new List<string>
            {
                "Part-1.txt","Part-2.txt","Part-3.txt","Part-4.txt"
            };
            using (var readFile = new FileStream(source, FileMode.Open))
            {
                long sizePerPiece = (long)Math.Ceiling((double)readFile.Length / pieces);
                for (int i = 0; i < pieces; i++)
                {
                    long current = 0;
                    using (var createFile = new FileStream(pages[i], FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        while ((readFile.Read(buffer, 0, buffer.Length)) == buffer.Length)
                        {
                            current += sizePerPiece;
                            createFile.Write(buffer, 0, buffer.Length);
                            if (sizePerPiece >= current)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
