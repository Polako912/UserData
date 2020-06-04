#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 50001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["UserData/UserData.csproj", "UserData/"]
COPY ["UserData.Application/UserData.Application.csproj", "UserData.Application/"]
COPY ["UserData.Core/UserData.Core.csproj", "UserData.Core/"]
COPY ["UserData.Persistence/UserData.Persistence.csproj", "UserData.Persistence/"]
RUN dotnet restore "UserData/UserData.csproj"
COPY . .
WORKDIR "/src/UserData"
RUN dotnet build "UserData.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserData.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserData.dll"]