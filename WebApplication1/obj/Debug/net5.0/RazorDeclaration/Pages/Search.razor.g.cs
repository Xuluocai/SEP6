// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\Pages\Search.razor"
using WebApplication1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Users\Knuse\source\repos\WebApplication1\WebApplication1\Pages\Search.razor"
       
    public string filmname { set; get; }
    public string category { set; get; }
    public string starname { set; get; }
    public string message { set; get; }
    public List<Movie> result = new List<Movie>();

    public async Task search()
    {
      //  SearchFilm film = new SearchFilm()
     //   {
     //       filmname = this.filmname,
    //        category = this.category

    //    };
        //     result = movieService.searchMovies(film);
        NavigationManager.NavigateTo("/film");
    }

    public async Task clear()
    {
    }


    public void setCategory(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        category = result;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
