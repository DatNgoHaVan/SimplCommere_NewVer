#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89cf35462721a3b4302676e442b63e8e535f708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalog_Views_Shared__ProductThumbnail), @"mvc.1.0.view", @"/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml", typeof(AspNetCore.Areas_Catalog_Views_Shared__ProductThumbnail))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89cf35462721a3b4302676e442b63e8e535f708", @"/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538836bd7b7402d98e6a00e670f64f36420bffff", @"/Areas/Catalog/Views/_ViewImports.cshtml")]
    public class Areas_Catalog_Views_Shared__ProductThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 64, true);
            WriteLiteral("\n<div class=\"card mb-4\">\n    <input type=\"hidden\" id=\"productId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 142, "\"", 159, 1);
#line 4 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
WriteAttributeValue("", 150, Model.Id, 150, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(160, 8, true);
            WriteLiteral(" />\n    ");
            EndContext();
            BeginContext(168, 1445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a89cf35462721a3b4302676e442b63e8e535f7084329", async() => {
                BeginContext(192, 13, true);
                WriteLiteral("\n        <img");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 205, "\"", 222, 1);
#line 6 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
WriteAttributeValue("", 211, Model.Name, 211, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(223, 21, true);
                WriteLiteral(" class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 244, "\"", 269, 1);
#line 6 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
WriteAttributeValue("", 250, Model.ThumbnailUrl, 250, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(270, 82, true);
                WriteLiteral(">\n        <div class=\"card-body\">\n            <h5 class=\"card-title product-name\">");
                EndContext();
                BeginContext(353, 10, false);
#line 8 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(363, 54, true);
                WriteLiteral("</h5>\n            <p class=\"card-text product-price\">\n");
                EndContext();
#line 10 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                 if (Model.IsCallForPricing)
                {
                    

#line default
#line hidden
                BeginContext(501, 29, false);
#line 12 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
               Write(Localizer["Call for pricing"]);

#line default
#line hidden
                EndContext();
#line 12 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                                  
                }
                else
                {
                    

#line default
#line hidden
                BeginContext(609, 48, false);
#line 16 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
               Write(Model.CalculatedProductPrice.Price.ToString("C"));

#line default
#line hidden
                EndContext();
#line 16 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                                                     
                    if (Model.CalculatedProductPrice.PercentOfSaving > 0)
                    {

#line default
#line hidden
                BeginContext(754, 60, true);
                WriteLiteral("                        <span class=\"product-price-saving\">-");
                EndContext();
                BeginContext(816, 44, false);
#line 19 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                                        Write(Model.CalculatedProductPrice.PercentOfSaving);

#line default
#line hidden
                EndContext();
                BeginContext(861, 99, true);
                WriteLiteral("%</span>\n                        <br/>\n                        <span class=\"product-price-regular\">");
                EndContext();
                BeginContext(961, 57, false);
#line 21 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                                       Write(Model.CalculatedProductPrice.OldPrice.Value.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1018, 8, true);
                WriteLiteral("</span>\n");
                EndContext();
#line 22 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                    }
                }

#line default
#line hidden
                BeginContext(1066, 110, true);
                WriteLiteral("            </p>\n            <ul class=\"list-inline product-ratings\">\n                <li><input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1176, "\"", 1204, 1);
#line 26 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
WriteAttributeValue("", 1184, Model.RatingAverage, 1184, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1205, 125, true);
                WriteLiteral(" readonly=\"readonly\" class=\"rating-loading\" step=\"1\" data-size=\"xs\" data-show-clear=\"false\" data-show-caption=\"false\"/></li>\n");
                EndContext();
#line 27 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                 if (Model.ReviewsCount > 0)
                {

#line default
#line hidden
                BeginContext(1393, 84, true);
                WriteLiteral("                    <li class=\"product-review-list\">\n                        <span>(");
                EndContext();
                BeginContext(1478, 18, false);
#line 30 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                          Write(Model.ReviewsCount);

#line default
#line hidden
                EndContext();
                BeginContext(1496, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1498, 20, false);
#line 30 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                                              Write(Localizer["reviews"]);

#line default
#line hidden
                EndContext();
                BeginContext(1518, 35, true);
                WriteLiteral(")</span>\n                    </li>\n");
                EndContext();
#line 32 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
                }

#line default
#line hidden
                BeginContext(1571, 38, true);
                WriteLiteral("            </ul>\n\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 177, "~/", 177, 2, true);
#line 5 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Catalog/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml"
AddHtmlAttributeValue("", 179, Model.Slug, 179, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1613, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail> Html { get; private set; }
    }
}
#pragma warning restore 1591
