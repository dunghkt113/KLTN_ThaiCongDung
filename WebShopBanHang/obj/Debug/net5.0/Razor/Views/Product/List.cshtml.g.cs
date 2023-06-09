#pragma checksum "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9902314b3a5fc663333bb8b09439b2e9fe99f971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\_ViewImports.cshtml"
using WebShopBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\_ViewImports.cshtml"
using WebShopBanHang.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902314b3a5fc663333bb8b09439b2e9fe99f971", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e250caa81bbffacdf0b2207dd2f8aa8f6276a849", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<WebShopBanHang.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
  
    Category category = ViewBag.CurrentCat;
    ViewData["Title"] = category.Title +" -Trang "+ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Begin Main Content Area -->
<main class=""main-content""
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 order-lg-1 order-2 pt-10 pt-lg-0"">
                    <div class=""sidebar-area"">
                        <div class=""widgets-searchbox mb-9"">

                        </div>
                        <div class=""widgets-area mb-9"">
                            <div class=""col-lg-9"">
                                <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" style=""width:240px;"" role=""tablist"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#"" role=""tab"" aria-selected=""true"">Danh Mục Sản Phẩm</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" style=""border: 1px solid #3c9add");
            WriteLiteral(@";"" href=""/Product"" role=""tab"" aria-selected=""true"">Tất Cả</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" style=""border: 1px solid #3c9add;"" href=""/dien-thoai"" role=""tab"" aria-selected=""true"">Điện Thoại</a>
                                    </li>

                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" style=""border: 1px solid #3c9add;"" href=""/Laptop"" role=""tab"" aria-selected=""true"">Laptop</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" style=""border: 1px solid #3c9add;"" href=""/Tai-nghe"" role=""tab"" aria-selected=""true"">Tai Nghe</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-li");
            WriteLiteral(@"nk active"" style=""border: 1px solid #3c9add;"" href=""#"" role=""tab"" aria-selected=""true""></a>
                                    </li>
                                </ul>

                            </div>
                        </div>


                    </div>
                </div>
                <div class=""col-lg-9 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                                <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a class=""active"" id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class=""list-view"" role=""presen");
            WriteLiteral(@"tation"">
                                        <a id=""list-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th-list""></i>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class=""page-count"">
                              
                            </li>
                            
                        </ul>
                    </div>
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade show active"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"">


");
#nullable restore
#line 80 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                 if(Model!=null && Model.Count()>0)
                                            {
                                                foreach(var item in Model)
                                                {
                                                    string url = $"{item.Alias}-{item.ProductId}.html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-sm-6 pt-6 pt-sm-0\">\r\n                                <div class=\"product-item\">\r\n                                    <div class=\"product-img img-zoom-effect\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4877, "\"", 4888, 1);
#nullable restore
#line 89 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
WriteAttributeValue("", 4884, url, 4884, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9902314b3a5fc663333bb8b09439b2e9fe99f97110904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4963, "~/images/products/", 4963, 18, true);
#nullable restore
#line 90 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 4981, item.Thumb, 4981, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 90 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 4999, item.Title, 4999, 11, false);

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
            WriteLiteral(@"
                                        </a>
                                        <div class=""product-add-action"">
                                            <ul>
                                                <li>
                                                    <a href=""cart.html"">
                                                        <i class=""pe-7s-cart""></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""compare.html"">
                                                        <i class=""pe-7s-shuffle""></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""wishlist.html"">
                                                        <i class");
            WriteLiteral(@"=""pe-7s-like""></i>
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""product-content"">
                                        <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 6442, "\"", 6453, 1);
#nullable restore
#line 113 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
WriteAttributeValue("", 6449, url, 6449, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 113 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <div class=\"price-box pb-1\">\r\n                                            <span class=\"new-price\">");
#nullable restore
#line 115 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                               Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                                        </div>\r\n                                        \r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 121 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"list-view\" role=\"tabpanel\" aria-labelledby=\"list-view-tab\">\r\n                            <div class=\"product-list-view row\">\r\n");
#nullable restore
#line 128 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                            {
                                                foreach (var item in Model)
                                                {
                                                string url = $"{item.Alias}-{item.ProductId}.html";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-12"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a href=""single-product.html"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9902314b3a5fc663333bb8b09439b2e9fe99f97117267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7937, "~/images/products/", 7937, 18, true);
#nullable restore
#line 138 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 7955, item.Thumb, 7955, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 138 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 7973, url, 7973, 4, false);

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
            WriteLiteral(@"
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
                                                                <a href=""cart.html"">
                                                                    <i class=""pe-7s-cart""></i>
                                                                </a>
                                                            </li>
                                                            <li>
                                                                <a href=""compare.html"">
                                                                    <i class=""pe-7s-shuffle""></i>
                                                                </a>
                                                            </li>
                                        ");
            WriteLiteral(@"                    <li>
                                                                <a href=""wishlist.html"">
                                                                    <i class=""pe-7s-like""></i>
                                                                </a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content align-self-center"">
                                                    <a class=""product-name pb-2""");
            BeginWriteAttribute("href", " href=\"", 9708, "\"", 9719, 1);
#nullable restore
#line 161 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
WriteAttributeValue("", 9715, url, 9715, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Black Peppepr Read</a>\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price\">");
#nullable restore
#line 163 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                    \r\n                                                    <p class=\"short-desc mb-0\">");
#nullable restore
#line 166 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                                          Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 170 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"pagination-area pt-10\">\r\n                        <ul class=\"pagination justify-content-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9902314b3a5fc663333bb8b09439b2e9fe99f97123176", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 178 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 178 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CatID", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                                                                                                                                                WriteLiteral(ViewBag.CurrentCateID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["CatID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CatID", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["CatID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\List.cshtml"
                                                                                                                                                                                                                         WriteLiteral(category.Alias);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Alias", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n\r\n                     \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<!-- Main Content Area End Here -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<WebShopBanHang.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
