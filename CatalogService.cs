﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eShopWCFService.Models
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogItem", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    public partial class CatalogItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private eShopWCFService.Models.CatalogBrand CatalogBrandField;
        
        private int CatalogBrandIdField;
        
        private eShopWCFService.Models.CatalogType CatalogTypeField;
        
        private int CatalogTypeIdField;
        
        private string DescriptionField;
        
        private int IdField;
        
        private string NameField;
        
        private string PicturefilenameField;
        
        private decimal PriceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eShopWCFService.Models.CatalogBrand CatalogBrand
        {
            get
            {
                return this.CatalogBrandField;
            }
            set
            {
                this.CatalogBrandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogBrandId
        {
            get
            {
                return this.CatalogBrandIdField;
            }
            set
            {
                this.CatalogBrandIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eShopWCFService.Models.CatalogType CatalogType
        {
            get
            {
                return this.CatalogTypeField;
            }
            set
            {
                this.CatalogTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogTypeId
        {
            get
            {
                return this.CatalogTypeIdField;
            }
            set
            {
                this.CatalogTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Picturefilename
        {
            get
            {
                return this.PicturefilenameField;
            }
            set
            {
                this.PicturefilenameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogBrand", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    public partial class CatalogBrand : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string BrandField;
        
        private int IdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand
        {
            get
            {
                return this.BrandField;
            }
            set
            {
                this.BrandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogType", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    public partial class CatalogType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string TypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiscountItem", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    public partial class DiscountItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime EndField;
        
        private int IdField;
        
        private double SizeField;
        
        private System.DateTime StartField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime End
        {
            get
            {
                return this.EndField;
            }
            set
            {
                this.EndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Size
        {
            get
            {
                return this.SizeField;
            }
            set
            {
                this.SizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start
        {
            get
            {
                return this.StartField;
            }
            set
            {
                this.StartField = value;
            }
        }
    }
}
namespace eShopWCFService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogItemsStock", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService")]
    public partial class CatalogItemsStock : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AvailableStockField;
        
        private int CatalogItemIdField;
        
        private System.DateTime DateField;
        
        private int StockIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AvailableStock
        {
            get
            {
                return this.AvailableStockField;
            }
            set
            {
                this.AvailableStockField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogItemId
        {
            get
            {
                return this.CatalogItemIdField;
            }
            set
            {
                this.CatalogItemIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StockId
        {
            get
            {
                return this.StockIdField;
            }
            set
            {
                this.StockIdField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICatalogService")]
public interface ICatalogService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/FindCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/FindCatalogItemResponse")]
    eShopWCFService.Models.CatalogItem FindCatalogItem(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/FindCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/FindCatalogItemResponse")]
    System.Threading.Tasks.Task<eShopWCFService.Models.CatalogItem> FindCatalogItemAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogBrands", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogBrandsResponse")]
    eShopWCFService.Models.CatalogBrand[] GetCatalogBrands();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogBrands", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogBrandsResponse")]
    System.Threading.Tasks.Task<eShopWCFService.Models.CatalogBrand[]> GetCatalogBrandsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogItems", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogItemsResponse")]
    eShopWCFService.Models.CatalogItem[] GetCatalogItems(int brandIdFilter, int typeIdFilter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogItems", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogItemsResponse")]
    System.Threading.Tasks.Task<eShopWCFService.Models.CatalogItem[]> GetCatalogItemsAsync(int brandIdFilter, int typeIdFilter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogTypes", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogTypesResponse")]
    eShopWCFService.Models.CatalogType[] GetCatalogTypes();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogTypes", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogTypesResponse")]
    System.Threading.Tasks.Task<eShopWCFService.Models.CatalogType[]> GetCatalogTypesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
    int GetAvailableStock(System.DateTime date, int catalogItemId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
    System.Threading.Tasks.Task<int> GetAvailableStockAsync(System.DateTime date, int catalogItemId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
    void CreateAvailableStock(eShopWCFService.CatalogItemsStock catalogItemsStock);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
    System.Threading.Tasks.Task CreateAvailableStockAsync(eShopWCFService.CatalogItemsStock catalogItemsStock);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/CreateCatalogItemResponse")]
    void CreateCatalogItem(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/CreateCatalogItemResponse")]
    System.Threading.Tasks.Task CreateCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/UpdateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/UpdateCatalogItemResponse")]
    void UpdateCatalogItem(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/UpdateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/UpdateCatalogItemResponse")]
    System.Threading.Tasks.Task UpdateCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/RemoveCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/RemoveCatalogItemResponse")]
    void RemoveCatalogItem(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/RemoveCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/RemoveCatalogItemResponse")]
    System.Threading.Tasks.Task RemoveCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetDiscount", ReplyAction="http://tempuri.org/ICatalogService/GetDiscountResponse")]
    eShopWCFService.Models.DiscountItem GetDiscount(System.DateTime day);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetDiscount", ReplyAction="http://tempuri.org/ICatalogService/GetDiscountResponse")]
    System.Threading.Tasks.Task<eShopWCFService.Models.DiscountItem> GetDiscountAsync(System.DateTime day);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICatalogServiceChannel : ICatalogService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CatalogServiceClient : System.ServiceModel.ClientBase<ICatalogService>, ICatalogService
{
    
    public CatalogServiceClient()
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CatalogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public eShopWCFService.Models.CatalogItem FindCatalogItem(int id)
    {
        return base.Channel.FindCatalogItem(id);
    }
    
    public System.Threading.Tasks.Task<eShopWCFService.Models.CatalogItem> FindCatalogItemAsync(int id)
    {
        return base.Channel.FindCatalogItemAsync(id);
    }
    
    public eShopWCFService.Models.CatalogBrand[] GetCatalogBrands()
    {
        return base.Channel.GetCatalogBrands();
    }
    
    public System.Threading.Tasks.Task<eShopWCFService.Models.CatalogBrand[]> GetCatalogBrandsAsync()
    {
        return base.Channel.GetCatalogBrandsAsync();
    }
    
    public eShopWCFService.Models.CatalogItem[] GetCatalogItems(int brandIdFilter, int typeIdFilter)
    {
        return base.Channel.GetCatalogItems(brandIdFilter, typeIdFilter);
    }
    
    public System.Threading.Tasks.Task<eShopWCFService.Models.CatalogItem[]> GetCatalogItemsAsync(int brandIdFilter, int typeIdFilter)
    {
        return base.Channel.GetCatalogItemsAsync(brandIdFilter, typeIdFilter);
    }
    
    public eShopWCFService.Models.CatalogType[] GetCatalogTypes()
    {
        return base.Channel.GetCatalogTypes();
    }
    
    public System.Threading.Tasks.Task<eShopWCFService.Models.CatalogType[]> GetCatalogTypesAsync()
    {
        return base.Channel.GetCatalogTypesAsync();
    }
    
    public int GetAvailableStock(System.DateTime date, int catalogItemId)
    {
        return base.Channel.GetAvailableStock(date, catalogItemId);
    }
    
    public System.Threading.Tasks.Task<int> GetAvailableStockAsync(System.DateTime date, int catalogItemId)
    {
        return base.Channel.GetAvailableStockAsync(date, catalogItemId);
    }
    
    public void CreateAvailableStock(eShopWCFService.CatalogItemsStock catalogItemsStock)
    {
        base.Channel.CreateAvailableStock(catalogItemsStock);
    }
    
    public System.Threading.Tasks.Task CreateAvailableStockAsync(eShopWCFService.CatalogItemsStock catalogItemsStock)
    {
        return base.Channel.CreateAvailableStockAsync(catalogItemsStock);
    }
    
    public void CreateCatalogItem(eShopWCFService.Models.CatalogItem catalogItem)
    {
        base.Channel.CreateCatalogItem(catalogItem);
    }
    
    public System.Threading.Tasks.Task CreateCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem)
    {
        return base.Channel.CreateCatalogItemAsync(catalogItem);
    }
    
    public void UpdateCatalogItem(eShopWCFService.Models.CatalogItem catalogItem)
    {
        base.Channel.UpdateCatalogItem(catalogItem);
    }
    
    public System.Threading.Tasks.Task UpdateCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem)
    {
        return base.Channel.UpdateCatalogItemAsync(catalogItem);
    }
    
    public void RemoveCatalogItem(eShopWCFService.Models.CatalogItem catalogItem)
    {
        base.Channel.RemoveCatalogItem(catalogItem);
    }
    
    public System.Threading.Tasks.Task RemoveCatalogItemAsync(eShopWCFService.Models.CatalogItem catalogItem)
    {
        return base.Channel.RemoveCatalogItemAsync(catalogItem);
    }
    
    public eShopWCFService.Models.DiscountItem GetDiscount(System.DateTime day)
    {
        return base.Channel.GetDiscount(day);
    }
    
    public System.Threading.Tasks.Task<eShopWCFService.Models.DiscountItem> GetDiscountAsync(System.DateTime day)
    {
        return base.Channel.GetDiscountAsync(day);
    }
}
