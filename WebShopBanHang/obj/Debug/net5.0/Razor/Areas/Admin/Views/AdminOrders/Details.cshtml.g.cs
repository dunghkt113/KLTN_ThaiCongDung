#pragma checksum "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd17d80928e353e2db7054ba9f893ee236c2de2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd17d80928e353e2db7054ba9f893ee236c2de2d", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e250caa81bbffacdf0b2207dd2f8aa8f6276a849", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShopBanHang.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-tone m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
  
ViewData["Title"] = "Thông tin đơn hàng #" + Model.OrderId;
Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
List<OrderDetail> orderDetails = ViewBag.ChiTiet;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<!-- Content Wrapper START -->\n<div class=\"main-content\">\n    <div class=\"page-header\">\n        <div class=\"header-sub-title\">\n            <nav class=\"breadcrumb breadcrumb-dash\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd17d80928e353e2db7054ba9f893ee236c2de2d6108", async() => {
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
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd17d80928e353e2db7054ba9f893ee236c2de2d7813", async() => {
                WriteLiteral("Danh sách sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <span class=\"breadcrumb-item active\">Thông tin đơn hàng :KH - ");
#nullable restore
#line 18 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                         Write(Model.Customer.FullName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </nav>
        </div>
    </div>
    <div class=""container"">
        <div class=""card"">
            <div class=""card-body"">
                <div id=""invoice"" class=""p-h-30"">
                    <div class=""row m-t-20 lh-2"">
                        <div class=""col-sm-7"">
                            <h3 class=""p-l-10 m-t-10"">ĐƠN HÀNG:</h3>
                            <span class=""font-weight-semibold text-dark"">");
#nullable restore
#line 29 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                    Write(Model.Customer.FullName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\n                            <abbr class=\"text-dark\" title=\"Address\">Địa chỉ giao hàng</abbr>\n                            <span>");
#nullable restore
#line 31 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                             Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\n                            <abbr class=\"text-dark\" title=\"Phone\">Số điện thoại:</abbr>\n                            <span>");
#nullable restore
#line 33 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                             Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <div class=""col-sm-5"">
                            <div class=""m-t-80"">
                                <div class=""text-dark text-uppercase d-inline-block"">
                                    <span class=""font-weight-semibold text-dark"">THÔNG TIN MUA HÀNG</span>
                                </div>
                                <div class=""float-right"">MS-");
#nullable restore
#line 40 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                       Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Ngày mua:</span>
                            </div>
                            <div class=""float-right"">");
#nullable restore
#line 45 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <br />
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Ngày ship hàng:</span>
                            </div>
                            <div class=""float-right"">");
#nullable restore
#line 50 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                Write(Model.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <br />
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Trạng thái đơn hàng:</span>
                            </div>
                            <div class=""float-right"">");
#nullable restore
#line 55 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                Write(Model.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                    <div class=""m-t-20"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>STT</th>
                                        <th>SẢN PHẨM
                                        <th></th>
                                        <th>SỐ LƯỢNG</th>
                                        <th></th>
                                        <th>ĐƠN GIÁ</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 72 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                     if (orderDetails != null && orderDetails.Count() > 0)
                                    {
                                        int i = 1;
                                        foreach (var item in orderDetails)
                                        {
                                            string url = $"/{item.Product.Alias}-{item.Product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 79 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 4252, "\"", 4263, 1);
#nullable restore
#line 80 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
WriteAttributeValue("", 4259, url, 4259, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                          Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                            <td></td>\n                            <td>");
#nullable restore
#line 82 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td></td>\n                            <td>");
#nullable restore
#line 84 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                           Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\n                        </tr>\n");
#nullable restore
#line 86 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
i++;
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <div class=""row m-t-30 lh-1-8"">
                            <div class=""col-sm-12"">
                                <div class=""float-right text-right"">
                                    <hr>
                                    <h3><span class=""font-weight-semibold text-dark"">TỔNG TIỀN :</span> ");
#nullable restore
#line 97 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                                   Write(Model.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h3>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd17d80928e353e2db7054ba9f893ee236c2de2d18506", async() => {
                WriteLiteral("Trở Lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd17d80928e353e2db7054ba9f893ee236c2de2d19764", async() => {
                WriteLiteral("Cập nhật trạng thái");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                          WriteLiteral(Model.OrderId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                </div>\n            </div>\n            \n        </div>\n    </div>\n</div>\n<!-- Content Wrapper END -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShopBanHang.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
