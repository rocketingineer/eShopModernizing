az-aks-win-deploy.ps1

az group create --name rg-eshop-demo --location centralus

$rg = "rg-eshop-demo"
$vnetName = "vnet-tmc-shop-kube"
$snetName = "snet-tmc-shop-kube"
$laname = "la-tmc-shop"

az provider show -n Microsoft.OperationsManagement -o table
az provider show -n Microsoft.OperationalInsights -o table
az provider register --namespace Microsoft.OperationsManagement
az provider register --namespace Microsoft.OperationalInsights

#  Create a virtual network with a front-end subnet
az network vnet create `
  --name $vnetName `
  --resource-group $rg `
  --address-prefix 172.20.10.0/24 `
  --subnet-name $snetName `
  --subnet-prefix 172.20.10.0/25


 az network vnet subnet list `
    --resource-group $rg `
    --vnet-name $vnetname `
    --query "[0].id" --output tsv

$SubnetID = "/subscriptions/2f6a75ae-9e86-49d6-8782-56786af2bfe0/resourceGroups/rg-eshop-demo/providers/Microsoft.Network/virtualNetworks/vnet-tmc-shop-kube/subnets/snet-tmc-shop-kube"



az ad sp create-for-rbac --skip-assignment --name eShopKubeSPN


az monitor log-analytics workspace create -g $rg -n $laname --no-wait

az aks create `
    --resource-group rg-eshop-demo `
    --name aks-tmc-shop `
    --vm-set-type VirtualMachineScaleSets `
    --network-plugin azure `
    --vnet-subnet-id $SubnetID `
    --docker-bridge-address 172.17.0.1/16 `
    --dns-service-ip 10.2.0.10 `
    --service-cidr 10.2.0.0/24 `
    --generate-ssh-keys `
    --service-principal 8eb2ff2a-8c0f-4fdb-aa39-b1c1a03d7fb5 `
    --client-secret 0W6O43hVKsRb_ei~NVXU0CuIn1oeK_c4Pm `
    --node-count 1 
    

    

az aks get-credentials --resource-group myResourceGroup --name myAKSCluster