using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zada4a_3_STREAMREADER
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "бате сашо";

            var fileStr = new FileStream(@"C:\Users\Pencho\Desktop\readers\Output.txt", FileMode.Create);

            try
            {
                byte[] encod = Encoding.UTF8.GetBytes(text);
                fileStr.Write(encod, 0, encod.Length);
            }
            finally
            {
                fileStr.Close();
            }

        }
    }
}
