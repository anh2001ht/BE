# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY *.sln ./
COPY ECommerce.API/*.csproj ./ECommerce.API/
COPY ECommerce.Domain/*.csproj ./ECommerce.Domain/
COPY ECommerce.Infrastructure/*.csproj ./ECommerce.Infrastructure/

RUN dotnet restore "./ECommerce.API/ECommerce.API.csproj"

COPY . .

RUN dotnet publish "./ECommerce.API/ECommerce.API.csproj" -c Release -o /app/out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "ECommerce.API.dll"]
