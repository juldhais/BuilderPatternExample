FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BuilderPatternExample/BuilderPatternExample.csproj", "BuilderPatternExample/"]
RUN dotnet restore "BuilderPatternExample/BuilderPatternExample.csproj"
COPY . .
WORKDIR "/src/BuilderPatternExample"
RUN dotnet build "BuilderPatternExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuilderPatternExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuilderPatternExample.dll"]
