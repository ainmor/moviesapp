#pragma checksum "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3aa7db7a704e7ec0d96d7d402a84f0e0c322a3"
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
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
 if (DisplayConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"modal-backdrop show\"></div>\r\n");
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal fade show");
            __builder.AddAttribute(4, "id", "exampleModal");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.AddAttribute(7, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(8, "aria-hidden", "true");
            __builder.AddAttribute(9, "style", "display: block;");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-dialog");
            __builder.AddAttribute(13, "role", "document");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-content");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "modal-header");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "h5");
            __builder.AddAttribute(22, "class", "modal-title");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddContent(24, 
#nullable restore
#line 12 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "close");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.AddMarkupContent(32, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal-body");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.AddContent(38, 
#nullable restore
#line 19 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
                     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-footer");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary");
            __builder.AddContent(48, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
                                      onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddContent(54, "Ok");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 28 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\programming\dotnetblazor\MoviesWebApp\BlazorMovies\Client\Shared\Confirmation.razor"
       
    private bool DisplayConfirmation = false;
    [Parameter] public string Title { get; set; } = "Confirm";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback onConfirm { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }

    public void Show() => DisplayConfirmation = true;
    public void Hide() => DisplayConfirmation = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
