#pragma checksum "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33cbac09d9052810f0371dd914be0c6e64b47946"
// <auto-generated/>
#pragma warning disable 1591
namespace CICalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
using CICalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\niurb\Documents\CICalc\CICalc\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<h3>\r\n    Componente Calculadora\r\n     </h3>\r\n");
            __builder.AddMarkupContent(1, "<label><strong>Primer numero:  </strong></label>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                           N1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => N1 = __value, N1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.AddMarkupContent(7, "<label><strong>Segundo numero: </strong></label>\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                           N2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => N2 = __value, N2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n<br>\r\n\r\n<br>  \r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                   calcular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Calcular");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n");
            __builder.OpenElement(17, "label");
            __builder.AddMarkupContent(18, "<strong>La suma es:</strong>");
            __builder.AddContent(19, 
#nullable restore
#line 16 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                                    ResSuma

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.OpenElement(22, "label");
            __builder.AddMarkupContent(23, "<strong>La resta es:</strong>");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                                     ResResta

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n<br>\r\n");
            __builder.OpenElement(27, "label");
            __builder.AddMarkupContent(28, "<strong>La Multiplicacion es:</strong>");
            __builder.AddContent(29, 
#nullable restore
#line 20 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
                                              ResMultiplicacion

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\niurb\Documents\CICalc\CICalc\Pages\Counter.razor"
       
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
