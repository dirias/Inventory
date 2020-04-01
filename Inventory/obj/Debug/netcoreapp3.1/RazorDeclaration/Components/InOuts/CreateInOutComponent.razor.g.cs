#pragma checksum "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ad7efb8d85b0ff3395e20fb7ed4251e790a8991"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.InOuts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Tasks.Blazor_Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Tasks.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\didie\Source\Repos\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
       
    InOutEntity InOut = new InOutEntity();
    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();
    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();
    string msg = "";
    string btnValue => InOut.IsInput ? "Registrar entrada" : "Registrar salida";
    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WarehouseList();
    }
    private void OnChangeWarehouse(ChangeEventArgs e)
    {
        var idWarehouse = e.Value.ToString();
        storages = B_Storage.StorageProductsByWarehouseList(idWarehouse);
    }
    private void SaveInOut()
    {
        oStorage = storages.LastOrDefault(x => x.StorageId == InOut.StorageId);
        oProduct = oStorage.Product;

        if (InOut.IsInput)
        {
            oStorage.PartialQuantity = oStorage.PartialQuantity + InOut.InOutQuantity;
            B_Storage.UpdateStorage(oStorage);

            oProduct.TotalQuantity = oProduct.TotalQuantity + InOut.InOutQuantity;
            P_Product.UpdateProduct(oProduct);
            msg = $"El producto {oProduct.ProductName} ha sido actualizado";
        }
        else
        {
            if (IsBiggerThanZero(InOut.InOutQuantity, oStorage.PartialQuantity))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - InOut.InOutQuantity;
                B_Storage.UpdateStorage(oStorage);

                oProduct.TotalQuantity = oProduct.TotalQuantity - InOut.InOutQuantity;
                P_Product.UpdateProduct(oProduct);
                msg = $"El producto {oProduct.ProductName} ha sido actualizado";
            }
            else
            {
                msg = $"No existe la cantidad suficiente en bodega para el producto: {oProduct.ProductName}";
            }
        }
    }

    private bool IsBiggerThanZero(int quantity, int storageQuantity)
    {
        if (storageQuantity > quantity)
        {
            return true;
        }
        return false;

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
