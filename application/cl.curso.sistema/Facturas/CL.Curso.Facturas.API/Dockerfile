#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cl.curso.sistema/cl.curso.sistema.csproj", "cl.curso.sistema/"]
RUN dotnet restore "cl.curso.sistema/cl.curso.sistema.csproj"
COPY . .
WORKDIR "/src/cl.curso.sistema"
RUN dotnet build "cl.curso.sistema.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cl.curso.sistema.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cl.curso.sistema.dll"]