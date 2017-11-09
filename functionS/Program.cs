using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionS
{
    class Program
    {
        public static double funcS()
        {
            const double start = 99;
            double result = 0;
            for (double i = start; i > 0; i -= 3)
            {
                result = Math.Sqrt(i) + result;
            }
            return result;
        } 
        static void Main(string[] args)
        {
            double s = funcS();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
