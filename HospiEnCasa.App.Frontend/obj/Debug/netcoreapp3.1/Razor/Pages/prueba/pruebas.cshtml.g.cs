#pragma checksum "C:\hospital\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\prueba\pruebas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f10453e2bbf1c1f8de93a13b2fc743e082760cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Frontend.Pages.prueba.Pages_prueba_pruebas), @"mvc.1.0.razor-page", @"/Pages/prueba/pruebas.cshtml")]
namespace HospiEnCasa.App.Frontend.Pages.prueba
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
#line 1 "C:\hospital\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f10453e2bbf1c1f8de93a13b2fc743e082760cb", @"/Pages/prueba/pruebas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08056ece19204f924bb1e05e247bbea9f829a0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_prueba_pruebas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>hola esta es la prueba de funcionamiento</p><br>\r\n\r\n<table class =\"table\">\r\n");
#nullable restore
#line 8 "C:\hospital\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\prueba\pruebas.cshtml"
     foreach (var p in Model.ListaPruebas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 11 "C:\hospital\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\prueba\pruebas.cshtml"
           Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\hospital\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\prueba\pruebas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Frontend.Pages.pruebasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.pruebasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.pruebasModel>)PageContext?.ViewData;
        public HospiEnCasa.App.Frontend.Pages.pruebasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591