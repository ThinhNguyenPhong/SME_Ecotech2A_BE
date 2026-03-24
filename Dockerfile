# Stage 1: Restore and build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and projects
COPY *.sln .
COPY SME_Ecotech2A.API/SME_Ecotech2A.API.csproj SME_Ecotech2A.API/
COPY SME_Ecotech2A.Application/SME_Ecotech2A.Application.csproj SME_Ecotech2A.Application/
COPY SME_Ecotech2A.Infrastructure/SME_Ecotech2A.Infrastructure.csproj SME_Ecotech2A.Infrastructure/
COPY SME_Ecotech2A.Domain/SME_Ecotech2A.Domain.csproj SME_Ecotech2A.Domain/
RUN dotnet restore

# Copy source and build
COPY . .
RUN dotnet publish SME_Ecotech2A.API/SME_Ecotech2A.API.csproj -c Release -o out

# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published output
COPY --from=build /app/out .

# Expose ports
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:443
EXPOSE 443

ENTRYPOINT ["dotnet", "SME_Ecotech2A.API.dll"]