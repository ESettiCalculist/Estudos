using System;
using System.Globalization;

namespace licao4 {

    class Program 
    {
        static void Main(string[] args)  
        {

            
            double raio, A, pi = 3.14159;

           
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            A = pi * raio * raio;


            Console.WriteLine(" A=" +  A.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

