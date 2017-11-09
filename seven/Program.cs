using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seven
{
    //Дана последовательность из n целых чисел.Найти номер максимального элемента в этой последовательности.
    class Program
    {
        public static int Max(int[] ArrayOfNumbers)
        {
            int rW = ArrayOfNumbers[0];
            int indexOfMax = 0;
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                if (ArrayOfNumbers[i] > rW)
                {
                    rW = ArrayOfNumbers[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }
        static void Main(string[] args)
        {
            int[] Numbers = new int[10] { 2, 4, 7, 10, 0, 1, 5, 50, 100, 7 };
            int ForW = Max(Numbers);
            Console.WriteLine(ForW);

            //ForW = Numbers.Max();
            //Console.WriteLine(ForW);
        }
    }
}
