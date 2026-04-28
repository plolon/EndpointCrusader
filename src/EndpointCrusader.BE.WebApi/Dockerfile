# runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app

# build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# kopiujemy cały src (prosto, bez kombinacji z cache na razie)
COPY ./src ./

# restore + build
RUN dotnet restore "EndpointCrusader.BE.WebApi/EndpointCrusader.BE.WebApi.csproj"

WORKDIR "/src/EndpointCrusader.BE.WebApi"
RUN dotnet build "EndpointCrusader.BE.WebApi.csproj" -c Release -o /app/build

# publish
FROM build AS publish
RUN dotnet publish "EndpointCrusader.BE.WebApi.csproj" -c Release -o /app/publish

# final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "EndpointCrusader.BE.WebApi.dll"]