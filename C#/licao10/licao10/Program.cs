using System;
using System.Globalization;

namespace licao10
{

    class Program
    {
        static void Main(string[] args)
        {


            int A, B;
            double C, SAL;

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            SAL = B * C;


            Console.WriteLine("NUMBER = " + A);
            Console.WriteLine("SALARY = U$ " + SAL.ToString("F2"));



        }
    }
}