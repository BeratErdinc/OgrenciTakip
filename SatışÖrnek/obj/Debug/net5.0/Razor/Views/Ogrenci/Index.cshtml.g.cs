#pragma checksum "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0bc9c20700a0110dc5f63785629ceab33d88e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Index), @"mvc.1.0.view", @"/Views/Ogrenci/Index.cshtml")]
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
#line 1 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
using SatışÖrnek.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bc9c20700a0110dc5f63785629ceab33d88e16", @"/Views/Ogrenci/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e531308827ef7314030c108845d36f8433f790", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ogrenci>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Ogrenci/Ekle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Admin/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <td>OgrenciAdı</td>
        <td>Adı</td>
        <td>Soyadı</td>
        <td>Cinsiyet</td>
        <td>Kulüp Adı</td>
        <td>Sil</td>
        <td>Güncelle</td>
    </tr>
    <tbody>

");
#nullable restore
#line 20 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
           Write(item.OgrenciId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
           Write(item.OgrenciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
           Write(item.OgrenciSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
           Write(item.OgrencıCınsıyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
           Write(item.Kulup.KulupAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 668, "\"", 703, 2);
            WriteAttributeValue("", 675, "/Ogrenci/Sil/", 675, 13, true);
#nullable restore
#line 28 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
WriteAttributeValue("", 688, item.OgrenciId, 688, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Sil</a> </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 802, 2);
            WriteAttributeValue("", 769, "/Ogrenci/Guncelle/", 769, 18, true);
#nullable restore
#line 29 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
WriteAttributeValue("", 787, item.OgrenciId, 787, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Guncelle</a> </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\Önemli3\asp.net\SatışÖrnek\SatışÖrnek\Views\Ogrenci\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0bc9c20700a0110dc5f63785629ceab33d88e166944", async() => {
                WriteLiteral("Yeni Ogrenci Kaydı");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ogrenci>> Html { get; private set; }
    }
}
#pragma warning restore 1591
