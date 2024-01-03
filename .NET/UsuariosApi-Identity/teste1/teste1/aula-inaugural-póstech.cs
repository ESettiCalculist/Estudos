using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static HashSet<string> numerosPercorridos = new HashSet<string>();

    static async Task Main()
    {


        List<char> vogais = new List<char>
        {
            'A', 'Á', 'À', 'Â', 'Ã', 'Ä',
            'E', 'É', 'È', 'Ê', 'Ë',
            'I', 'Í', 'Ì', 'Î', 'Ï',
            'O', 'Ó', 'Ò', 'Ô', 'Õ', 'Ö',
            'U', 'Ú', 'Ù', 'Û', 'Ü',
            'a', 'á', 'à', 'â', 'ã', 'ä',
            'e', 'é', 'è', 'ê', 'ë',
            'i', 'í', 'ì', 'î', 'ï',
            'o', 'ó', 'ò', 'ô', 'õ', 'ö',
            'u', 'ú', 'ù', 'û', 'ü'
        };

        while (true)
        {
            //gera o numero aleatorio
            string numeroAleatorio = gerarNumeroAleatorio();
            Console.WriteLine("Numero da vez: " + numeroAleatorio);

            //percorre a lista
            foreach (char vogal in vogais)
            {
                Console.WriteLine($"O Numero + a vogal é: {vogal}{numeroAleatorio}");
                //chama na frente
                HttpResponseMessage response = await realizaTenativaAsync(vogal + numeroAleatorio);
                if (response.StatusCode.Equals(200))
                {
                    Console.WriteLine("Número encontrado :)");
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                    break;
                }

                Console.WriteLine($"A vogal + O Numero é: {numeroAleatorio}{vogal}");
                //chama atras
                HttpResponseMessage response2 = await realizaTenativaAsync(numeroAleatorio + vogal);
                if (response2.StatusCode.Equals(200))
                {
                    Console.WriteLine("Número encontrado :)");
                    string responseContent = await response2.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                    break;
                }
            }
        }
    }

    private static string gerarNumeroAleatorio()
    {
        var NumeroMenor = 1;
        var NumeroMaior = 1000;
        Random random = new Random();

        int numeroAleatorio = random.Next(NumeroMenor, NumeroMaior);

        while (numerosPercorridos.Contains(numeroAleatorio.ToString()))
        {
            numeroAleatorio = random.Next(NumeroMenor, NumeroMaior);
        }

        numerosPercorridos.Add(numeroAleatorio.ToString());

        Console.WriteLine($"O numero gerado é {numeroAleatorio}.");
        return numeroAleatorio.ToString();
    }

    private static async Task<HttpResponseMessage> realizaTenativaAsync(string chave)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            string apiUrl = "https://fiap-inaugural.azurewebsites.net/fiap";

            var data = new
            {
                key = chave
            };

            string jsonData = JsonConvert.SerializeObject(data);

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            return await httpClient.PostAsync(apiUrl, content);
        }
    }
}
