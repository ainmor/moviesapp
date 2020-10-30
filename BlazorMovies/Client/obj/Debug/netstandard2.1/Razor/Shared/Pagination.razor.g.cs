#pragma checksum "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8431619ec3a050af4b3fda819da44338ceea5b7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 4 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
         foreach (var link in links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
                () => SelectedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "cursor: pointer;");
            __builder.AddAttribute(9, "class", "page-item" + " " + (
#nullable restore
#line 8 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
                       link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 8 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
                                                           link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "page-link");
            __builder.AddAttribute(13, "href", "#");
            __builder.AddContent(14, 
#nullable restore
#line 9 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
                                      link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
#nullable restore
#line 10 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Pagination.razor"
        
    [Parameter] public int CurrentPage { get; set; } = 1;
    [Parameter] public int TotalAmountPages { get; set; }
    [Parameter] public int Radius { get; set; } = 3;
    [Parameter] public EventCallback<int> SelectedPage { get; set; }
    List<LinkModel> links;

    private async Task SelectedPageInternal(LinkModel link)
    {
        if (link.Page == CurrentPage)
        {
            return;
        }

        if (!link.Enabled)
        {
            return;
        }

        CurrentPage = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }

    protected override void OnParametersSet()
    {
        LoadPages();
        base.OnParametersSet();
    }

    private void LoadPages()
    {
        links = new List<LinkModel>();
        var isPreviousPageLinkEnabled = CurrentPage != 1;
        var previousPage = CurrentPage - 1;
        links.Add(new LinkModel(previousPage, isPreviousPageLinkEnabled, "Previous"));

        for (int i = 1; i <= TotalAmountPages; i++)
        {
            if (i >= CurrentPage - Radius && i <= CurrentPage + Radius)
            {
                links.Add(new LinkModel(i) { Active = CurrentPage == i });
            }
        }

        var isNextPageLinkEnabled = CurrentPage != TotalAmountPages;
        var nextPage = CurrentPage + 1;
        links.Add(new LinkModel(nextPage, isNextPageLinkEnabled, "Next"));
    }

    class LinkModel
    {
        public LinkModel(int page)
            : this(page, true) { }

        public LinkModel(int page, bool enabled)
            : this(page, enabled, page.ToString())
        { }

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
