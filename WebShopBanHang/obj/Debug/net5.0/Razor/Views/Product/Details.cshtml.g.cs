#pragma checksum "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e1cafd1e3b717e28bf39f246519bbcaf645816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e1cafd1e3b717e28bf39f246519bbcaf645816", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e250caa81bbffacdf0b2207dd2f8aa8f6276a849", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShopBanHang.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:480px; height:450px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
  
    ViewData["Title"] = Model.ProductName;
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Product> lsProduct = ViewBag.sanpham;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Begin Main Content Area  -->
<main class=""main-content"">
    <div class=""single-product-area section-space-top-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"" style=""height:500px"">
                    <div class=""single-product-img h-100"">
                        <div class=""swiper-container single-product-slider"">
                            <div class=""swiper-wrapper"">
                                <div class=""swiper-slide"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 730, "\"", 737, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"single-img gallery-popup\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b7e1cafd1e3b717e28bf39f246519bbcaf6458165498", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 841, "~/images/products/", 841, 18, true);
#nullable restore
#line 19 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 859, Model.Thumb, 859, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 912, Model.Title, 912, 12, false);

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
                                </div>
                            </div>
                            <!-- Add Pagination -->
                            <div class=""swiper-pagination""></div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""product-thumb-with-content row"">
                        <div class=""col-12 order-lg-1 order-2 pt-10 pt-lg-0"">
                            <div class=""single-product-content"">
                                <br />
                                <br />
                                <br />
                                <h2 class=""title"">");
#nullable restore
#line 35 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                             Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div class=\"price-box pb-1\">\r\n                                    <span class=\"new-price text-danger\">");
#nullable restore
#line 37 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                                   Write(Model.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>

                                </div>
                                <div class=""product-category text-matterhorn pb-2"">
                                    <span class=""title"">DANH MỤC :</span>
                                    <ul>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2209, "\"", 2232, 1);
#nullable restore
#line 44 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
WriteAttributeValue("", 2216, Model.Cat.Alias, 2216, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                                  Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""product-category text-matterhorn pb-2"">
                                    <span class=""title"">SỐ LƯỢNG HÀNG TRONG KHO :</span>
                                    <ul>
                                        <li>
                                            ");
#nullable restore
#line 52 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                       Write(Model.UnitslnStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Sản phẩm
                                        </li>
                                    </ul>
                                </div>

                                <ul class=""quantity-with-btn pb-7"">

                                    <li class=""quantity"">
                                        <div class=""cart-plus-minus"">
                                            <input id=""txtsoLuong"" name=""txtsoLuong"" class=""cart-plus-minus-box"" min=""0"" value=""1"" ");
            WriteLiteral(">\r\n                                        </div>\r\n                                    </li>\r\n\r\n");
#nullable restore
#line 65 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                     if (Model.UnitslnStock != null && Model.UnitslnStock > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"add-to-cart\">\r\n                                            <a data-ProductId=\"");
#nullable restore
#line 68 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                          Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-custom-size lg-size btn-primary   btn-secondary-hover rounded-0\" href=\"javascript:void(0)\">Thêm vào giỏ hàng</a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7e1cafd1e3b717e28bf39f246519bbcaf64581612449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 69 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
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
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 71 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 4005, "\"", 4013, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a data-ProductId=\"");
#nullable restore
#line 75 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                          Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-custom-size lg-size btn-primary   btn-secondary-hover rounded-0\" href=\"javascript:void(0)\">Hết hàng</a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7e1cafd1e3b717e28bf39f246519bbcaf64581615293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 76 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
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
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 78 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>



                            </div>

                        </div>

                        <div class=""col-12 order-lg-2 order-1 pt-10 pt-lg-0"">
                            
                        </div>
                    </div>
                </div>
                <div class=""col-lg-12"" style=""margin-left:50px"">
                    <div class=""swiper-container single-product-thumbs"">
                        <p class=""short-desc mb-6"">
                         
                            ");
#nullable restore
#line 96 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>
    </div>
    <div class=""product-slider-area section-space-top-95 section-space-bottom-100"">
        <div class=""container"">
            <div class=""section-title text-center pb-55"">
                <span class=""sub-title text-primary"">Có thể bạn cũng thích</span>
                <h2 class=""title mb-0"">Sản phẩm liên quan</h2>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""swiper-slider-holder swiper-arrow"">
                        <div class=""swiper-container product-slider border-issue"">
                            <div class=""swiper-wrapper"">
");
#nullable restore
#line 113 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                 if (lsProduct != null)
                                {
                                    foreach (var item in lsProduct)
                                    {
                                        string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""swiper-slide"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6294, "\"", 6305, 1);
#nullable restore
#line 121 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
WriteAttributeValue("", 6301, url, 6301, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b7e1cafd1e3b717e28bf39f246519bbcaf64581620160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6392, "~/images/products/", 6392, 18, true);
#nullable restore
#line 122 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 6410, item.Thumb, 6410, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 6428, item.Title, 6428, 11, false);

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
                                                                <a href=""javascript:void(0)"" class=""add-to-cart1"" data-ProductId=""");
#nullable restore
#line 127 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                                                                                             Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                                    <i class=""pe-7s-cart""></i>
                                                                </a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content texx"">
                                                    <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 7435, "\"", 7446, 1);
#nullable restore
#line 135 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
WriteAttributeValue("", 7442, url, 7442, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price\">");
#nullable restore
#line 137 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                                                           Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>
                                                    </div>
                                              
                                                </div>
                                            </div>
                                        </div>");
#nullable restore
#line 142 "D:\Dung\Tai lieu hoc lap trinh\C#\WebShopBanHang\WebShopBanHang\Views\Product\Details.cshtml"
                                              }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <!-- Add Arrows -->
                        <div class=""swiper-button-next""></div>
                        <div class=""swiper-button-prev""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!-- Main Content Area End Here  -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e1cafd1e3b717e28bf39f246519bbcaf64581625804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        function loadHeaderCart() {
            $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
            $(""#numberCart"").load(""/AjaxContent/NumberCart"");
        }
        $(document).ready(function () {
            $(function () {
                $("".add-to-cart"").click(function () {
                    var productid = $('#ProductId').val();
                    var soLuong = $('#txtsoLuong').val();
                    $.ajax({
                        url: '/api/cart/add',
                        type: ""POST"",
                        dataType: ""JSON"",
                        data: {
                            productID: productid,
                            amount: soLuong
                        },
                        success: function (response) {
                            if (response.result == 'Redirect') {
                                window.location = response.url;
                            }
                            else {
                      ");
                WriteLiteral(@"          loadHeaderCart(); //Add Product success
                                location.reload();
                            }
                            console.log(response); // log to the console to see whether it worked
                        },
                        error: function (error) {
                            alert(""Đã xảy ra lỗi"");
                        }
                    });
                });


            });

        });
    </script>


");
            }
            );
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