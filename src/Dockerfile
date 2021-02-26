FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /src
COPY ["Dictionary.Web/Dictionary.Web.csproj", "Dictionary.Web/"]
COPY . .

WORKDIR /src/Dictionary.Web
RUN dotnet publish Dictionaryv.Web.csproj --no-restore -c Release -o /app

WORKDIR /app
EXPOSE 80
EXPOSE 443
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Dictionary.Web.dll
