using System.Globalization;

namespace PROJETO
{
    class PROGRAM {
        static void Main(string[] ARGS) {

            double x = 10.35784;
            int Y = 32;
            int p, o;
            double b, B, h, area;

            b = 6.0; B = 8.0; h = 5.0;
            area = (b + B) / 2.0 * h;
            p = 5;
            o = p * 2;
            float e, E, r, area2;

            e = 6f; E = 8f; r = 5f;
            area2 = (e + E) / 2f * r;

            string Z = "MARIA";
            char W = 'F';


            Console.Write("Boa noite");
            Console.WriteLine("BUM TANTAN");
            Console.WriteLine("ATÉMAIS");



            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine(" O VALOR DO TROCO É " + x + " reais");
            Console.WriteLine(" o valor do troco é " + x.ToString("F2") + " REAIS ");
            Console.WriteLine();
            Console.WriteLine(" A PACIENTE " + Z + " TEM " + Y + " ANOS E SEU SEXO É " + W);
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine(o);
            Console.WriteLine();

            Console.WriteLine(area);
            Console.WriteLine();
            Console.WriteLine(area2);
           
            
            Console.ReadLine();

            
        }
    }
}

