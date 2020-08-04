using Microsoft.VisualBasic;
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int[] array = new int[9];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                if (i == 4)
                {
                    array[i] = array[i - 1] * 2;
                }
                Console.WriteLine(array[i]);

            }
        }
    }
}
