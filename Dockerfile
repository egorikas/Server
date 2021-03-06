## Build stage
FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /build

# Copy source
COPY . .

# Restore dependencies
RUN dotnet restore src/ServiceHost/ServiceHost.csproj /p:SolutionDir=/build /p:SolutionName=DotNetRu.Server
RUN dotnet restore test/ServiceHost.Tests/ServiceHost.Tests.csproj /p:SolutionDir=/build /p:SolutionName=DotNetRu.Server

# Run tests
RUN dotnet test test/ServiceHost.Tests/ServiceHost.Tests.csproj /p:SolutionDir=/build /p:SolutionName=DotNetRu.Server

# Publish stage
RUN dotnet publish src/ServiceHost/ServiceHost.csproj -o /publish /p:SolutionDir=/build /p:SolutionName=DotNetRu.Server

## Runtime stage
FROM microsoft/dotnet:2.2-aspnetcore-runtime
COPY --from=build-env /publish /app

WORKDIR /app
ENTRYPOINT ["dotnet", "DotNetRu.ServiceHost.dll"]