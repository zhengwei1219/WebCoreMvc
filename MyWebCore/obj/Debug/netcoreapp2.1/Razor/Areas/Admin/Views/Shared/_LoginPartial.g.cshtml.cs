#pragma checksum "F:\netcore\MyWebCore\MyWebCore\Areas\Admin\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9470f60d9082319d4a77ca8374b402e5c6ebfd51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__LoginPartial))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
#line 2 "F:\netcore\MyWebCore\MyWebCore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9470f60d9082319d4a77ca8374b402e5c6ebfd51", @"/Areas/Admin/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b14c5a223ee073a22e7b2f6f183d23f425dea4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 469, true);
            WriteLiteral(@" 
<div class=""navbar-buttons navbar-header pull-right "" role=""navigation"">
    <ul class=""nav ace-nav"">
         
            <li class=""light-blue"">
                <a data-toggle=""dropdown"" href=""javascript:"" class=""dropdown-toggle"">
                    <img class=""nav-user-photo"" src=""/assets/avatars/user.jpg"" onerror=""this.src = '/assets/avatars/user.jpg'"" alt="""" />
                    <span class=""user-info"">
                        <small>您好，</small> ");
            EndContext();
            BeginContext(471, 18, false);
#line 9 "F:\netcore\MyWebCore\MyWebCore\Areas\Admin\Views\Shared\_LoginPartial.cshtml"
                                       Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(490, 553, true);
            WriteLiteral(@"
                    </span>
                    <i class=""ace-icon fa fa-caret-down""></i>
                </a>
                <ul class=""user-menu dropdown-menu-right dropdown-menu dropdown-yellow dropdown-caret dropdown-close"">
                    <li>
                        <a href=""#"">
                            <i class=""ace-icon fa fa-user""></i>
                            个人
                        </a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1043, "\"", 1074, 1);
#line 22 "F:\netcore\MyWebCore\MyWebCore\Areas\Admin\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 1050, Url.RouteUrl("signOut"), 1050, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 224, true);
            WriteLiteral(">\r\n                            <i class=\"ace-icon fa fa-power-off\"></i>\r\n                            退出\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </li> \r\n    </ul>\r\n</div>\r\n");
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