#pragma checksum "c:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33cbac09d9052810f0371dd914be0c6e64b47946"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CICalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using CICalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using CICalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "c:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
       
  private float N1, N2, ResSuma, ResResta, ResMultiplicacion;

    private void calcular()
    {
        ResSuma = N1 + N2;
        ResResta = N1 - N2;
        ResMultiplicacion = N1 * N2;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
