export version="1.0.0"

az acr login --name volocr

docker tag NPEICloud/app-web:"${version}" ghcr.io/volosoft/NPEICloud/app-web:"${version}"
docker push ghcr.io/volosoft/NPEICloud/app-web:"${version}"

docker tag NPEICloud/app-authserver:"${version}" ghcr.io/volosoft/NPEICloud/app-authserver:"${version}"
docker push ghcr.io/volosoft/NPEICloud/app-authserver:"${version}"

docker tag NPEICloud/app-publicweb:"${version}" ghcr.io/volosoft/NPEICloud/app-publicweb:"${version}"
docker push ghcr.io/volosoft/NPEICloud/app-publicweb:"${version}"

docker tag NPEICloud/gateway-web:"${version}" ghcr.io/volosoft/NPEICloud/gateway-web:"${version}"
docker push ghcr.io/volosoft/NPEICloud/gateway-web:"${version}"

docker tag NPEICloud/gateway-web-public:"${version}" ghcr.io/volosoft/NPEICloud/gateway-web-public:"${version}"
docker push ghcr.io/volosoft/NPEICloud/gateway-web-public:"${version}"

docker tag NPEICloud/service-identity:"${version}" ghcr.io/volosoft/NPEICloud/service-identity:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-identity:"${version}"

docker tag NPEICloud/service-administration:"${version}" ghcr.io/volosoft/NPEICloud/service-administration:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-administration:"${version}"

docker tag NPEICloud/service-basket:"${version}" ghcr.io/volosoft/NPEICloud/service-basket:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-basket:"${version}"

docker tag NPEICloud/service-catalog:"${version}" ghcr.io/volosoft/NPEICloud/service-catalog:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-catalog:"${version}"

docker tag NPEICloud/service-ordering:"${version}" ghcr.io/volosoft/NPEICloud/service-ordering:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-ordering:"1.0.1"

docker tag NPEICloud/service-cmskit:"${version}" ghcr.io/volosoft/NPEICloud/service-cmskit:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-cmskit:"${version}"

docker tag NPEICloud/service-payment:"${version}" ghcr.io/volosoft/NPEICloud/service-payment:"${version}"
docker push ghcr.io/volosoft/NPEICloud/service-payment:"${version}"