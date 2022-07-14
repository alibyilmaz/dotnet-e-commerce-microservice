FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY  FreeCourse.Gateway.API/*.csproj  FreeCourse.Gateway.API/
RUN dotnet restore FreeCourse.Gateway.API/*.csproj
COPY . .
RUN dotnet publish FreeCourse.Gateway.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCourse.Gateway.API.dll" ]