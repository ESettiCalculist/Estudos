using System;
using System.Globalization;

namespace licao15
{

    class Program
    {
        static void Main(string[] args)
        {



            double B, H, A, P, D;


            B= double.Parse(Console.ReadLine());
            H =double.Parse(Console.ReadLine());

            A = B * H;
            P = B * 2 + H * 2;
            D = Math.Sqrt(B * B + H * H); 


            Console.WriteLine("O VALOR DA AREA = " + A.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O VALOR DO PERIMETRO = " + P.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("O VALOR DA DIAGONAL = " + D.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}