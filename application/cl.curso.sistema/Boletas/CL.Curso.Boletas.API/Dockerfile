#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cl.curso.honorario/cl.curso.honorario.csproj", "cl.curso.honorario/"]
RUN dotnet restore "cl.curso.honorario/cl.curso.honorario.csproj"
COPY . .
WORKDIR "/src/cl.curso.honorario"
RUN dotnet build "cl.curso.honorario.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cl.curso.honorario.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cl.curso.honorario.dll"]