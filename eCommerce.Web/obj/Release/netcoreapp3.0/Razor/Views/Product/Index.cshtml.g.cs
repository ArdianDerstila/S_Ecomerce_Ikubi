#pragma checksum "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec341899df3dba3cdb649c6c46b180cb044a37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec341899df3dba3cdb649c6c46b180cb044a37a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78e183d58a1f5ef5f284a9ec1527884814c9ba2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eCommerce.Web.Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <div class=\"left-sidebar\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Index.cshtml"
       Write(await Html.PartialAsync("_CategoriesPartial", Model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-sm-9 padding-right\">\r\n        <div class=\"features_items\">\r\n            <!--features_items-->\r\n            ");
#nullable restore
#line 18 "C:\Users\Anonymous\Desktop\SimpleEcommerce\eCommerce.Web\eCommerce.Web\Views\Product\Index.cshtml"
       Write(await Html.PartialAsync("_ProductsPartial", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div><!--features_items-->\r\n\r\n    </div>\r\n</div>");
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
