#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e76abc06c27a8ff23804eba60d2462c8dd82a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProductComparison_Views_ComparingProduct_AddToComparisonResult), @"mvc.1.0.view", @"/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml", typeof(AspNetCore.Areas_ProductComparison_Views_ComparingProduct_AddToComparisonResult))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e76abc06c27a8ff23804eba60d2462c8dd82a4", @"/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/ProductComparison/Views/_ViewImports.cshtml")]
    public class Areas_ProductComparison_Views_ComparingProduct_AddToComparisonResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.ProductComparison.Areas.ProductComparison.ViewModels.AddToComparisonResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/compare-products"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(103, 203, true);
            WriteLiteral("\n<div class=\"modal-header\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n    <h4 class=\"modal-title\" id=\"myModalLabel\">");
            EndContext();
            BeginContext(307, 24, false);
#line 5 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
                                         Write(Localizer[Model.Message]);

#line default
#line hidden
            EndContext();
            BeginContext(331, 38, true);
            WriteLiteral("</h4>\n</div>\n<div class=\"modal-body\">\n");
            EndContext();
#line 8 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
     foreach (var product in Model.ProductComparisons)
    {

#line default
#line hidden
            BeginContext(430, 81, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-3\">\n                <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 511, "\"", 537, 1);
#line 12 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
WriteAttributeValue("", 517, product.ProductName, 517, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 18, true);
            WriteLiteral(" class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 556, "\"", 583, 1);
#line 12 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
WriteAttributeValue("", 562, product.ProductImage, 562, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(584, 76, true);
            WriteLiteral(">\n            </div>\n            <div class=\"col-md-7\">\n                <h4>");
            EndContext();
            BeginContext(661, 19, false);
#line 15 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(680, 25, true);
            WriteLiteral("</h4>\n                <p>");
            EndContext();
            BeginContext(706, 50, false);
#line 16 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
              Write(product.CalculatedProductPrice.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(756, 168, true);
            WriteLiteral("</p>\n            </div>\n            <div class=\"col-md-2 product-comparison-result-remove\">\n                <a href=\"#\" class=\"remove-item-comparison\" data-product-id=\"");
            EndContext();
            BeginContext(925, 17, false);
#line 19 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
                                                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(942, 47, true);
            WriteLiteral("\">Remove</a>\n            </div>\n        </div>\n");
            EndContext();
#line 22 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
    }    

#line default
#line hidden
            BeginContext(999, 105, true);
            WriteLiteral("</div>\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(1105, 30, false);
#line 25 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
                                                                  Write(Localizer["Continue shopping"]);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 14, true);
            WriteLiteral("</button>\n    ");
            EndContext();
            BeginContext(1149, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e76abc06c27a8ff23804eba60d2462c8dd82a49721", async() => {
                BeginContext(1217, 20, false);
#line 26 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.ProductComparison/Areas/ProductComparison/Views/ComparingProduct/AddToComparisonResult.cshtml"
                                                                  Write(Localizer["Compare"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1241, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.ProductComparison.Areas.ProductComparison.ViewModels.AddToComparisonResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
