#pragma checksum "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66fa13e9bdc3506f85456337429aa7d850e47704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FuelCalc_DisplayResult), @"mvc.1.0.view", @"/Views/FuelCalc/DisplayResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\_ViewImports.cshtml"
using MVC_GasMileage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\_ViewImports.cshtml"
using MVC_GasMileage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa13e9bdc3506f85456337429aa7d850e47704", @"/Views/FuelCalc/DisplayResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d0a24d129a6cee6c7ea2f70c570c2b97280f4f", @"/Views/_ViewImports.cshtml")]
    public class Views_FuelCalc_DisplayResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FuelCalculator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
  
    ViewData["Title"] = "DisplayResult";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
  
    FuelCalculator calculator = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>You can drive ");
#nullable restore
#line 11 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
             Write(calculator.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles.</h3>\r\n<h5>Your trip is ");
#nullable restore
#line 12 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
            Write(calculator.TripDistance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles.</h5>\r\n");
#nullable restore
#line 13 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
 if (calculator.ResultString.Contains("more"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 style=\"color:red;\">");
#nullable restore
#line 15 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
                      Write(calculator.ResultString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 16 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 style=\"color:green;\">");
#nullable restore
#line 19 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
                        Write(calculator.ResultString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "C:\Users\kyleg\source\repos\MVC_GasMileage\MVC_GasMileage\Views\FuelCalc\DisplayResult.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FuelCalculator> Html { get; private set; }
    }
}
#pragma warning restore 1591
