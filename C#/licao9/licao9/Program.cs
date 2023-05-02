using System;
using System.Globalization;

namespace licao8
{

    class Program
    {
        static void Main(string[] args)
        {


            double A, B, C, D, DIF;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            DIF = (A*B) - (C*D);


            Console.WriteLine("DIFERENCA = " + DIF);


        }
    }
}