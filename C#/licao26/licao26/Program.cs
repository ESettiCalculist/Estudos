using System;
using System.Globalization;

namespace licao26
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine("Digite o numero de produtos a ser adcionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdcionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Entre os dados da altura e largura do retangulo:");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}