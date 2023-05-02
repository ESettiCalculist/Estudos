using System;

namespace licao23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            String[] v = Console.ReadLine().Split(' ');

            a= int.Parse(v[0]);
            b= int.Parse(v[1]);

            if (a % b == 0 || b % a == 0 )
            {
                Console.WriteLine("Sao Multiplos");
            } 
            else { Console.WriteLine("Nao sao multiplos"); }
        }
    }
}