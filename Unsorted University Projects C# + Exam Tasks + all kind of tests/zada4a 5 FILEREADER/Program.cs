using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace zada4a_5_FILEREADER
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = File.ReadAllText(@"C:\Users\Pencho\Desktop\readers\sliceMe.txt");

            //string[] lines = File.ReadAllLines(@"C:\Users\Pencho\Desktop\readers\sliceMe.txt");

            //File.WriteAllText(@"C:\Users\Pencho\Desktop\readers\Output.txt","Files is for heavy brain people");
            //string[] names = { "Pesho", "Sasho", "Kolio", "Tosho" };
            //File.WriteAllLines(@"C:\Users\Pencho\Desktop\readers\Output.txt", names);
            //File.AppendAllText(@"C:\Users\Pencho\Desktop\readers\Output.txt", "Zubar si bateeeeeeeee");
            //Directory.CreateDirectory(@"C:\Users\Pencho\Desktop\readers\Test");
            //Directory.Delete(@"C:\Users\Pencho\Desktop\readers\Test");
            //Directory.Move(@"C:\Users\Pencho\Desktop\readers\Test", "Penchooooooooo");
            //string[] filesInDirectory = Directory.GetDirectories(@"C:\Users\Pencho\Desktop");
            //for (int i = 0; i < filesInDirectory.Length; i++)
            //{
            //    Console.WriteLine(filesInDirectory[i]);
            //}

            string[] files = Directory.GetFiles(@"C:\Users\Pencho\Desktop");
            double sum = 0;
            foreach (var item in files)
            {
                FileInfo fileInfo = new FileInfo(item);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText(@"C:\Users\Pencho\Desktop\readers\Output.txt", sum.ToString());
        }
    }
}