param ($version='1.0.0')

$currentFolder = $PSScriptRoot
$slnFolder = Join-Path $currentFolder "../"
# Apps
$webAppFolder = Join-Path $slnFolder "apps/angular"
$authserverFolder = Join-Path $slnFolder "apps/auth-server/src/NPEICloud.AuthServer"
$publicWebFolder = Join-Path $slnFolder "apps/public-web/src/NPEICloud.PublicWeb"
# Gateways
$webGatewayFolder = Join-Path $slnFolder "gateways/web/src/NPEICloud.WebGateway"
$webPublicGatewayFolder = Join-Path $slnFolder "gateways/web-public/src/NPEICloud.WebPublicGateway"
# Microservices
$identityServiceFolder = Join-Path $slnFolder "services/identity/src/NPEICloud.IdentityService.HttpApi.Host"
$administrationServiceFolder = Join-Path $slnFolder "services/administration/src/NPEICloud.AdministrationService.HttpApi.Host"
$basketServiceFolder = Join-Path $slnFolder "services/basket/src/NPEICloud.BasketService"
$catalogServiceFolder = Join-Path $slnFolder "services/catalog/src/NPEICloud.CatalogService.HttpApi.Host"
$paymentServiceFolder = Join-Path $slnFolder "services/payment/src/NPEICloud.PaymentService.HttpApi.Host"
$orderingServiceFolder = Join-Path $slnFolder "services/ordering/src/NPEICloud.OrderingService.HttpApi.Host"
$cmskitServiceFolder = Join-Path $slnFolder "services/cmskit/src/NPEICloud.CmskitService.HttpApi.Host"

$total = 12

Write-Host "===== BUILDING APPLICATIONS =====" -ForegroundColor Yellow

### Angular WEB App
Write-Host "*** BUILDING ANGULAR WEB APPLICATION 1/$total ***" -ForegroundColor Green
Set-Location $webAppFolder
docker build -f "$webAppFolder/Dockerfile" -t NPEICloud/app-web:$version .

### AUTH-SERVER
Write-Host "**************** BUILDING AUTH-SERVER 2/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$authserverFolder/Dockerfile" -t NPEICloud/app-authserver:$version .

### PUBLIC-WEB
Write-Host "**************** BUILDING WEB-PUBLIC 3/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$publicWebFolder/Dockerfile" -t NPEICloud/app-publicweb:$version .

Write-Host "===== BUILDING GATEWAYS =====" -ForegroundColor Yellow 

### WEB-GATEWAY
Write-Host "**************** BUILDING WEB-GATEWAY 4/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$webGatewayFolder/Dockerfile" -t NPEICloud/gateway-web:$version .

### PUBLICWEB-GATEWAY
Write-Host "**************** BUILDING WEB-PUBLIC-GATEWAY 5/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$webPublicGatewayFolder/Dockerfile" -t NPEICloud/gateway-web-public:$version .

Write-Host "===== BUILDING MICROSERVICES =====" -ForegroundColor Yellow

### IDENTITY-SERVICE
Write-Host "**************** BUILDING IDENTITY-SERVICE 6/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$identityServiceFolder/Dockerfile" -t NPEICloud/service-identity:$version .

### ADMINISTRATION-SERVICE
Write-Host "**************** BUILDING ADMINISTRATION-SERVICE 7/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$administrationServiceFolder/Dockerfile" -t NPEICloud/service-administration:$version .

### BASKET-SERVICE
Write-Host "**************** BUILDING BASKET-SERVICE 8/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$basketServiceFolder/Dockerfile" -t NPEICloud/service-basket:$version .

### CATALOG-SERVICE
Write-Host "**************** BUILDING CATALOG-SERVICE 9/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$catalogServiceFolder/Dockerfile" -t NPEICloud/service-catalog:$version .

### PAYMENT-SERVICE
Write-Host "**************** BUILDING PAYMENT-SERVICE 10/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$paymentServiceFolder/Dockerfile" -t NPEICloud/service-payment:$version .

### ORDERING-SERVICE
Write-Host "**************** BUILDING ORDERING-SERVICE 11/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$orderingServiceFolder/Dockerfile" -t NPEICloud/service-ordering:$version .

### CMSKIT-SERVICE
Write-Host "**************** BUILDING CMSKIT-SERVICE 12/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$cmskitServiceFolder/Dockerfile" -t NPEICloud/service-cmskit:$version .

### ALL COMPLETED
Write-Host "ALL COMPLETED" -ForegroundColor Green
Set-Location $currentFolder