#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/framework/aspnet:5.0 AS base  
WORKDIR "/inetpub/wwwroot"  
EXPOSE 80  
EXPOSE 443  


FROM mcr.microsoft.com/dotnet/framework/sdk:5.0 AS build  
WORKDIR "/src"  
COPY ["./eShopLegacyMVC.csproj", "eShopLegacyMVC/"]  
RUN dotnet restore "eShopLegacyMVC/eShopLegacyMVC.csproj"  
COPY . .  
WORKDIR "/src/eShopLegacyMVC"  
RUN dotnet build "eShopLegacyMVC.csproj" -c Release -o /app/build  


FROM build AS publish  
RUN dotnet publish "eShopLegacyMVC.csproj" -c Release -o /app/publish  
FROM base AS final  
WORKDIR /app  
COPY --from=publish /app/publish .  
#ENTRYPOINT ["dotnet", "CustomerApi.dll"]  



