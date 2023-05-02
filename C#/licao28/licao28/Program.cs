using licao28;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {

       
        static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}