#pragma checksum "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d5ab6f1ad2138ae09642bce2ccf5b092ef5387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dokter_DaftarDokter), @"mvc.1.0.view", @"/Views/Dokter/DaftarDokter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dokter/DaftarDokter.cshtml", typeof(AspNetCore.Views_Dokter_DaftarDokter))]
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
#line 1 "C:\Kuliah\2019\ASPCoreGroupB\Views\_ViewImports.cshtml"
using ASPCoreGroupB;

#line default
#line hidden
#line 2 "C:\Kuliah\2019\ASPCoreGroupB\Views\_ViewImports.cshtml"
using ASPCoreGroupB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d5ab6f1ad2138ae09642bce2ccf5b092ef5387", @"/Views/Dokter/DaftarDokter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5548ae16151ce2d56cb3b361b1424016d3007e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dokter_DaftarDokter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 192, true);
            WriteLiteral("\r\n<h2>Daftar Dokter</h2>\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>First Name</th>\r\n        <th>Last Name</th>\r\n        <th>Address</th>\r\n        <th>Telp</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
     foreach (var dokter in Model)
    {

#line default
#line hidden
            BeginContext(267, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(298, 16, false);
#line 17 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
           Write(dokter.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(314, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(338, 15, false);
#line 18 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
           Write(dokter.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(353, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(377, 14, false);
#line 19 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
           Write(dokter.Address);

#line default
#line hidden
            EndContext();
            BeginContext(391, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(415, 11, false);
#line 20 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
           Write(dokter.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(426, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 22 "C:\Kuliah\2019\ASPCoreGroupB\Views\Dokter\DaftarDokter.cshtml"
    }   

#line default
#line hidden
            BeginContext(458, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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