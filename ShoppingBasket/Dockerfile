FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ShoppingBasket/ShoppingBasket.csproj", "ShoppingBasket/"]
RUN dotnet restore "ShoppingBasket/ShoppingBasket.csproj"
COPY . .
WORKDIR "/src/ShoppingBasket"
RUN dotnet build "ShoppingBasket.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingBasket.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingBasket.dll"]
