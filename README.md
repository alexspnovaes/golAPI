# GOL CRUD API

=====================
  
  ## API .NET Core
 
  Cadastro, edição, exclusão e atualização de um cadastro de airplane.

- Consultar o catálogo de airplanes de forma paginada;
- Consultar o airplane pelo seu identificador;
- Cadastrar um novo airplane e obter o retorno do identificador único desse novo cadastro;
- Excluir um airplane;
- Atualizar um airplane;

# Como rodar a aplicação:
- Possuir a ultima versão do  SDK (https://dot.net/core)

 ## Docker
  Apartir do diretório clonado da aplicação:
  - docker build -t cashback .
  - docker run -d -p 8080:80 --name cash cashback

 ## .NET CLI
  A partir do diretório clonado da aplicação:
  dotnet run --project GOL.Service\GOL.Service.csProj

  Acessar o Swagger para visualizar o endpoint e testar as chamadas
  https://localhost:5001/swagger/index.html
  
  ## informações importantes :
  
   - A aplicação esta utilizando EF Core in memory ( Apenas para testes), portanto os dados só serão mantidos durante o ciclo de vida da aplicação.
   - Os dados de airplanes estão sendo criados no momento da inicialização
   
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

- Arquitetura com segregação de responsábilidade, utilizando Principios do SOLID
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


