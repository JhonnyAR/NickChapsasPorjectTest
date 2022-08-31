FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NickChapsas/NickChapsas.csproj", "NickChapsas/"]
RUN dotnet restore "NickChapsas/NickChapsas.csproj"
COPY . .
WORKDIR "/src/NickChapsas"
RUN dotnet build "NickChapsas.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NickChapsas.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NickChapsas.dll"]
