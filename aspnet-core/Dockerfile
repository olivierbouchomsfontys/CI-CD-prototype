FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY . .
RUN dotnet restore

WORKDIR src/AutomaticAcceptanceTest.Web.Host
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "AutomaticAcceptanceTest.Web.Host.dll"]