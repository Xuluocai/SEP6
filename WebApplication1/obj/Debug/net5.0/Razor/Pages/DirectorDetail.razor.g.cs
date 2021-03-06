#pragma checksum "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e62be1ec2148ea5dedb7711182fb612385d0cbf"
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
#line 2 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
using WebApplication1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DirectorDetail/{id}/{username}")]
    public partial class DirectorDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "filmInfo");
            __builder.AddMarkupContent(2, "<h4>Result</h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "fInfo");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 9 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
             name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "fInfo");
            __builder.AddMarkupContent(10, "<label>Birth</label>\r\n        ");
            __builder.OpenElement(11, "label");
            __builder.AddContent(12, 
#nullable restore
#line 14 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                birth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "fInfo");
            __builder.AddMarkupContent(16, "<label>Average Rating</label>\r\n        ");
            __builder.OpenElement(17, "label");
            __builder.AddContent(18, 
#nullable restore
#line 18 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "<thead><tr><th>Movies:</th>\r\n                <th>Year:</th></tr></thead>\r\n        ");
            __builder.OpenElement(23, "tbody");
#nullable restore
#line 28 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
             foreach (var item in movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "film/" + (
#nullable restore
#line 31 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                                   item.id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 31 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 32 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                         item.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 34 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
                         item.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
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
#line 41 "D:\Users\Knuse\source\repos\SEP6\WebApplication1\Pages\DirectorDetail.razor"
           
        public string name { set; get; }
        public int birth { set; get; }
        public double rating { set; get; }

        [Parameter]
        public string id { get; set; }
        [Parameter]
        public string username { set; get; }

        public int Id { set; get; }
        public IList<Movie> movies { set; get; } = new List<Movie>();

        private IMovieService movieService;

        protected override async Task OnInitializedAsync()
        {
            Id = int.Parse(id);


            try
            {

                Console.WriteLine(Id);
                movieService = new CloudMovieService();
                People people = await movieService.getPeopleById(Id);
                name = people.name;

                birth = people.birth;
                // Console.WriteLine("year is " + year);
                IList<Movie> movies1 = await movieService.getMoviesByDirector(Id);
                movies = movies1;


                for (int i = 0; i <= movies.Count; i++) {

                    double rating1 = await movieService.getRatingById(movies[1].id);
                    rating = rating + rating1;
                }

                rating = rating / (movies.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
