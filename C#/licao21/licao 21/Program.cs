using System;
using System.Globalization;

namespace licao21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            String[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            if (b > c && d > a && c + d > a + b && a % 2 == 0)

            {
                Console.WriteLine("valores aceitos");  
            }
            else
            {
                Console.WriteLine(" valores nao aceitos");
            }
        }
    }
}

