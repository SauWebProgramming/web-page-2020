#pragma checksum "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1787a3980b0f749cdef00521808c71c0b5d18536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
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
#line 1 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\_ViewImports.cshtml"
using DrinKing.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\_ViewImports.cshtml"
using DrinKing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\_ViewImports.cshtml"
using DrinKing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\_ViewImports.cshtml"
using DrinKing.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1787a3980b0f749cdef00521808c71c0b5d18536", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f30594cd95fab8f3855113568a0aa7c7e6786ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h2>Tüm içeceklerin görüneceği sayfa</h2>\r\n</div>\r\n\r\n<h2>");
#nullable restore
#line 5 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\Drink\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\Drink\List.cshtml"
   
    foreach (Drink drink in Model.Drinks)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\Drink\List.cshtml"
   Write(Html.Partial("DrinksSummary", drink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\Documents\GitHub\web-page-2020-B181200376\DrinKing\Views\Drink\List.cshtml"
                                             
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
