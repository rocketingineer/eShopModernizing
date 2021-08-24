#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base  
WORKDIR "/app"  
EXPOSE 80  
EXPOSE 443  


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build  

WORKDIR "/src"
COPY . "eShopLegacyMVCSolution/"
RUN dotnet restore "eShopLegacyMVC.sln" 

WORKDIR "/src"  
COPY ["eShopLegacyMVC.csproj", "eShopLegacyMVC/"]  
 
COPY . .  
WORKDIR "/src/eShopLegacyMVC"  
#RUN dotnet build "eShopLegacyMVC.csproj" -c Release -o /app/build  

RUN dotnet build eShopLegacyMVCSolution/src/eShopLegacyMVC/eShopLegacyMVC.csproj /nologo /p:PublishProfile=FolderProfile.pubxml /p:DeployOnBuild=true /p:docker_publish_root=..\..\..\deploy\mvc\


FROM build AS publish  
RUN dotnet publish "eShopLegacyMVC.csproj" -c Release -o /app/publish  
FROM base AS final  
WORKDIR /app  
COPY --from=publish /app/publish .  




