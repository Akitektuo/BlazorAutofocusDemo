#pragma checksum "D:\Projects\Autofocus Demo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f81ab784501270caa90ef84db8c2fd90ee3c27b"
// <auto-generated/>
#pragma warning disable 1591
namespace Autofocus_Demo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Projects\Autofocus Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "D:\Projects\Autofocus Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "D:\Projects\Autofocus Demo\_Imports.razor"
using Autofocus_Demo;

#line default
#line hidden
#line 9 "D:\Projects\Autofocus Demo\_Imports.razor"
using Autofocus_Demo.Shared;

#line default
#line hidden
#line 1 "D:\Projects\Autofocus Demo\Pages\Index.razor"
using Autofocus_Demo.Utils;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n<input class=\"focus\">");
        }
        #pragma warning restore 1998
#line 11 "D:\Projects\Autofocus Demo\Pages\Index.razor"
       
    protected override void OnAfterRender(bool firstRender)
    {
        JSUtils.RequestFocus(JSRuntime, ".focus");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
