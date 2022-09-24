#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cl.curso.facturas.leer/cl.curso.facturas.leer.csproj", "cl.curso.facturas.leer/"]
RUN dotnet restore "cl.curso.facturas.leer/cl.curso.facturas.leer.csproj"
COPY . .
WORKDIR "/src/cl.curso.facturas.leer"
RUN dotnet build "cl.curso.facturas.leer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cl.curso.facturas.leer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cl.curso.facturas.leer.dll"]