using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int[] arrayOfInt = Enumerable
                .Repeat(0, 10)
                .Select(i => randNum.Next(0, 20))
                .ToArray();

            foreach (int num in arrayOfInt) Console.Write(num.ToString() + "\t");
            Console.WriteLine();

            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                for (int j = 0; j < arrayOfInt.Length - i - 1; j++) {
                    if (arrayOfInt[j] > arrayOfInt[j + 1])
                        swapInts(ref arrayOfInt[j], ref arrayOfInt[j + 1]);
                }
            }

            foreach (int num in arrayOfInt) Console.Write(num.ToString() + "\t");

            Console.ReadLine();
        }

        static void swapInts(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
