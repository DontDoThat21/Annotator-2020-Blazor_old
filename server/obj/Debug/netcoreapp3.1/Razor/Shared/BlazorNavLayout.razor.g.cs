#pragma checksum "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082ce3d0e45bb9a864c78e8c5a242fa87c39b5b9"
// <auto-generated/>
#pragma warning disable 1591
namespace Anno.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Anno.Shared;

#line default
#line hidden
#line 3 "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor"
using Anno.Models.Sample;

#line default
#line hidden
    public partial class BlazorNavLayout : Anno.Layouts.BlazorNavLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(15);
                __builder2.AddAttribute(16, "Text", "Annotator 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.AddMarkupContent(19, "<div class=\"col-md-6 text-lg-right\">\n      </div>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.AddMarkupContent(23, "\n      ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-12");
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenu>(27);
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(30);
                    __builder3.AddAttribute(31, "Text", "ShowPlans");
                    __builder3.AddAttribute(32, "Path", "show-plans");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(34);
                    __builder3.AddAttribute(35, "Text", "Engineering Drawings");
                    __builder3.AddAttribute(36, "Path", "engineering-drawings");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(38);
                    __builder3.AddAttribute(39, "Text", "Orders");
                    __builder3.AddAttribute(40, "Path", "orders");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(42);
                    __builder3.AddAttribute(43, "Text", "Order Details");
                    __builder3.AddAttribute(44, "Path", "order-details");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(46);
                    __builder3.AddAttribute(47, "Text", "Products");
                    __builder3.AddAttribute(48, "Path", "products");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(54);
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(57);
                __builder2.AddAttribute(58, "Name", "main");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "\n    ");
                    __builder3.AddContent(61, 
#line 44 "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(62, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(64, (__value) => {
#line 41 "C:\Users\Tylor\Desktop\AnnoPages\server\Shared\BlazorNavLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(66);
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(69);
                __builder2.AddAttribute(70, "Text", "Anno, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
