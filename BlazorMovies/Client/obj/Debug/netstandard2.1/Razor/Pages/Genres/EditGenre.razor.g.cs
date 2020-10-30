#pragma checksum "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395296659c393993545527cd5747d775946f277e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Genres
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/genre/edit/{GenreId:int}")]
    public partial class EditGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditGenre</h3>\r\n\r\n");
#nullable restore
#line 7 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor"
 if (genre != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorMovies.Client.Pages.Genres.GenreForm>(2);
            __builder.AddAttribute(3, "Genre", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Genre>(
#nullable restore
#line 9 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor"
                      genre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor"
                                            Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\EditGenre.razor"
       
    [Parameter] public int GenreId { get; set; }
    public Genre genre;

    protected override async Task OnInitializedAsync()
    {
        genre = await genreRepository.GetGenre(GenreId);
    }

    private void Edit()
    {
        genreRepository.UpdateGenre(genre);
        navigationManager.NavigateTo("genres");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
    }
}
#pragma warning restore 1591