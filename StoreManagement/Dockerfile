#Prepare Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY *.csproj ./
#COPY *.csproj ./
#restore Libraries in distination Directory
RUN dotnet restore

#copy EveryThing
COPY . ./
#build and publish  release
RUN  dotnet publish -c release -o out


#build Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80
COPY  --from=build-env /app/out .
ENTRYPOINT [ "dotnet","StoreManagement.dll" ]