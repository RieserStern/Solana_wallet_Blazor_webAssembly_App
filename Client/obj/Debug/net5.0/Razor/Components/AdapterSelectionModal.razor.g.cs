#pragma checksum "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8e57b7c7dec06af0818f390e812e6edefb2b86"
// <auto-generated/>
#pragma warning disable 1591
namespace dapp.Client.Components
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
    public partial class AdapterSelectionModal : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
 if (Connecting)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"container px-4\"><div class=\"container\"><div class=\"spinner\"></div></div>\n        <br>\n        <br>\n        <div class=\"container\"><em class=\"px-5\">Connecting...</em></div></div>");
#nullable restore
#line 18 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container p-md-4");
#nullable restore
#line 22 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
         foreach (var adapter in Adapters)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container px-4 p-md-1");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
                                    () => SelectAdapter(adapter.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "btn-dark btn-block");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "align-self-start");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 26 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
                                                        adapter.IconUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "height", "25");
            __builder.AddAttribute(12, "width", "25");
            __builder.AddAttribute(13, "alt", 
#nullable restore
#line 26 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
                                                                                                      adapter.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "align-self-end px-2");
#nullable restore
#line 27 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
__builder.AddContent(17, adapter.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Components\AdapterSelectionModal.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    [Parameter] public List<WalletProvider> Adapters { get; set; }

    private bool Connecting { get; set; }
    private WalletProvider WalletProvider { get; set; }

    protected override void OnInitialized()
    {
        _appState.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        if (WalletProvider != null)
        {
            WalletProvider.OnConnected -= OnConnected;
        }
        _appState.OnChange -= StateHasChanged;
    }
    
    private async void SelectAdapter(string adapterName)
    {
        Connecting = true;
        WalletProvider = Adapters.FirstOrDefault(adapter => adapter.Name == adapterName);
        if (WalletProvider == null)
        {
            Connecting = false;
            return;
        }
        await WalletProvider.Load(_jsRuntime);
        WalletProvider.OnConnected += OnConnected;
        await WalletProvider.Connect();
    }

    private async void OnConnected()
    {
        Console.WriteLine($"Connected to provider. Account: {WalletProvider.PublicKey}");
        _walletService.SetProvider(WalletProvider);
        await ModalInstance.CloseAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWalletService _walletService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591