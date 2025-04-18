# PrimeiraAPI

PrimeiraAPI é um projeto de exemplo desenvolvido em C# com .NET 8. Ele demonstra a criação de uma API REST básica, incluindo endpoints para manipulação de dados e exemplos de boas práticas no desenvolvimento de APIs.

## Tecnologias Utilizadas

- **Linguagem:** C# 12.0
- **Framework:** .NET 8
- **Estrutura do Projeto:** ASP.NET Core Web API

## Estrutura do Projeto

- **`Produto.cs`**: Define a classe `Produto` com propriedades básicas como `Id` e `Nome`.
- **`Controllers/TesteController.cs`**: Controlador para endpoints de teste.
- **`Controllers/WeatherForecastController.cs`**: Controlador de exemplo gerado automaticamente pelo template do ASP.NET Core.
- **`Program.cs`**: Configuração inicial do projeto e registro de serviços.

## Como Executar o Projeto

1. Certifique-se de ter o .NET 8 SDK instalado em sua máquina.

2.  Clone este repositório:
   git clone <URL_DO_REPOSITORIO>
   
3. Navegue até o diretório do projeto:
   cd PrimeiraAPI

4. Execute o projeto:
   dotnet run

5. A API estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

## Endpoints Disponíveis

### WeatherForecast
- **GET** `/WeatherForecast`: Retorna previsões de tempo de exemplo.

### Teste
- **GET** `/Teste`: Endpoint de teste (detalhes podem variar dependendo da implementação).

## Classe Produto

A classe `Produto` é um modelo simples com as seguintes propriedades:
- `Id` (int): Identificador único do produto.
- `Nome` (string): Nome do produto.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
