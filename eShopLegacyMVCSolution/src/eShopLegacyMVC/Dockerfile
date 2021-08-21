#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019 AS base  
WORKDIR "/inetpub/wwwroot"  
EXPOSE 80  
EXPOSE 443  


FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019 AS build  
WORKDIR "/src"  
COPY ["eShopLegacyMVC.csproj", "eShopLegacyMVC/"]  


RUN dotnet restore "eShopLegacyMVC/eShopLegacyMVC.csproj"  
COPY . .  
WORKDIR "/src/eShopLegacy"  
RUN dotnet build "eShopLegacy.csproj" -c Release -o /app/build  


FROM build AS publish  
RUN dotnet publish "eShopLegacy.csproj" -c Release -o /app/publish  
FROM base AS final  
WORKDIR /app  
COPY --from=publish /app/publish .  
#ENTRYPOINT ["dotnet", "CustomerApi.dll"]  



