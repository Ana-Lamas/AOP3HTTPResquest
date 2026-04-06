# Atividade Online Pontuada 3 (AOP3) - Disciplina de Back-End

Este repositório contém a implementação técnica para a **AOP3**, focada em **Arquitetura de Interoperabilidade Web** e **Processamento Assíncrono de Dados**.

## 🎯 Objetivo do Projeto
O desafio proposto simula um cenário real de um e-commerce de grande porte, onde é necessário realizar a integração com APIs REST externas de forma robusta e não-bloqueante. O código demonstra o ciclo completo de uma requisição HTTP assíncrona utilizando C# e .NET 10.

## 🛠️ Tecnologias Utilizadas
- **Linguagem:** C#
- **Framework:** .NET 10.0
- **Biblioteca Base:** `System.Net.Http` (HttpClient)
- **Padrão Assíncrono:** Task-based Asynchronous Pattern (TAP) com `async/await`.

## 🏗️ Fluxo da Implementação
A lógica desenvolvida segue o fluxo de interoperabilidade moderno:
1. **Configuração da Requisição:** Uso do `HttpRequestMessage` para definir métodos e endpoints.
2. **Manipulação de Headers:** Inclusão de cabeçalhos personalizados para identificação da aplicação.
3. **Execução Assíncrona:** Disparo da requisição via `SendAsync` sem bloquear a thread principal.
4. **Tratamento de Resposta:** Validação de Status Codes e leitura assíncrona do conteúdo (JSON).

## 🚀 Como executar o projeto
1. Certifique-se de ter o **SDK do .NET 10** instalado em sua máquina.
2. Clone este repositório:
   ```bash
   git clone [https://github.com/Ana-Lamas/AOP3HTTPResquest.git](https://github.com/Ana-Lamas/AOP3HTTPResquest)
3. Navegue até a pasta do projeto e execute:
   ```bash
   dotnet run

## Desenvolvido por: Ana Caroline Lamas Rosa Corteletti
