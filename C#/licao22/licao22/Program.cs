using System;
using System.Globalization;

namespace licao22
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double total;

            String[] valores = Console.ReadLine().Split(' ');

            cod = int.Parse(valores[0]);
            qtd = int.Parse(valores[1]);


            if (cod == 1)
            {
                total = qtd * 4.0;
            }
            else if (cod == 2)
                {
                    total = qtd * 4.5;
                }
            else if (cod == 3)
            {
                total = qtd * 5.0;
            }
            else if (cod == 4)
            {
                total = qtd * 2.0;
            }
            else
            {
                total = qtd * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}