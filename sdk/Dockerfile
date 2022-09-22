FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Identity.Sdk.sln /usr/src/
COPY Finbourne.Identity.Sdk/Finbourne.Identity.Sdk.csproj /usr/src/Finbourne.Identity.Sdk/
RUN dotnet restore Finbourne.Identity.Sdk

ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Identity.Sdk