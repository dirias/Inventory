#pragma checksum "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Categories\CreateCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b4148274b9bf95deb3ccd976931ce0e3038a557"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.Categories
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
#line 1 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Categories\CreateCategoryComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Categories\CreateCategoryComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class CreateCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Categories\CreateCategoryComponent.razor"
       
    CategoryEntity category = new CategoryEntity();
    private void SaveChanges()
    {
        B_Category.CreateCategory(category);
        NavManager.NavigateTo("category/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
