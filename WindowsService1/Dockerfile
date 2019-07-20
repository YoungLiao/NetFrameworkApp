FROM mcr.microsoft.com/dotnet/framework/sdk:4.7.2 as build

WORKDIR /src

COPY NetFrameworkApp.sln .
COPY WebApplication1/WebApplication1.csproj WebApplication1/WebApplication1.csproj
COPY WebApplication1/packages.config WebApplication1/packages.config
COPY WindowsService1/WindowsService1.csproj WindowsService1/WindowsService1.csproj
RUN nuget restore

COPY . .
RUN msbuild  /p:Configuration=Release /m

FROM mcr.microsoft.com/dotnet/framework/runtime:4.7.2

WORKDIR /app
COPY --from=build /src/WindowsService1/bin/Release .

CMD ["WindowsService1.exe"]