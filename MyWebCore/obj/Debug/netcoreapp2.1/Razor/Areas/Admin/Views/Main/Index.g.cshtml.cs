#pragma checksum "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561b4fc9e831c99411fac058a3b3d51c94c5e9fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Main_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Main/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Main/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Main_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
#line 2 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561b4fc9e831c99411fac058a3b3d51c94c5e9fe", @"/Areas/Admin/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b14c5a223ee073a22e7b2f6f183d23f425dea4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "主界面";

#line default
#line hidden
            BeginContext(41, 163, true);
            WriteLiteral(" \r\n<div class=\"breadcrumbs\" id=\"breadcrumbs\">\r\n    <ul class=\"breadcrumb\">\r\n        <li>\r\n            <i class=\"ace-icon fa fa-home home-icon\"></i>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 204, "\"", 237, 1);
#line 10 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\Main\Index.cshtml"
WriteAttributeValue("", 211, Url.RouteUrl("mainIndex"), 211, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 120, true);
            WriteLiteral(">首页</a>\r\n        </li>\r\n        <li class=\"active\">主界面</li>\r\n    </ul>\r\n</div>\r\n<div class=\"page-content\">\r\n\r\n</div>\r\n\r\n");
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
