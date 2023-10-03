export version="1.0.5"

az acr login --name volocr

docker tag NPEICloud/app-web:"${version}" volocr.azurecr.io/NPEICloud/app-web:"${version}"
docker push volocr.azurecr.io/NPEICloud/app-web:"${version}"

docker tag NPEICloud/app-authserver:"${version}" volocr.azurecr.io/NPEICloud/app-authserver:"${version}"
docker push volocr.azurecr.io/NPEICloud/app-authserver:"${version}"

docker tag NPEICloud/app-publicweb:"${version}" volocr.azurecr.io/NPEICloud/app-publicweb:"${version}"
docker push volocr.azurecr.io/NPEICloud/app-publicweb:"${version}"

docker tag NPEICloud/gateway-web:"${version}" volocr.azurecr.io/NPEICloud/gateway-web:"${version}"
docker push volocr.azurecr.io/NPEICloud/gateway-web:"${version}"

docker tag NPEICloud/gateway-web-public:"${version}" volocr.azurecr.io/NPEICloud/gateway-web-public:"${version}"
docker push volocr.azurecr.io/NPEICloud/gateway-web-public:"${version}"

docker tag NPEICloud/service-identity:"${version}" volocr.azurecr.io/NPEICloud/service-identity:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-identity:"${version}"

docker tag NPEICloud/service-administration:"${version}" volocr.azurecr.io/NPEICloud/service-administration:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-administration:"${version}"

docker tag NPEICloud/service-basket:"${version}" volocr.azurecr.io/NPEICloud/service-basket:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-basket:"${version}"

docker tag NPEICloud/service-catalog:"${version}" volocr.azurecr.io/NPEICloud/service-catalog:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-catalog:"${version}"

docker tag NPEICloud/service-ordering:"${version}" volocr.azurecr.io/NPEICloud/service-ordering:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-ordering:"${version}"

docker tag NPEICloud/service-cmskit:"${version}" volocr.azurecr.io/NPEICloud/service-cmskit:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-cmskit:"${version}"

docker tag NPEICloud/service-payment:"${version}" volocr.azurecr.io/NPEICloud/service-payment:"${version}"
docker push volocr.azurecr.io/NPEICloud/service-payment:"${version}"