#pragma checksum "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045fd0cd380aaee2eeeeab6efe64a8b6896701ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\_ViewImports.cshtml"
using eCommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\_ViewImports.cshtml"
using eCommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
using eCommerce.Data.Utils.PartialPermissions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045fd0cd380aaee2eeeeab6efe64a8b6896701ac", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78e183d58a1f5ef5f284a9ec1527884814c9ba2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eCommerce.Web.Models.ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product-details/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-sm-3\">\n        <div class=\"left-sidebar\">\n            ");
#nullable restore
#line 12 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
       Write(await Html.PartialAsync("_CategoriesPartial", Model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"col-sm-9 padding-right\">\n        <div class=\"product-details\">\n            <!--product-details-->\n            <div class=\"col-sm-5\">\n                <div class=\"view-product\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "045fd0cd380aaee2eeeeab6efe64a8b6896701ac5868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h3>ZOOM</h3>
                </div>
                <div id=""similar-product"" class=""carousel slide"" data-ride=""carousel"">



                    <!-- Controls -->
                    <a class=""left item-control"" href=""#similar-product"" data-slide=""prev"">
                        <i class=""fa fa-angle-left""></i>
                    </a>
                    <a class=""right item-control"" href=""#similar-product"" data-slide=""next"">
                        <i class=""fa fa-angle-right""></i>
                    </a>
                </div>

            </div>
            <div class=""col-sm-7"">
                <div class=""product-information"">
                    <!--/product-information-->
                    <h2>");
#nullable restore
#line 41 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                   Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <p>Web ID: 1089772</p>\n                    <img src=\"images/product-details/rating.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1449, "\"", 1455, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <span>\n                        <span>$");
#nullable restore
#line 45 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                          Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        <label>Quantity:</label>
                        <input type=""text"" value=""3"" />
                        <button type=""button"" class=""btn btn-fefault cart"">
                            <i class=""fa fa-shopping-cart""></i>
                            Add to cart
                        </button>
                    </span>
                    <p><b>Availability:</b> In Stock</p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1972, "\"", 1979, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/product-details/share.png\" class=\"share img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 2053, "\"", 2059, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                </div><!--/product-information-->
            </div>
        </div><!--/product-details-->
        <div class=""category-tab shop-details-tab"">
            <!--category-tab-->
            <div class=""col-sm-12"">
                <ul class=""nav nav-tabs"">
                    <li class=""active""><a href=""#reviews"" data-toggle=""tab"">Reviews (5)</a></li>
                </ul>
            </div>
            <div class=""tab-content"">

                <div class=""tab-pane fade active in"" id=""reviews"">
                    <div class=""col-sm-12"">

");
#nullable restore
#line 70 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                         foreach (var item in Model.Comments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2785, "\"", 2792, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i>");
#nullable restore
#line 73 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                                                                    Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2882, "\"", 2889, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 74 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                                                                       Write(item.CreteDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3001, "\"", 3008, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-calendar-o\"></i>");
#nullable restore
#line 75 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                                                                          Write(item.CreteDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                            </ul>\n                            <p>");
#nullable restore
#line 77 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 78 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 81 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                         if ((await AuthorizationService.AuthorizeAsync(User, Permissions.Comment.Add)).Succeeded)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p><b>Write Your Review</b></p>\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045fd0cd380aaee2eeeeab6efe64a8b6896701ac12972", async() => {
                WriteLiteral("\n                                <textarea rows=\"4\"");
                BeginWriteAttribute("name", " name=\"", 3503, "\"", 3510, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\n                                <button type=\"button\" class=\"btn btn-default pull-right\">\n                                    Submit\n                                </button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 91 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </div>\n                </div>\n\n            </div>\n        </div><!--/category-tab-->\n\n\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eCommerce.Web.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
