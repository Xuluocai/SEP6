#pragma checksum "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6cf7c23a5e3982523ee67e91fc45a3f4fc8ffc"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-zdjklf0x7f");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav flex-column");
            __builder.AddAttribute(6, "b-zdjklf0x7f");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "nav-item px-3");
            __builder.AddAttribute(9, "b-zdjklf0x7f");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "nav-link");
            __builder.AddAttribute(12, "href", "");
            __builder.AddAttribute(13, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-zdjklf0x7f></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-zdjklf0x7f");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "/");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-zdjklf0x7f></span> LogOut\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
