#!/bin/bash

export IMAGE_TAG="1.0.0"
export total=12
cd ../
export currentFolder=`pwd`
cd build/


echo "*** BUILDING WEB (WWW) 1/${total} ****************"
cd ${currentFolder}/apps/angular
yarn
# ng build --prod
npm run build:prod
docker build -f Dockerfile.local --force-rm -t "NPEICloud/app-web:${IMAGE_TAG}" .


echo "*** BUILDING AUTH-SERVER 2/$total ****************"
cd ${currentFolder}/apps/auth-server/src/NPEICloud.AuthServer
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/app-authserver:${IMAGE_TAG}" .


echo "*** BUILDING WEB-PUBLIC 3/$total ****************"
cd ${currentFolder}/apps/public-web/src/NPEICloud.PublicWeb
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/app-publicweb:${IMAGE_TAG}" .


echo "*** BUILDING WEB-GATEWAY 4/$total ****************"
cd ${currentFolder}/gateways/web/src/NPEICloud.WebGateway
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/gateway-web:${IMAGE_TAG}" .


echo "*** BUILDING WEB-PUBLIC-GATEWAY 5/$total ****************"
cd ${currentFolder}/gateways/web-public/src/NPEICloud.WebPublicGateway
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/gateway-web-public:${IMAGE_TAG}" .


echo "*** BUILDING IDENTITY-SERVICE 6/$total ****************"
cd ${currentFolder}/services/identity/src/NPEICloud.IdentityService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-identity:${IMAGE_TAG}" .


echo "*** BUILDING ADMINISTRATION-SERVICE 7/$total ****************"
cd ${currentFolder}/services/administration/src/NPEICloud.AdministrationService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-administration:${IMAGE_TAG}" .


echo "**************** BUILDING BASKET-SERVICE 8/$total ****************"
cd ${currentFolder}/services/basket/src/NPEICloud.BasketService
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-basket:${IMAGE_TAG}" .


echo "**************** BUILDING CATALOG-SERVICE 9/$total ****************"
cd ${currentFolder}/services/catalog/src/NPEICloud.CatalogService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-catalog:${IMAGE_TAG}" .


echo "**************** BUILDING PAYMENT-SERVICE 10/$total ****************"
cd ${currentFolder}/services/payment/src/NPEICloud.PaymentService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-payment:${IMAGE_TAG}" .


echo "**************** BUILDING ORDERING-SERVICE 11/$total ****************"
cd ${currentFolder}/services/ordering/src/NPEICloud.OrderingService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-ordering:${IMAGE_TAG}" .

echo "**************** BUILDING CMSKIT-SERVICE 12/$total ****************"
cd ${currentFolder}/services/cmskit/src/NPEICloud.CmskitService.HttpApi.Host
dotnet publish -c Release
docker build -f Dockerfile.local --force-rm -t "NPEICloud/service-cmskit:${IMAGE_TAG}" .

echo "ALL COMPLETED"