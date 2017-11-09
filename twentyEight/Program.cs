using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyEight
{
    //Дана последовательность целых чисел, за которой следует 0.  
    //Найти разность минимального и максимального элементов в этой последовательности.
    class Program
    {
        public static int Max(int[] ArrayOfNumbers)
        {
            int rW = ArrayOfNumbers[0];
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                if (ArrayOfNumbers[i] > rW)
                {
                    rW = ArrayOfNumbers[i];
                }
            }
            return rW;
        }
        public static int Min(int[] ArrayOfNumbers)
        {
            int rW = ArrayOfNumbers[0];
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                if (ArrayOfNumbers[i] < rW)
                {
                    rW = ArrayOfNumbers[i];
                }
            }
            return rW;
        }
        static void Main(string[] args)
        {
            int[] Numbers = new int[11] { 2, 4, 7, 10, 0, 1, 5, 50, 100, 7, 0 };
            int maxNumber = Max(Numbers);
            int minNumber = Min(Numbers);
            

            Console.WriteLine(maxNumber - minNumber);
            Console.ReadKey();
        }
    }
}
