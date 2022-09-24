#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cl.curso.honorarios.leer/cl.curso.honorarios.leer.csproj", "cl.curso.honorarios.leer/"]
RUN dotnet restore "cl.curso.honorarios.leer/cl.curso.honorarios.leer.csproj"
COPY . .
WORKDIR "/src/cl.curso.honorarios.leer"
RUN dotnet build "cl.curso.honorarios.leer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cl.curso.honorarios.leer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cl.curso.honorarios.leer.dll"]