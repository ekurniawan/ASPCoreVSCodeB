#pragma checksum "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a0dec9dfb541e12947d4ae7b99efeb8eda65cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Index), @"mvc.1.0.view", @"/Views/Mahasiswa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/Index.cshtml", typeof(AspNetCore.Views_Mahasiswa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a0dec9dfb541e12947d4ae7b99efeb8eda65cb", @"/Views/Mahasiswa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5548ae16151ce2d56cb3b361b1424016d3007e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 36, true);
            WriteLiteral("\r\n\r\n<h2>Daftar Mahasiswa</h2><br/>\r\n");
            EndContext();
            BeginContext(68, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a0dec9dfb541e12947d4ae7b99efeb8eda65cb4265", async() => {
                BeginContext(122, 11, true);
                WriteLiteral("Tambah Data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(137, 205, true);
            WriteLiteral("\r\n<br /><br/>\r\n\r\n<div class=\"row\">\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Nim</th>\r\n        <th>Nama</th>\r\n        <th>Email</th>\r\n        <th>Telp</th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
     foreach(var data in Model){

#line default
#line hidden
            BeginContext(376, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(407, 8, false);
#line 21 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
           Write(data.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(415, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(439, 9, false);
#line 22 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
           Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(448, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(472, 10, false);
#line 23 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
           Write(data.Email);

#line default
#line hidden
            EndContext();
            BeginContext(482, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(506, 9, false);
#line 24 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
           Write(data.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(515, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(538, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a0dec9dfb541e12947d4ae7b99efeb8eda65cb7522", async() => {
                BeginContext(587, 25, true);
                WriteLiteral("\r\n                details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
                                          WriteLiteral(data.Nim);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(616, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Kuliah\2019\ASPCoreGroupB\Views\Mahasiswa\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(645, 20, true);
            WriteLiteral("</table>\r\n</div>\r\n\r\n");
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
