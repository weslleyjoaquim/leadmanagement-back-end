# Lead Management API

API para gerenciamento de leads desenvolvida com .NET 6.0 e SQL Server, seguindo os princípios da Clean Architecture.

## 📋 Pré-requisitos

### Para execução local:
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server 2019+](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms) (opcional, para gerenciamento do banco de dados)
- [Git](https://git-scm.com/)

### Para execução com Docker:
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (Windows/Mac) ou [Docker Engine](https://docs.docker.com/engine/install/) (Linux)
- [Docker Compose](https://docs.docker.com/compose/install/)

## 🚀 Como executar

### 1. Configuração do ambiente

#### Variáveis de ambiente
Crie um arquivo `appsettings.Development.json` na pasta `LeadManagement.API` com as seguintes configurações:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=LeadManagementDB;User Id=sa;Password=SenhaForte123@;TrustServerCertificate=true;"
  },
  "AllowedHosts": "*"
}
```

### 2. Executando com Docker (Recomendado)

1. Navegue até a pasta do projeto:
   ```bash
   cd LeadManagement
   ```

2. Execute o comando para subir os containers:
   ```bash
   docker-compose up --build -d
   ```

3. Acesse a documentação da API:
   - Swagger UI: http://localhost:5000/swagger
   - API: http://localhost:5000/api/v1/

4. Para parar os containers:
   ```bash
   docker-compose down
   ```

### 3. Executando localmente

1. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```

2. Execute as migrações do banco de dados:
   ```bash
   cd LeadManagement.API
   dotnet ef database update
   ```

3. Inicie a aplicação:
   ```bash
   dotnet run --project LeadManagement.API
   ```

4. Acesse a aplicação:
   - Swagger UI: https://localhost:7229/swagger
   - API: https://localhost:7229/api/v1/

## 🛠️ Estrutura do Projeto

```
LeadManagement/
├── LeadManagement.API/          # Camada de apresentação (Web API)
├── LeadManagement.Application/   # Camada de aplicação (casos de uso)
├── LeadManagement.Domain/       # Camada de domínio (entidades e interfaces)
└── LeadManagement.Infrastructure/ # Camada de infraestrutura (implementações)
```

## 🔧 Tecnologias Utilizadas

- .NET 6.0
- Entity Framework Core 6.0
- SQL Server 2022
- Docker e Docker Compose
- Swagger/OpenAPI
- AutoMapper
- FluentValidation

## 📄 Documentação da API

A documentação da API está disponível através do Swagger UI em:
- Docker: http://localhost:5000/swagger
- Local: https://localhost:7229/swagger

## 🔒 Variáveis de Ambiente

| Variável | Descrição | Valor Padrão |
|----------|-----------|--------------|
| ASPNETCORE_ENVIRONMENT | Ambiente de execução | Development |
| ConnectionStrings__DefaultConnection | String de conexão com o SQL Server | - |

## 🐛 Solução de Problemas

### Erro de conexão com o banco de dados
- Verifique se o SQL Server está rodando
- Confirme se as credenciais no `appsettings.json` estão corretas
- Verifique se a porta 1433 está liberada no firewall

### Erro ao executar migrações
- Certifique-se de que o usuário tem permissões para criar bancos de dados
- Verifique se o banco de dados especificado existe

