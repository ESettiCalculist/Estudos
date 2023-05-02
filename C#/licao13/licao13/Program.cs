using System;
using System.Globalization;

namespace licao13
{

    class Program
    {
        static void Main(string[] args)
        {


            int X;
            double CONSUMO, Y;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CONSUMO = (double)X / Y;


            Console.WriteLine(CONSUMO.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
                


        }
    }
}