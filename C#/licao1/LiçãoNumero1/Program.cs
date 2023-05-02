

Console.WriteLine("Qual o seu nome?");
Console.ReadLine();
Console.WriteLine("quantos quartos tem na sua casa?");
Console.ReadLine();
Console.WriteLine("entre com o preço de um produto:");
Console.ReadLine();
Console.WriteLine("digite o seu ultimo nome idade e altura");
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
int idade = int.Parse (vet[1]);
double altura = double.Parse(vet[2]);


Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine("\r\n parabens voce conseguiu");




