using System;
using System.Globalization;

namespace licao12
{

    class Program
    {
        static void Main(string[] args)
        {

            int CDP1, CDP2, NP1, NP2;
            double VU1, VU2, VT;

            string[] valores = Console.ReadLine().Split(' ');

            CDP1 = int.Parse(valores[0]);
            NP1= int.Parse(valores[1]);
            VU1= double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');  
            CDP2 = int.Parse(valores[0]);
            NP2 = int.Parse(valores[1]);
            VU2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            VT = NP1*VU1 + NP2*VU2;



            Console.WriteLine("VALOR A PAGAR: R$ " + VT.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}