FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ServiceOne.API.csproj", "ServiceOne.API/"]
RUN dotnet restore "ServiceOne.API/ServiceOne.API.csproj"
WORKDIR "/ServiceOne.API"
COPY . .
RUN dotnet build "ServiceOne.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceOne.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServiceOne.API.dll"]