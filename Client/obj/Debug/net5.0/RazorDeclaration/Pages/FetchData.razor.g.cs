// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\FetchData.razor"
using dapp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
