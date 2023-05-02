using System;
using System.Globalization;

namespace licao17
{

    class Program
    {
        static void Main(string[] args)
        {


            int I1, I2;
            string nome1,nome2;
            double media;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1= vet[0];
            I1= int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            I2 = int.Parse(vet[1]);

            media = (double) (I1+ I2) / 2 ;



            Console.WriteLine(" A IDADE MÉDIA DE " + nome1 + " E " + nome2 + " É DE = "
                + media.ToString("f1", CultureInfo.InvariantCulture) + " ANOS");


        }
    }
}