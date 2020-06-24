#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Financeiro.UI/Financeiro.UI.csproj", "src/Financeiro.UI/"]
RUN dotnet restore "src/Financeiro.UI/Financeiro.UI.csproj"
COPY . .
WORKDIR "/src/src/Financeiro.UI"
RUN dotnet build "Financeiro.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Financeiro.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Financeiro.UI.dll"]