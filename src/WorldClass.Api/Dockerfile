
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WorldClass.Api/WorldClass.Api.csproj", "WorldClass.Api/"]
RUN dotnet restore "WorldClass.Api/WorldClass.Api.csproj"
COPY . .
WORKDIR "/src/WorldClass.Api"
RUN dotnet build "WorldClass.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorldClass.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorldClass.Api.dll"]
