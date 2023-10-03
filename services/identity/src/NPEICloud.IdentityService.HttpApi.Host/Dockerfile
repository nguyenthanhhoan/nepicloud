FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# It's important to keep lines from here down to "COPY . ." identical in all Dockerfiles
# to take advantage of Docker's build cache, to speed up local container builds
COPY "NPEICloud.sln" "NPEICloud.sln"

# Applications
COPY "apps/auth-server/src/NPEICloud.AuthServer/NPEICloud.AuthServer.csproj" "apps/auth-server/src/NPEICloud.AuthServer/NPEICloud.AuthServer.csproj"
COPY "apps/public-web/src/NPEICloud.PublicWeb/NPEICloud.PublicWeb.csproj" "apps/public-web/src/NPEICloud.PublicWeb/NPEICloud.PublicWeb.csproj"

# Shared
COPY "shared/NPEICloud.Shared.Hosting/NPEICloud.Shared.Hosting.csproj" "shared/NPEICloud.Shared.Hosting/NPEICloud.Shared.Hosting.csproj"
COPY "shared/NPEICloud.Shared.Hosting.AspNetCore/NPEICloud.Shared.Hosting.AspNetCore.csproj" "shared/NPEICloud.Shared.Hosting.AspNetCore/NPEICloud.Shared.Hosting.AspNetCore.csproj"
COPY "shared/NPEICloud.Shared.Hosting.Gateways/NPEICloud.Shared.Hosting.Gateways.csproj" "shared/NPEICloud.Shared.Hosting.Gateways/NPEICloud.Shared.Hosting.Gateways.csproj"
COPY "shared/NPEICloud.Shared.Hosting.Microservices/NPEICloud.Shared.Hosting.Microservices.csproj" "shared/NPEICloud.Shared.Hosting.Microservices/NPEICloud.Shared.Hosting.Microservices.csproj"
COPY "shared/NPEICloud.Shared.Localization/NPEICloud.Shared.Localization.csproj" "shared/NPEICloud.Shared.Localization/NPEICloud.Shared.Localization.csproj"

# Microservices
COPY "services/administration/src/NPEICloud.AdministrationService.HttpApi.Host/NPEICloud.AdministrationService.HttpApi.Host.csproj" "services/administration/src/NPEICloud.AdministrationService.HttpApi.Host/NPEICloud.AdministrationService.HttpApi.Host.csproj"
COPY "services/identity/src/NPEICloud.IdentityService.HttpApi.Host/NPEICloud.IdentityService.HttpApi.Host.csproj" "services/identity/src/NPEICloud.IdentityService.HttpApi.Host/NPEICloud.IdentityService.HttpApi.Host.csproj"
COPY "services/basket/src/NPEICloud.BasketService/NPEICloud.BasketService.csproj" "services/basket/src/NPEICloud.BasketService/NPEICloud.BasketService.csproj"
COPY "services/ordering/src/NPEICloud.OrderingService.HttpApi.Host/NPEICloud.OrderingService.HttpApi.Host.csproj" "services/ordering/src/NPEICloud.OrderingService.HttpApi.Host/NPEICloud.OrderingService.HttpApi.Host.csproj"
COPY "services/catalog/src/NPEICloud.CatalogService.HttpApi.Host/NPEICloud.CatalogService.HttpApi.Host.csproj" "services/catalog/src/NPEICloud.CatalogService.HttpApi.Host/NPEICloud.CatalogService.HttpApi.Host.csproj"
COPY "services/payment/src/NPEICloud.PaymentService.HttpApi.Host/NPEICloud.PaymentService.HttpApi.Host.csproj" "services/payment/src/NPEICloud.PaymentService.HttpApi.Host/NPEICloud.PaymentService.HttpApi.Host.csproj"
COPY "services/cmskit/src/NPEICloud.CmskitService.HttpApi.Host/NPEICloud.CmskitService.HttpApi.Host.csproj" "services/cmskit/src/NPEICloud.CmskitService.HttpApi.Host/NPEICloud.CmskitService.HttpApi.Host.csproj"

# Gateways
COPY "gateways/web/src/NPEICloud.WebGateway/NPEICloud.WebGateway.csproj" "gateways/web/src/NPEICloud.WebGateway/NPEICloud.WebGateway.csproj"
COPY "gateways/web-public/src/NPEICloud.WebPublicGateway/NPEICloud.WebPublicGateway.csproj" "gateways/web-public/src/NPEICloud.WebPublicGateway/NPEICloud.WebPublicGateway.csproj"

COPY "NuGet.Config" "NuGet.Config"

RUN dotnet restore "NPEICloud.sln"
COPY . .

WORKDIR "/src/services/identity/src/NPEICloud.IdentityService.HttpApi.Host"
RUN dotnet publish -c Release -o /app 
# RUN dotnet publish --no-restore -c Release -o /app 

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NPEICloud.IdentityService.HttpApi.Host.dll"]