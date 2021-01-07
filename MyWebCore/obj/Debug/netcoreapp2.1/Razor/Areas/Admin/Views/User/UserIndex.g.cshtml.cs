#pragma checksum "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1a5398cbe0bbaa0404147308c23ff0e426388e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UserIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/UserIndex.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_UserIndex))]
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
#line 1 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
using MyWebCore;

#line default
#line hidden
#line 2 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
using Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1a5398cbe0bbaa0404147308c23ff0e426388e", @"/Areas/Admin/Views/User/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0b14c5a223ee073a22e7b2f6f183d23f425dea4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSourceResult<SysUser,SysUserSearchArg>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "editUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-pink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "userIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
  
    ViewData["Title"] = "系统用户列表";
    bool canAddOrUpdate = Html.OwnPermission("editUser");
    bool canResetPwd = Html.OwnPermission("resetPassword");
    bool canDelete = Html.OwnPermission("deleteUser");

#line default
#line hidden
            BeginContext(302, 162, true);
            WriteLiteral("\r\n<div class=\"breadcrumbs\" id=\"breadcrumbs\">\r\n    <ul class=\"breadcrumb\">\r\n        <li>\r\n            <i class=\"ace-icon fa fa-home home-icon\"></i>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 464, "\"", 497, 1);
#line 15 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 471, Url.RouteUrl("mainIndex"), 471, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(498, 166, true);
            WriteLiteral(">首页</a>\r\n        </li>\r\n        <li class=\"active\">系统用户</li>\r\n    </ul>\r\n</div>\r\n<div class=\"page-content\">\r\n    <div class=\"page-header\">\r\n        <h1>\r\n            ");
            EndContext();
            BeginContext(665, 17, false);
