# Aplicativo de Cadastro de Contatos Regionais

Aplicativo utilizando **.NET 8** para cadastro de contatos regionais, considerando a persistência de dados e qualidade de software.

## Requisitos Funcionais

- **Cadastro de Contatos**: 
  - Permitir o cadastro de novos contatos, incluindo nome, telefone e e-mail.
  - Associar cada contato a um DDD correspondente à região.
  
- **Consulta de Contatos**: 
  - Implementar funcionalidade para consultar e visualizar os contatos cadastrados.
  - Possibilitar a filtragem dos contatos pelo DDD da região.
  
- **Atualização e Exclusão**: 
  - Possibilitar a atualização e exclusão de contatos previamente cadastrados.

## Requisitos Técnicos

- **Persistência de Dados**:
  - Utilizado o banco de dados PostgreSQL para armazenar as informações dos contatos.
  - Uso do Entity Framework Core para a camada de acesso a dados.
  
- **Validações**:
  - Implementadas validações para garantir a consistência dos dados.
  - Exemplos: validação de formato de e-mail, telefone e campos obrigatórios.
  
- **Testes Unitários**:
  - Testes desenvolvidos utilizando xUnit.

## Observações

O foco principal é a **qualidade do código**, as **boas práticas de desenvolvimento** e o **uso eficiente da plataforma .NET 8**. Este projeto é uma demonstração de habilidades em persistência de dados, arquitetura de software e testes, além de boas práticas de desenvolvimento.

## Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [xUnit](https://xunit.net/)

## Como Executar o Projeto

1. Clone o repositório:
    ```sh
    git clone https://github.com/williansdg4/TechChallange.git
    ```
2. Navegue até o diretório do projeto:
    ```sh
    cd TechChallange
    ```
3. Restaure as dependências:
    ```sh
    dotnet restore
    ```
4. Configure a string de conexão com o banco de dados PostgreSQL no arquivo `appsettings.json`.
5. Execute as migrações do Entity Framework Core:
    ```sh
    dotnet ef database update
    ```
6. Execute o aplicativo:
    ```sh
    dotnet run
    ```
