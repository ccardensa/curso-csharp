#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cl.curso.productos/cl.curso.productos.csproj", "cl.curso.productos/"]
RUN dotnet restore "cl.curso.productos/cl.curso.productos.csproj"
COPY . .
WORKDIR "/src/cl.curso.productos"
RUN dotnet build "cl.curso.productos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cl.curso.productos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cl.curso.productos.dll"]