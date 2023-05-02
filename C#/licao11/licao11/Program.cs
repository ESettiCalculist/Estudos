using System;
using System.Globalization;

namespace licao8
{

    class Program
    {
        static void Main(string[] args)
        {

            string P;
            
            double A, B, SAL;

            P = Console.ReadLine();
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            

            SAL = B * 15.0 / 100 + A;


            
            Console.WriteLine("TOTAL = R$ " + SAL.ToString("F2"));



        }
    }
}