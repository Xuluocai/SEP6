#pragma checksum "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93b79fec327e7878ce4fdcd7008deacd23d209a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>The toplists of your favorite movies</h1>\r\n\r\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "href", "search/" + (
#nullable restore
#line 7 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                 username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "up");
            __builder.AddContent(4, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Movies:</th>\r\n            <th>Year:</th></tr></thead>\r\n    ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 16 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
         foreach (var item in result)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "film/" + (
#nullable restore
#line 20 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                               item.id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 20 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                                        username

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 21 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                     item.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 22 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                     item.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "ul");
#nullable restore
#line 28 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
             for (int a = 1; a <= result1.Count() / pageSize; a++)
            {
                int p = a;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                                                (e=>HandleChangePage(p))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, 
#nullable restore
#line 32 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"
                                                                           p

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\TopFilm.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
