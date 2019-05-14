# GOL CRUD API

=====================
  
  ## API .NET Core
 
  Cadastro, edi��o, exclus�o e atualiza��o de um cadastro de airplane.

- Consultar o cat�logo de discos de forma paginada, filtrando por g�nero e ordenando de forma crescente pelo nome do disco;
- Consultar o disco pelo seu identificador;
- Consultar todas as vendas efetuadas de forma paginada, filtrando pelo range de datas (inicial e final) da venda e ordenando de forma decrescente pela data da venda;
- Consultar uma venda pelo seu identificador;
- Registrar uma nova venda de discos calculando o valor total de cashback.
- Integrar com a API do SPotify para alimenar a cole��o de Discos.

# Como rodar a aplica��o:
- Possuir a ultima vers�o do  SDK (https://dot.net/core)

 ## Docker
  Apartir do diret�rio clonado da aplica��o:
  - docker build -t cashback .
  - docker run -d -p 8080:80 --name cash cashback

 ## .NET CLI
  Apartir do diret�rio clonado da aplica��o:
  dotnet run --project Cashback.Service\Cashback.Service.csProj

  Acessar o Swagger para visualizar o endpoint e testar as chamadas
  https://localhost:5001/swagger/index.html
  
  ## informa��es importantes :
  
   - A aplica��o esta utilizando EF Core in memory ( Apenas para testes), portanto os dados s� ser�o mantidos durante o ciclo de vida da aplica��o.
   - Os dados de clientes (Buyers) e de discos est�o sendo criados no momento da inicializa��o
   - Os discos s�o buscados atrav�s da API do Spotify.
   - TODO: A Api esta retornando classes do dominio ao inv�s de serem mapeadas para ViewModels (Automapper) 

## Ferramentas de CI
- Travis
- Circle CI

## Tecnologias Utilizadas:

- ASP.NET Core 2.1 (with .NET Core)
- ASP.NET MVC Core 
- ASP.NET WebApi Core
- Entity Framework Core 2.1
- Entity Framework Core 2.1 (InMemory)
- .NET Core Native DI
- FluentValidator
- MediatR
- Swagger UI

## Architecture / Patterns:

- Arquitetura com segrega��o de respons�bilidade, utilizando Principios do SOLID
- Dependency Injection
- Inversion of control
- Domain Driven Design (Camadas and Domain Model Pattern)
- Domain Events
- Domain Notification
- CQRS ( utilizando um unico banco de dados)
- Unit of Work
- Repository
- Factory
- TDD


