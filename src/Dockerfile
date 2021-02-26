FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /src

COPY ["Dictionary.Web/Dictionary.Web.csproj", "Dictionary.Web/"]
RUN dotnet restore Dictionary.Web/Dictionary.Web.csproj
COPY . .

WORKDIR /src/Dictionary.Web
RUN dotnet publish Dictionary.Web.csproj --no-restore -c Release -o /app

WORKDIR /app
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Dictionary.Web.dll
