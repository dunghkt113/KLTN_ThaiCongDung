#pragma checksum "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79db18ffd342af1abe6ac608d489611228c0a445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
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
#line 1 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebShopBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebShopBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79db18ffd342af1abe6ac608d489611228c0a445", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e250caa81bbffacdf0b2207dd2f8aa8f6276a849", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProducts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShopBanHang.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-tone m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79db18ffd342af1abe6ac608d489611228c0a4457220", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79db18ffd342af1abe6ac608d489611228c0a4458923", async() => {
                WriteLiteral("Xóa sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Thông tin sản phẩm : ");
#nullable restore
#line 13 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                                 Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Thông tin sản phẩm : ");
#nullable restore
#line 19 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>ID:</td>
                        <td class=""text-danger font-weight-semibold"">");
#nullable restore
#line 25 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                                Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tên sản phẩm:</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Mô tả ngắn:</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Gía bán:</td>\r\n                        <td>");
#nullable restore
#line 37 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Sales:</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Kích hoạt:</td>\r\n                        <td>\r\n");
#nullable restore
#line 46 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                             if (Model.Active)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 2036, "\"", 2046, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div> ");
#nullable restore
#line 51 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                       }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\" disabled />\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>");
#nullable restore
#line 57 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Hiện thị trang chủ:</td>\r\n                        <td>\r\n");
#nullable restore
#line 63 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                             if (Model.HomeFlag)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 2874, "\"", 2884, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div> ");
#nullable restore
#line 68 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                       }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\" disabled />\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>");
#nullable restore
#line 74 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Ngày tạo:</td>\r\n                        <td>");
#nullable restore
#line 80 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ngày sửa:</td>\r\n                        <td>");
#nullable restore
#line 84 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.DateModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tiêu đề:</td>\r\n                        <td>");
#nullable restore
#line 88 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>ảnh đại diện:</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79db18ffd342af1abe6ac608d489611228c0a44518565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4001, "~/images/products/", 4001, 18, true);
#nullable restore
#line 93 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
AddHtmlAttributeValue("", 4019, Model.Thumb, 4019, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 93 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
AddHtmlAttributeValue("", 4038, Model.Title, 4038, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Mô tả:</td>\r\n                        <td>");
#nullable restore
#line 98 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79db18ffd342af1abe6ac608d489611228c0a44521306", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79db18ffd342af1abe6ac608d489611228c0a44521569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 106 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminProducts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79db18ffd342af1abe6ac608d489611228c0a44523381", async() => {
                    WriteLiteral("Trở Lại");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShopBanHang.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
