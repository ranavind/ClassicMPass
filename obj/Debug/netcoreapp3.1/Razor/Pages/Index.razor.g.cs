#pragma checksum "C:\Projects\Apollo\ApolloTiers\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9681aa71901d10224ba83687f6fac156f9f4af18"
// <auto-generated/>
#pragma warning disable 1591
namespace ApolloTiers.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using ApolloTiers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using ApolloTiers.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\Apollo\ApolloTiers\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(0);
            __builder.AddAttribute(1, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Projects\Apollo\ApolloTiers\Pages\Index.razor"
                         SayHelloHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Primary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Projects\Apollo\ApolloTiers\Pages\Index.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Say Hello");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n<br>\r\n\r\n");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Projects\Apollo\ApolloTiers\Pages\Index.razor"
 helloString

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Projects\Apollo\ApolloTiers\Pages\Index.razor"
       
    MarkupString helloString;

    void SayHelloHandler()
    {
        string msg = string.Format("Hello from <strong>Telerik Blazor</strong> at {0}.<br /> Now you can use C# to write front-end!", DateTime.Now);
        helloString = new MarkupString(msg);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
