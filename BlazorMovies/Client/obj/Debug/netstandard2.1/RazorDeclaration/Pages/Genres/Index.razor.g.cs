#pragma checksum "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3beded2782fe5e8587557f1b9a0efd46e31c22cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genres")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Pages\Genres\Index.razor"
        
    List<Genre> Genres;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Genres = await genreRepository.GetGenres();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private async Task DeleteGenres(int Id)
    {
        await genreRepository.DeleteGenre(Id);
        Genres = await genreRepository.GetGenres();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
    }
}
#pragma warning restore 1591
