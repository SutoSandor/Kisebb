using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisebb
{
    class Program
    {
        private static double[] szamok = new double[] { 30.154, 35.924, 38.512, 38.129, 29.132, 24.002, 21.342, 18.201 };
        private static double megszamol(double[] tomb)
        {
            double x = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 30)
                {
                    x = x + tomb[i];
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A 30-nál kisebb számok összege: " +megszamol(szamok));
            Console.ReadKey();
        }
    }
}
