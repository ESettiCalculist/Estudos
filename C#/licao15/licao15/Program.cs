using System;
using System.Globalization;

namespace licao15
{

    class Program
    {
        static void Main(string[] args)
        {


            int X, Y;
            double Z, Q;


            X = int.Parse(Console.ReadLine());
            Y= int.Parse(Console.ReadLine());

            Z = X * Y;
            Q = Z / 12.0;

            Console.WriteLine(Q.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}