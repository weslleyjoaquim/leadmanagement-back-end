FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copia todos os arquivos .csproj e restaura as dependências
COPY ["LeadManagement.API/LeadManagement.API.csproj", "LeadManagement.API/"]
COPY ["LeadManagement.Application/LeadManagement.Application.csproj", "LeadManagement.Application/"]
COPY ["LeadManagement.Domain/LeadManagement.Domain.csproj", "LeadManagement.Domain/"]
COPY ["LeadManagement.Infrastructure/LeadManagement.Infrastructure.csproj", "LeadManagement.Infrastructure/"]

# Restaura as dependências
RUN dotnet restore "LeadManagement.API/LeadManagement.API.csproj"

# Copia o restante do código
COPY . .

# Build da aplicação
WORKDIR "/src/LeadManagement.API"
RUN dotnet build "LeadManagement.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeadManagement.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeadManagement.API.dll"]
