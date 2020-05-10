using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Recursion
{
    public class FindSum<T>
    {
        //private T[] arr;

        //public FindSum(T[] array)
        //{
        //    arr = array;
        //}

        public FindSum()
        {

        }

        public void Recursion(T[] array,int bottom)
        {
            if (bottom == 6)
            {
                return ;
            }

            Console.Write(string.Join(" ",array));





            Console.WriteLine();
        }


    }
}
