using System;
using System.Globalization;

namespace licao25
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, rg, slrg;
            int pct;

            sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            if (sal <= 400)
            {
                pct = 15;
            }
            else if (sal <= 800)
            {
                pct = 12;
            }
            else if (sal <= 1200.00)
            {
                pct = 10;
            }
            else if (sal <= 2000)
            {
                pct = 7;
            }
            else 
            { 
                pct = 4;
            }

            rg = sal / 100 * pct;
            slrg = sal + rg;

            Console.WriteLine("Novo salario: " + slrg.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + rg.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + pct.ToString("f0",CultureInfo.InvariantCulture) + " %");
        }
    }
}