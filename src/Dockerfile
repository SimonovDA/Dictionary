FROM mcr.microsoft.com/dotnet/core/sdk:5

WORKDIR /src
COPY ["Dictionary.Web/Dictionary.Web.csproj", "Dictionary.Web/"]
COPY . .

WORKDIR /src/Dictionary.Web
RUN dotnet publish Dictionaryv.Web.csproj --no-restore -c Release -o /app

WORKDIR /app
EXPOSE 80
EXPOSE 443
CMD ASPNETCORE_URLS=http://*:$PORT dotnet DevicesTelemetry.Web.dll
