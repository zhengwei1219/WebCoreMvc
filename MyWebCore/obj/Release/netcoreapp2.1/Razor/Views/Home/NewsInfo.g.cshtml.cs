#pragma checksum "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af044b51aab8dbc6f2f2a8bd153345d73e8b9ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsInfo), @"mvc.1.0.view", @"/Views/Home/NewsInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewsInfo.cshtml", typeof(AspNetCore.Views_Home_NewsInfo))]
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
#line 1 "F:\Project\MyWebCore\MyWebCore\Views\_ViewImports.cshtml"
using MyWebCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af044b51aab8dbc6f2f2a8bd153345d73e8b9ca", @"/Views/Home/NewsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bebd35640225bd411c49c830c5bbdcb4c043326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
  
    ViewData["Title"] = "NewsInfo";

#line default
#line hidden
            BeginContext(65, 1716, true);
            WriteLiteral(@"<table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">

    <tr>
        <td></td>
    </tr>

    <tr>
        <td align=""center"">
            <table width=""1001"" border=""0"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#ffffff"">
                <tr>
                    <td></td>
                    <td height=""210"" colspan=""3"" valign=""top""><img src=""../../images/hd.jpg"" width=""982"" height=""210""></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td height=""10"" colspan=""3"" valign=""top""></td>
                    <td></td>
                </tr>
                <tr>
                    <td width=""9""></td>
                    <td width=""744"" valign=""top"" style=""background-image:url(../../image/rbg.jpg); background-position:bottom; background-repeat:no-repeat;"">
                        <table width=""745"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                            <tr>
                              ");
            WriteLiteral(@"  <td height=""36"" background=""../../images/ar.jpg"">
                                    <table width=""745"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                        <tr>
                                            <td height=""3"" colspan=""4""></td>
                                        </tr>
                                        <tr>
                                            <td width=""25"">&nbsp;</td>
                                            <td width=""227"" align=""left"" style=""font-size:14px; font-weight:bold;"">最新资讯</td>
                                            <td width=""485"" align=""right"">你现在的位置：<a href=""/"">首页</a>&nbsp;>&nbsp;<a href=""#"">");
            EndContext();
            BeginContext(1782, 10, false);
#line 38 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
                                                                                                                       Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1792, 1159, true);
            WriteLiteral(@"</a></td>
                                            <td width=""8"">&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td height=""15""></td>
                            </tr>
                            <tr>
                                <td align=""center"">
                                    <table width=""710"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                        <tr>
                                            <td>

                                                <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                                    <tr>
                                                        <td align=""center"">

                                                            <div align=""center"" style=""padding-top:10px; font-size:1");
            WriteLiteral("6px; color:#000000; line-height:150%;\">\r\n                                                                <font color=\"#000000\"><strong>");
            EndContext();
            BeginContext(2952, 11, false);
#line 58 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
                                                                                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2963, 254, true);
            WriteLiteral("</strong></font>\r\n                                                            </div>\r\n                                                            <div align=\"center\" class=\"STYLE1111\">\r\n                                                                发布人：");
            EndContext();
            BeginContext(3218, 17, false);
#line 61 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
                                                               Write(Model.PublishedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3235, 81, true);
            WriteLiteral("&nbsp;&nbsp;\r\n                                                                时间：");
            EndContext();
            BeginContext(3317, 19, false);
#line 62 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
                                                              Write(Model.PublishedTime);

#line default
#line hidden
            EndContext();
            BeginContext(3336, 1091, true);
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;
                                                                浏览：<font color=""red"">
                                                                    <script src=""static/js/5_145_1.js""></script>
                                                                </font>
                                                            </div>
                                                            <div align=""center""><span class=""STYLE1111"">-----------------------------------------------------------------------------------------------------</span></div>

                                                            <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                                                <tr>
                                                                    <td>
                                                                        <div style=""width:100%;text-align:left; padding:0px;overflow-x:hidden; color:#000000"">
           ");
            WriteLiteral("                                                                   ");
            EndContext();
            BeginContext(4428, 57, false);
#line 73 "F:\Project\MyWebCore\MyWebCore\Views\Home\NewsInfo.cshtml"
                                                                         Write(Html.Raw(System.Net.WebUtility.UrlDecode(@Model.Content)));

#line default
#line hidden
            EndContext();
            BeginContext(4485, 5290, true);
            WriteLiteral(@"
                                                                            <p style=""text-align: center;""><img alt=""刷票公司"" src=""../../images/dbc025ff78893294cb545109590482bc.jpg"" style=""width: 450px; height: 418px;""></p>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td height=""10""></td>
                                        </tr>
");
            WriteLiteral(@"
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td height=""15""></td>
                            </tr>
                        </table>
                    </td>

                    <td width=""9""></td>
                    <td width=""228"" height=""200"" valign=""top"" style=""background-image:url(../../image/lbg.jpg); background-position:bottom; background-repeat:no-repeat;"">
                        <table width=""228"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                            <tr>
                                <td height=""63"" background=""../../images/la.jpg"">&nbsp;</td>
                            </tr>


                           

                            <tr>
                                <td height=""10""></td>
                            </tr>

                            <tr>
                                <td height=""10""></td>
 ");
            WriteLiteral(@"                           </tr>

                            <tr>
                                <td height=""33"" background=""../../images/al.jpg"">
                                    <table width=""228"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                        <tr>
                                            <td height=""3"" colspan=""2""></td>
                                        </tr>
                                        <tr>
                                            <td width=""27"">&nbsp;</td>
                                            <td width=""201"" align=""left"" style=""font-size:14px; font-weight:bold;"">联系我们</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td height=""10""></td>
                            </tr>
                            <tr>
                               ");
            WriteLiteral(@" <td height=""200"" align=""center"" valign=""top"">
                                    <table width=""208"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                        <tr>
                                            <td align=""left"">
                                                <p>
                                                    <span>
                                                        <span style=""line-height:2.5;font-size:12px;"">网络投票公司</span><br>
                                                        <span style=""line-height:2.5;font-size:12px;"">Q&nbsp; Q：3282079595</span>
                                                    </span>
                                                </p>
                                                <p>
                                                    <span>
                                                        <span style=""line-height:2.5;font-size:12px;""></span>
                                                        <span s");
            WriteLiteral(@"tyle=""line-height:2.5;font-size:12px;"">电话：18963948278&nbsp; </span><br>
                                                        <span style=""line-height:2;font-size:12px;"">
                                                            <span style=""line-height:2.5;"">微信：18963948278</span><br>
                                                            <span style=""line-height:2.5;"">网络投票公司是一家多元化发展的互联网公司，会员遍布全国，专业从事互联网络投票,代理投票,微信投票,专业投票公司,微信人工投票以及快速提升各大中小活动排名服务。</span>
                                                        </span>
                                                    </span>
                                                </p>

                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                            <tr>
                                <td height=""15""></td>
                            </tr>
                        </");
            WriteLiteral("table>\r\n                    </td>\r\n\r\n                    <td width=\"10\"></td>\r\n                </tr>\r\n            </table>\r\n        </td>\r\n    </tr>\r\n\r\n\r\n\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.News> Html { get; private set; }
    }
}
#pragma warning restore 1591