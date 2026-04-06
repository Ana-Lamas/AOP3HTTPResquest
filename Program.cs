using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("=== Iniciando Processamento Assíncrono (Padrão XHR) ===");

        // Criando objeto cliente para a API
        using var xhr = new HttpClient();

        try
        {
            // Configurando o Método (GET) da API
            var url = "https://jsonplaceholder.typicode.com/todos/1";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            // Definindo os cabeçalhos necessários
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "EcommerceArchitecture_BR");

            Console.WriteLine("Requisição configurada. Enviando de forma assíncrona...");

            // Envio de requisição assíncrona
            var response = await xhr.SendAsync(request);

            // Verificando status
            if (response.IsSuccessStatusCode)
            {
                // Lendo o retorno dos dados
                string responseData = await response.Content.ReadAsStringAsync();

                Console.WriteLine("\n[RESPOSTA RECEBIDA]");
                Console.WriteLine(responseData);
            }
            else
            {
                Console.WriteLine($"Erro no processamento: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            // Tratamento de erros de rede
            Console.WriteLine($"Falha na comunicação: {ex.Message}");
        }

        Console.WriteLine("\n=== Fim do Ciclo de Vida da Requisição ===");
    }
}