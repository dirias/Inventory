#pragma checksum "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bc9eb3f260fd13f2d0d14b5577f944d387d379"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Products
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
#line 1 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Creación de Productos</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                     oProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<label>Referencia:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                    oProduct.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductId = __value, oProduct.ProductId))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<label>Nombre del producto:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                    oProduct.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductName = __value, oProduct.ProductName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.AddMarkupContent(32, "<label>Descripción:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                        oProduct.ProductDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductDescription = __value, oProduct.ProductDescription))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.AddMarkupContent(43, "<label>Categoría:</label>\r\n            ");
                __Blazor.Inventory.Components.Products.CreateProductComponent.TypeInference.CreateInputSelect_0(__builder2, 44, 45, "form-control", 46, 
#nullable restore
#line 22 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                      oProduct.CategoryId

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.CategoryId = __value, oProduct.CategoryId)), 48, () => oProduct.CategoryId, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n");
#nullable restore
#line 23 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                 foreach (var category in categories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(51, "                    ");
                    __builder3.OpenElement(52, "option");
                    __builder3.AddAttribute(53, "value", 
#nullable restore
#line 25 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                    category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(54, 
#nullable restore
#line 25 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                                          category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\r\n");
#nullable restore
#line 26 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(56, "            ");
                }
                );
                __builder2.AddMarkupContent(57, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "button");
                __builder2.AddAttribute(61, "name", "idButton");
                __builder2.AddAttribute(62, "value", "Agregar Producto");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
                                                                                SaveProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "class", "btn btn-success");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\didie\Source\Repos\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
       
    ProductEntity oProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();

    }
    private void SaveProduct()
    {
        P_Product.CreateProduct(oProduct);
        NavManager.NavigateTo("product/list");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.Inventory.Components.Products.CreateProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
