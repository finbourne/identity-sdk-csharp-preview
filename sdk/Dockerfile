FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Identity.Sdk.sln /usr/src/
COPY Finbourne.Identity.Sdk/Finbourne.Identity.Sdk.csproj /usr/src/Finbourne.Identity.Sdk/
RUN dotnet restore Finbourne.Identity.Sdk

ENV FBN_IDENTITY_API_URL ${FBN_IDENTITY_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Identity.Sdk