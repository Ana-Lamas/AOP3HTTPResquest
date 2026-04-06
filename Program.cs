using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("=== Monitor de Integração Assíncrona - Empresa X ===");

// Criando objeto cliente para a API
using var client = new HttpClient();

// Configurando o Método (GET) da API
var request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/todos/1");

// Definindo os cabeçalhos necessários
request.Headers.Add("User-Agent", "EcommerceArchitecture/1.0");
request.Headers.Add("Accept", "application/json");

// Controle para evitar travamento na API
var cts = new CancellationTokenSource();

try
{
    Console.WriteLine("\n[1] Disparando requisição assíncrona para a API...");

    // Envio de requisição
    var response = await client.SendAsync(request, cts.Token);

    // Tratamento do retorno
    if (response.IsSuccessStatusCode)
    {
        // Lendo o conteúdo do corpo da resposta
        string content = await response.Content.ReadAsStringAsync();

        Console.WriteLine("[2] Resposta recebida com sucesso!");
        Console.WriteLine("--- Dados Recebidos ---");
        Console.WriteLine(content);
        Console.WriteLine("-----------------------");
    }
    else
    {
        Console.WriteLine($"[Erro] O servidor retornou o status: {response.StatusCode}");
    }
}
catch (TaskCanceledException)
{
    Console.WriteLine("[Erro] A requisição excedeu o tempo limite (Timeout).");
}
catch (Exception ex)
{
    Console.WriteLine($"[Erro Crítico] Falha na integração: {ex.Message}");
}

Console.WriteLine("\n=== Fim do Processamento Assíncrono ===");