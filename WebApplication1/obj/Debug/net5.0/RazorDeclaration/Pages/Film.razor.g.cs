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
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
using WebApplication1.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/film/{id}/{username}")]
    public partial class Film : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\Film.razor"
       

    private IMovieService movieService;
    private IUserService userService;
    private Movielist movielist;
    public string title { set; get; }
    public int year { set; get; }
    public double rating { set; get; } = new double();
    public double votes { set; get; } = new double();

    [Parameter]
    public string id { get; set; }
    [Parameter]
    public string username { set; get; }

    public int Id { set; get; }


    public IList<People> filmStars { set; get; } = new List<People>();
    public IList<People> directors { set; get; } = new List<People>();
    public IList<Movie> movies { set; get; } = new List<Movie>();


    public async void addFilm()
    {

        try
        {
            movielist = new Movielist(username,Id);

            Console.WriteLine("this is" + movielist.username);
            await userService.addMovieToList(movielist);
            Console.WriteLine("123");
            NavigationManager.NavigateTo($"/TopFilmlist/{username}");
        }
        catch (Exception e)
        {

        }

    }

    protected  override  async Task OnInitializedAsync()
    {
        Id = int.Parse(id);


        try
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(Id);
            movieService = new CloudMovieService();
            userService = new UserService();
            Movie movie = await movieService.getMovieById(Id);
            title = movie.title;
            Console.WriteLine("title is "+title);
            rating = await movieService.getRatingById(Id);
            votes = await movieService.getVotesById(Id);
            year = movie.year;
            Console.WriteLine("year is "+ year);
            directors = await movieService.getDirectorsById(Id);

            filmStars = await movieService.getStasById(Id);

            movies = await movieService.getMoviesByTitle(title);
            Console.WriteLine("this is" + movies[0].title);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMovieService MovieService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
