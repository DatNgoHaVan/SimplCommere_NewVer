#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WishList_Views_WishList_PrivateList), @"mvc.1.0.view", @"/Areas/WishList/Views/WishList/PrivateList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/WishList/Views/WishList/PrivateList.cshtml", typeof(AspNetCore.Areas_WishList_Views_WishList_PrivateList))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f39", @"/Areas/WishList/Views/WishList/PrivateList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2c487d7b43dfd757769bef8d011e5e40d81380", @"/Areas/WishList/Views/_ViewImports.cshtml")]
    public class Areas_WishList_Views_WishList_PrivateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/wishlist/private-list.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AccountMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "WishList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WishList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Share", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pageNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrivateList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
  
    ViewData["Title"] = Localizer["Wish List"];

#line default
#line hidden
            BeginContext(161, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("head", async() => {
                BeginContext(177, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(182, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f399525", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#line 9 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(278, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(281, 54, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
            EndContext();
            BeginContext(335, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f3911863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 60, true);
            WriteLiteral("\n    </div>\n    <div class=\"wishlist col-md-9\">\n        <h2>");
            EndContext();
            BeginContext(427, 22, false);
#line 17 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
       Write(Localizer["Wish List"]);

#line default
#line hidden
            EndContext();
            BeginContext(449, 21, true);
            WriteLiteral("</h2>\n        <hr />\n");
            EndContext();
#line 19 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
         if (Model.Items.TotalItems > 0)
        {
            foreach (var item in Model.Items.Data)
            {

#line default
#line hidden
            BeginContext(586, 110, true);
            WriteLiteral("                <div class=\"row item\">\n                    <div class=\"col-md-3\">\n                        <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 696, "\"", 719, 1);
#line 25 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
WriteAttributeValue("", 702, item.ProductName, 702, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(720, 18, true);
            WriteLiteral(" class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 738, "\"", 762, 1);
#line 25 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
WriteAttributeValue("", 744, item.ProductImage, 744, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(763, 100, true);
            WriteLiteral(">\n                    </div>\n                    <div class=\"col-md-9\">\n                        <h4>");
            EndContext();
            BeginContext(864, 16, false);
#line 28 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(880, 30, true);
            WriteLiteral("</h4>\n                        ");
            EndContext();
            BeginContext(910, 1438, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f3915528", async() => {
                BeginContext(916, 63, true);
                WriteLiteral("\n                            <input type=\"hidden\" name=\"itemId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 979, "\"", 995, 1);
#line 30 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
WriteAttributeValue("", 987, item.Id, 987, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(996, 69, true);
                WriteLiteral(" />\n                            <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1065, "\"", 1088, 1);
#line 31 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
WriteAttributeValue("", 1073, item.ProductId, 1073, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1089, 132, true);
                WriteLiteral(" />\n                            <div class=\"form-group row\">\n                                <label class=\"col-sm-4 col-form-label\">");
                EndContext();
                BeginContext(1222, 21, false);
#line 33 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                  Write(Localizer["Quantity"]);

#line default
#line hidden
                EndContext();
                BeginContext(1243, 117, true);
                WriteLiteral("</label>\n                                <div class=\"col-md-8\"><input type=\"number\" name=\"qty\" class=\"quantity-field\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1360, "\"", 1382, 1);
#line 34 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
WriteAttributeValue("", 1368, item.Quantity, 1368, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1383, 173, true);
                WriteLiteral(" /></div>\n                            </div>\n                            <div class=\"form-group row\">\n                                <label class=\"col-sm-4 col-form-label\">");
                EndContext();
                BeginContext(1557, 24, false);
#line 37 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                  Write(Localizer["Description"]);

#line default
#line hidden
                EndContext();
                BeginContext(1581, 92, true);
                WriteLiteral("</label>\n                                <div class=\"col-sm-8\"><textarea name=\"description\">");
                EndContext();
                BeginContext(1674, 16, false);
#line 38 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                              Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1690, 267, true);
                WriteLiteral(@"</textarea></div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""offset-md-4 col-md-8"">
                                    <button type=""button"" class=""btn btn-sm btn-add-cart"">");
                EndContext();
                BeginContext(1958, 24, false);
#line 42 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                                     Write(Localizer["Add to cart"]);

#line default
#line hidden
                EndContext();
                BeginContext(1982, 108, true);
                WriteLiteral("</button>\n                                    <button type=\"button\" class=\"btn btn-sm remove-from-wishlist\">");
                EndContext();
                BeginContext(2091, 19, false);
#line 43 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                                             Write(Localizer["Remove"]);

#line default
#line hidden
                EndContext();
                BeginContext(2110, 103, true);
                WriteLiteral("</button>\n                                    <button type=\"button\" class=\"btn btn-sm update-wishlist\">");
                EndContext();
                BeginContext(2214, 19, false);
#line 44 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                                        Write(Localizer["Update"]);

#line default
#line hidden
                EndContext();
                BeginContext(2233, 108, true);
                WriteLiteral("</button>\n                                </div>\n                            </div>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2348, 51, true);
            WriteLiteral("\n                    </div>\n                </div>\n");
            EndContext();
#line 50 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
            }

#line default
#line hidden
            BeginContext(2413, 53, true);
            WriteLiteral("            <div class=\"text-right\">\n                ");
            EndContext();
            BeginContext(2466, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f3922923", async() => {
                BeginContext(2559, 28, false);
#line 52 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                                                                                       Write(Localizer["Share Wish List"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2591, 54, true);
            WriteLiteral("\n            </div>\n            <div>\n                ");
            EndContext();
            BeginContext(2645, 831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91eb9e3c9dad9dcbfcdc24cd0c9dcac78ea14f3925097", async() => {
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 55 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.Items.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 56 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = Model.Items.PageNumber;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 57 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = Model.Items.TotalItems;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__cloudscribe_Web_Pagination_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "cloudscribe.Web.Pagination.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 62 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
                                  WriteLiteral(Model.Items.PageSize);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3476, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 69 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3529, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(3545, 60, false);
#line 72 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
          Write(Localizer["There are currently no items in your wish list."]);

#line default
#line hidden
            EndContext();
            BeginContext(3605, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 73 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PrivateList.cshtml"
        }

#line default
#line hidden
            BeginContext(3620, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
