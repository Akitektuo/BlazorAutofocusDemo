using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Autofocus_Demo.Utils
{

    public class JSUtils
    {

        public static void RequestFocus(IJSRuntime runtime, string selector)
        {
            runtime.InvokeVoidAsync("requestFocus", selector);
        }

        public static void RequestFocus(IJSRuntime runtime, ElementReference element)
        {
            runtime.InvokeVoidAsync("requestFocus", element);
        }
    }
}
