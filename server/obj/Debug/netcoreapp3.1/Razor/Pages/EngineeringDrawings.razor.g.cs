#pragma checksum "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\EngineeringDrawings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44bdd4fc3f1dafc1af68345f16e243a1265b976e"
// <auto-generated/>
#pragma warning disable 1591
namespace Anno.Pages
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
#line 5 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\EngineeringDrawings.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\EngineeringDrawings.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\EngineeringDrawings.razor"
using Anno.Models.Sample;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/engineering-drawings")]
    public partial class EngineeringDrawings : Anno.Pages.EngineeringDrawingsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Engineering Drawings");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
