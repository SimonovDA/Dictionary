FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /src

COPY ["Dictionary.Web/Dictionary.Web.csproj", "Dictionary.Web/"]
COPY ["Dictionary.Web.Models/Dictionary.Web.Models.csproj", "Dictionary.Web.Models/"]
COPY ["Dictionary.Data/Dictionary.Data.csproj", "Dictionary.Data/"]
RUN dotnet restore Dictionary.Web/Dictionary.Web.csproj
COPY . .

WORKDIR /src/Dictionary.Web
RUN dotnet publish --no-restore -c Release -o /app

WORKDIR /app
EXPOSE 80
EXPOSE 443
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Dictionary.Web.dll