#line 23 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(682, 85, true);
            WriteLiteral("\r\n        </h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 28 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
             if (canAddOrUpdate)
            {

#line default
#line hidden
            BeginContext(816, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(832, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e5c2220da346a09aea1901f6c71df7", async() => {
                BeginContext(884, 46, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i>添加系统用户");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(934, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
            }

#line default
#line hidden
            BeginContext(951, 226, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"space-2\"></div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-body\">\r\n                    ");
            EndContext();
            BeginContext(1177, 529, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee11bb90cdf4dffa9db77bf204b38ff", async() => {
                BeginContext(1238, 139, true);
                WriteLiteral("\r\n                        <label>关键字</label>\r\n                        <input type=\"text\" class=\"form-control\" name=\"q\" style=\"width:220px;\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1377, "\"", 1409, 1);
#line 41 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 1385, Model.Paging.RouteArg.q, 1385, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1410, 289, true);
                WriteLiteral(@" placeholder=""账号、姓名、邮箱、手机号"" />
                        <button type=""submit"" class=""btn btn-purple btn-sm"">
                            查询
                            <i class=""ace-icon fa fa-search icon-on-right bigger-110""></i>
                        </button>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1706, 823, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <table id=""user_datatable"" class=""table table-striped table-bordered table-hover dataTable no-footer"">
                <thead>
                    <tr>
                        <th width=""150px"">账号</th>
                        <th width=""100px"">姓名</th>
                        <th width=""110px"">手机号</th>
                        <th width=""60px"">性别</th>
                        <th width=""150px"">活动时间</th>
                        <th width=""100px"">启用</th>
                        <th width=""120px"">登录锁</th>
                        <th width=""50px;"">密码</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 68 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                     foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(2607, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2670, 12, false);
#line 71 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                           Write(item.Account);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2722, 9, false);
#line 72 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2731, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2771, 16, false);
#line 73 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                           Write(item.MobilePhone);

#line default
#line hidden
            EndContext();
            BeginContext(2787, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2827, 8, false);
#line 74 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                           Write(item.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(2835, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2876, 51, false);
#line 75 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                            Write(item.LastActivityTime?.ToString("yyyy-MM-dd HH;mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2928, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 77 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                 if (!item.IsAdmin)
                                {
                                    if (item.Enabled)
                                    {

#line default
#line hidden
            BeginContext(3151, 163, true);
            WriteLiteral("                                        <label>\r\n                                            <input name=\"enabled\" class=\"ace ace-switch ace-switch-7 user_enabled\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3314, "\"", 3330, 1);
#line 82 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 3322, item.Id, 3322, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3331, 160, true);
            WriteLiteral(" type=\"checkbox\" checked=\"checked\" />\r\n                                            <span class=\"lbl\"></span>\r\n                                        </label>\r\n");
            EndContext();
#line 85 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3611, 163, true);
            WriteLiteral("                                        <label>\r\n                                            <input name=\"enabled\" class=\"ace ace-switch ace-switch-7 user_enabled\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3774, "\"", 3790, 1);
#line 89 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 3782, item.Id, 3782, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3791, 142, true);
            WriteLiteral(" type=\"checkbox\" />\r\n                                            <span class=\"lbl\"></span>\r\n                                        </label>\r\n");
            EndContext();
#line 92 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(4007, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 96 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                 if (item.LoginLock)
                                {

#line default
#line hidden
            BeginContext(4165, 103, true);
            WriteLiteral("                                    <label>\r\n                                        <input name=\"lock\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4268, "\"", 4284, 1);
#line 99 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 4276, item.Id, 4276, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4285, 198, true);
            WriteLiteral(" class=\"ace ace-switch ace-switch-5 user_lock\" type=\"checkbox\" checked=\"checked\" />\r\n                                        <span class=\"lbl\"></span>\r\n                                    </label>\r\n");
            EndContext();
#line 102 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    if (item.AllowLoginTime.HasValue && item.AllowLoginTime > DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(4631, 60, true);
            WriteLiteral("                                        <span class=\"badge\">");
            EndContext();
            BeginContext(4693, 64, false);
#line 104 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                                        Write((int)(item.AllowLoginTime.Value - DateTime.Now).TotalMinutes + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4758, 10, true);
            WriteLiteral("分</span>\r\n");
            EndContext();
#line 105 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4915, 171, true);
            WriteLiteral("                                    <label data-toggle=\"tooltip\" data-placement=\"left\" title=\"Tooltip on left\">\r\n                                        <input name=\"lock\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5086, "\"", 5102, 1);
#line 110 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 5094, item.Id, 5094, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5103, 180, true);
            WriteLiteral(" class=\"ace ace-switch ace-switch-5 user_lock\" type=\"checkbox\" />\r\n                                        <span class=\"lbl\"></span>\r\n                                    </label>\r\n");
            EndContext();
#line 113 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                }

#line default
#line hidden
            BeginContext(5318, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 116 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                 if (!item.IsAdmin)
                                {
                                    if (canResetPwd)
                                    {

#line default
#line hidden
            BeginContext(5568, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5610, "\"", 5669, 1);
#line 120 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 5617, Url.RouteUrl("resetPassword", new { id = item.Id }), 5617, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5670, 98, true);
            WriteLiteral(" class=\"btn btn-xs btn-warning btnResetPwd\" title=\"重置密码\"><i class=\"ace-icon fa fa-undo\"></i></a>\r\n");
            EndContext();
#line 121 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(5842, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 125 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                 if (canAddOrUpdate)
                                {

#line default
#line hidden
            BeginContext(6000, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6038, "\"", 6094, 1);
#line 127 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 6045, Url.RouteUrl("deleteUser", new { id = item.Id }), 6045, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6095, 78, true);
            WriteLiteral(" class=\"btn btn-xs btn-info\"><i class=\"glyphicon glyphicon-trash\"></i>修改</a>\r\n");
            EndContext();
#line 128 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                }

#line default
#line hidden
            BeginContext(6208, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 129 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                 if (canDelete)
                                {
                                    if (!item.IsAdmin)
                                    {

#line default
#line hidden
            BeginContext(6387, 39, true);
            WriteLiteral("                                     <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6426, "\"", 6482, 1);
#line 133 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
WriteAttributeValue("", 6433, Url.RouteUrl("deleteUser", new { id = item.Id }), 6433, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6483, 90, true);
            WriteLiteral(" class=\"btn btn-xs btn-danger btnDelete\"><i class=\"glyphicon glyphicon-trash\"></i>删除</a>\r\n");
            EndContext();
#line 134 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(6647, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 139 "F:\Project\MyWebCore\MyWebCore\Areas\Admin\Views\User\UserIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(6738, 145, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <pager page-value=\"Model.Paging\"></pager>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSourceResult<SysUser,SysUserSearchArg>> Html { get; private set; }
    }
}
#pragma warning restore 1591
