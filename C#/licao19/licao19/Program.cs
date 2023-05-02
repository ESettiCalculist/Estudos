﻿using System;
using System.Globalization;

namespace licao19
{
    class Program
    {

        static void Main(string[] args)
        {


            double a, b, c, delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine(" impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("r1 = " + r1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("r2 = " + r2.ToString("f5", CultureInfo.InvariantCulture));



            }
        }
    }
}


