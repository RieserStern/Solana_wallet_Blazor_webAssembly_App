#pragma checksum "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022956f2ee5f9a0edf816095f5cee71b16747764"
// <auto-generated/>
#pragma warning disable 1591
namespace dapp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Solnet.Rpc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
