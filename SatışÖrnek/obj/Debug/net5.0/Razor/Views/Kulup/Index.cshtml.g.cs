#pragma checksum "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ba42614914d66dd5fb729784cc97d0ab7e0e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kulup_Index), @"mvc.1.0.view", @"/Views/Kulup/Index.cshtml")]
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
#line 1 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\_ViewImports.cshtml"
using SatışÖrnek;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
using SatışÖrnek.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ba42614914d66dd5fb729784cc97d0ab7e0e11", @"/Views/Kulup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e531308827ef7314030c108845d36f8433f790", @"/Views/_ViewImports.cshtml")]
    public class Views_Kulup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kulup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Admin/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <td>Kulüp Id</td>\r\n        <td>Kulüp Ad</td>\r\n        <td>Sil</td>\r\n        <td>Güncelle</td>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 16 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
           Write(item.KulupId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
           Write(item.KulupAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 437, "\"", 468, 2);
            WriteAttributeValue("", 444, "/Kulup/Sil/", 444, 11, true);
#nullable restore
#line 21 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
WriteAttributeValue("", 455, item.KulupId, 455, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Sil</a> </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 563, 2);
            WriteAttributeValue("", 534, "/Kulup/Guncelle/", 534, 16, true);
#nullable restore
#line 22 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
WriteAttributeValue("", 550, item.KulupId, 550, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Guncelle</a> </td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Kulup\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Kulup/Ekle\" class=\"btn btn-primary\">Yeni Kulup Kaydı</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kulup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
