using System;
using System.Globalization;

namespace liçao1
{
    class program
    {

        static void Main(string[] args)
        {

            double largura, comprimento, preco, precoMetroQuadrado, area;

            Console.WriteLine("DIGITE O VALOR DA LARGURA DO TERRENO");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("DIGITE O VALOR DO COMPRIMENTO DO TERRENO");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("DIGITE O VALOR DO PREÇO POR METRO QUADRADO:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;


            Console.WriteLine("AREA =" + area.ToString("F2", CultureInfo.InvariantCulture));
            
           Console.WriteLine("O VALOR DO TERRENO É DE:" + preco.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}

