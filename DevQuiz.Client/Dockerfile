#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DevQuiz.Client/DevQuiz.Client.csproj", "DevQuiz.Client/"]
RUN dotnet restore "DevQuiz.Client/DevQuiz.Client.csproj"
COPY . .
WORKDIR "/src/DevQuiz.Client"
RUN dotnet build "DevQuiz.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevQuiz.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevQuiz.Client.dll"]