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
#nullable restore
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
using WebApplication1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TopFilmlist/{username}")]
    public partial class TopFilm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
       
    private IUserService userService;
    private IMovieService movieService;
    private int pageNumber = 1;
    private int pageSize = 20;
    [Parameter]
    public string username { set; get; }
    public IList<Movie> result = new List<Movie>();
    public IList<Movie> result1 = new List<Movie>();


  

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
  


    protected override  async Task OnInitializedAsync()
    {
        userService = new UserService();
        movieService = new CloudMovieService();

        try
        {

            IList<Movie> movies = await userService.getMovieList(username);
            Console.WriteLine("movies " + movies[1].title);
            result1 = movies;
            Console.WriteLine("result1 " + result1[1].title);
            Console.WriteLine("test result is " + 2 / 10);
            HandleChangePage(result1.Count / pageSize);
           

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public void GetDetails(Movie item)
    {
        int id = item.id;
        Console.WriteLine(id);
        NavigationManager.NavigateTo($"film/{id}/{username}");
    }

    void HandleChangePage(int p)
    {
        pageNumber = p;
        Console.WriteLine(" HandleChangePage result1 " + result1[1].title);

        result = new List<Movie>(result1.Skip((p - 1) * pageSize).Take(pageSize));
        Console.WriteLine("p is " + p);
        foreach (var item in result)
        {
            Console.WriteLine(item.title);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
