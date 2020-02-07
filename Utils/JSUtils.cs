using Microsoft.JSInterop;

namespace Autofocus_Demo.Utils
{

    public class JSUtils
    {

        public static void RequestFocus(IJSRuntime runtime, string selector)
        {
            runtime.InvokeVoidAsync("requestFocus", selector);
        }
    }
}
