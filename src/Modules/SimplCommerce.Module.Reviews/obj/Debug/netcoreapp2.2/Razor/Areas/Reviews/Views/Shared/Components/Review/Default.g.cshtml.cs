#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d62c90bee3d750e3e79f474251872ab77ea1f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reviews_Views_Shared_Components_Review_Default), @"mvc.1.0.view", @"/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml", typeof(AspNetCore.Areas_Reviews_Views_Shared_Components_Review_Default))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
using SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d62c90bee3d750e3e79f474251872ab77ea1f8c", @"/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b18b37fdf10ebd4e5da15d287bba8bbf9154ca2", @"/Areas/Reviews/Views/_ViewImports.cshtml")]
    public class Areas_Reviews_Views_Shared_Components_Review_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels.ReviewVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Areas/Reviews/Views/Review/_ReviewForm.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Areas/Reviews/Views/Reply/_ReplyForm.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageSize", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(132, 47, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n");
            EndContext();
#line 7 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
         if (Model.ReviewsCount > 0)
        {

#line default
#line hidden
            BeginContext(226, 155, true);
            WriteLiteral("            <div class=\"col-md-5 rating-summary\">\n                <div class=\"row\">\n                    <div class=\"col-md-5\">\n                        <h4>");
            EndContext();
            BeginContext(382, 27, false);
#line 12 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                       Write(Localizer["Rating average"]);

#line default
#line hidden
            EndContext();
            BeginContext(409, 56, true);
            WriteLiteral("</h4>\n                        <p class=\"rating-average\">");
            EndContext();
            BeginContext(467, 34, false);
#line 13 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                              Write(Math.Round(Model.RatingAverage, 1));

#line default
#line hidden
            EndContext();
            BeginContext(502, 35, true);
            WriteLiteral("/5</p>\n                        <p>(");
            EndContext();
            BeginContext(538, 18, false);
#line 14 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                       Write(Model.ReviewsCount);

#line default
#line hidden
            EndContext();
            BeginContext(556, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(558, 20, false);
#line 14 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                           Write(Localizer["reviews"]);

#line default
#line hidden
            EndContext();
            BeginContext(578, 162, true);
            WriteLiteral(")</p>\n                    </div>\n                    <div class=\"col-md-7\">\n                        <div class=\"rating-item\">\n                            <span>5 ");
            EndContext();
            BeginContext(741, 18, false);
#line 18 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                               Write(Localizer["stars"]);

#line default
#line hidden
            EndContext();
            BeginContext(759, 146, true);
            WriteLiteral("</span>\n                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 905, "\"", 964, 1);
#line 20 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 921, Model.GetRatingPercent(Model.Rating5Count), 921, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(965, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1003, "\"", 1062, 3);
            WriteAttributeValue("", 1011, "width:", 1011, 6, true);
#line 20 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue(" ", 1017, Model.GetRatingPercent(Model.Rating5Count), 1018, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 1061, "%", 1061, 1, true);
            EndWriteAttribute();
            BeginContext(1063, 110, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                            <span>");
            EndContext();
            BeginContext(1174, 18, false);
#line 23 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             Write(Model.Rating5Count);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 125, true);
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"rating-item\">\n                            <span>4 ");
            EndContext();
            BeginContext(1318, 18, false);
#line 26 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                               Write(Localizer["stars"]);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 146, true);
            WriteLiteral("</span>\n                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1482, "\"", 1541, 1);
#line 28 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 1498, Model.GetRatingPercent(Model.Rating4Count), 1498, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1542, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1580, "\"", 1639, 3);
            WriteAttributeValue("", 1588, "width:", 1588, 6, true);
#line 28 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue(" ", 1594, Model.GetRatingPercent(Model.Rating4Count), 1595, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 1638, "%", 1638, 1, true);
            EndWriteAttribute();
            BeginContext(1640, 110, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                            <span>");
            EndContext();
            BeginContext(1751, 18, false);
#line 31 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             Write(Model.Rating4Count);

#line default
#line hidden
            EndContext();
            BeginContext(1769, 125, true);
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"rating-item\">\n                            <span>3 ");
            EndContext();
            BeginContext(1895, 18, false);
#line 34 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                               Write(Localizer["stars"]);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 146, true);
            WriteLiteral("</span>\n                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2059, "\"", 2118, 1);
#line 36 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 2075, Model.GetRatingPercent(Model.Rating3Count), 2075, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2119, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2157, "\"", 2216, 3);
            WriteAttributeValue("", 2165, "width:", 2165, 6, true);
#line 36 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue(" ", 2171, Model.GetRatingPercent(Model.Rating3Count), 2172, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 2215, "%", 2215, 1, true);
            EndWriteAttribute();
            BeginContext(2217, 110, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                            <span>");
            EndContext();
            BeginContext(2328, 18, false);
#line 39 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             Write(Model.Rating3Count);

#line default
#line hidden
            EndContext();
            BeginContext(2346, 125, true);
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"rating-item\">\n                            <span>2 ");
            EndContext();
            BeginContext(2472, 18, false);
#line 42 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                               Write(Localizer["stars"]);

#line default
#line hidden
            EndContext();
            BeginContext(2490, 146, true);
            WriteLiteral("</span>\n                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2636, "\"", 2695, 1);
#line 44 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 2652, Model.GetRatingPercent(Model.Rating2Count), 2652, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2696, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2734, "\"", 2793, 3);
            WriteAttributeValue("", 2742, "width:", 2742, 6, true);
#line 44 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue(" ", 2748, Model.GetRatingPercent(Model.Rating2Count), 2749, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 2792, "%", 2792, 1, true);
            EndWriteAttribute();
            BeginContext(2794, 110, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                            <span>");
            EndContext();
            BeginContext(2905, 18, false);
#line 47 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             Write(Model.Rating2Count);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 125, true);
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"rating-item\">\n                            <span>1 ");
            EndContext();
            BeginContext(3049, 18, false);
#line 50 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                               Write(Localizer["stars"]);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 146, true);
            WriteLiteral("</span>\n                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3213, "\"", 3272, 1);
#line 52 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 3229, Model.GetRatingPercent(Model.Rating1Count), 3229, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3273, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3311, "\"", 3370, 3);
            WriteAttributeValue("", 3319, "width:", 3319, 6, true);
#line 52 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue(" ", 3325, Model.GetRatingPercent(Model.Rating1Count), 3326, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 3369, "%", 3369, 1, true);
            EndWriteAttribute();
            BeginContext(3371, 110, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                            <span>");
            EndContext();
            BeginContext(3482, 18, false);
#line 55 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             Write(Model.Rating1Count);

#line default
#line hidden
            EndContext();
            BeginContext(3500, 108, true);
            WriteLiteral("</span>\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 60 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
        }

#line default
#line hidden
            BeginContext(3618, 80, true);
            WriteLiteral("        <div class=\"col-md-7\">\n            <div id=\"addreview\">\n                ");
            EndContext();
            BeginContext(3698, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d62c90bee3d750e3e79f474251872ab77ea1f8c21175", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 63 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ReviewForm { EntityTypeId = Model.EntityTypeId, EntityId = Model.EntityId, HasBoughtProduct = Model.HasBoughtProduct, LoggedUserName = Model.LoggedUserName };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3933, 105, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <hr />\n    <div id=\"reviews\" class=\"review-item-list\">\n");
            EndContext();
#line 69 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
         if (Model.ReviewsCount > 0)
        {
            foreach (var review in Model.Items.Data)
            {

#line default
#line hidden
            BeginContext(4152, 131, true);
            WriteLiteral("                <div>\n                    <ul class=\"list-inline product-ratings\">\n                        <li><input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4283, "\"", 4305, 1);
#line 75 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
WriteAttributeValue("", 4291, review.Rating, 4291, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4306, 204, true);
            WriteLiteral(" readonly=\"readonly\" class=\"rating-loading\" step=\"1\" data-size=\"xs\" data-show-clear=\"false\" data-show-caption=\"false\" /></li>\n                        <li class=\"review-title\">\n                            ");
            EndContext();
            BeginContext(4511, 12, false);
#line 77 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                       Write(review.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4523, 80, true);
            WriteLiteral("\n                        </li>\n                    </ul>\n                    <p>");
            EndContext();
            BeginContext(4604, 14, false);
#line 80 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                  Write(review.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(4618, 40, true);
            WriteLiteral("</p>\n                    <p>By: <strong>");
            EndContext();
            BeginContext(4659, 19, false);
#line 81 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                              Write(review.ReviewerName);

#line default
#line hidden
            EndContext();
            BeginContext(4678, 19, true);
            WriteLiteral("</strong> on <span>");
            EndContext();
            BeginContext(4698, 16, false);
#line 81 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                                                     Write(review.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(4714, 12, true);
            WriteLiteral("</span></p>\n");
            EndContext();
#line 82 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                     if (review.Replies.Count > 0)
                    {

#line default
#line hidden
            BeginContext(4799, 96, true);
            WriteLiteral("                        <button class=\"btn-review-replies btn-view-review-replies btn btn-link\">");
            EndContext();
            BeginContext(4896, 25, false);
#line 84 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                                                                           Write(Localizer["View Replies"]);

#line default
#line hidden
            EndContext();
            BeginContext(4921, 139, true);
            WriteLiteral("<i class=\"arrow-down\"></i></button>\n                        <button class=\"btn-review-replies btn-hide-review-replies btn btn-link d-none\">");
            EndContext();
            BeginContext(5061, 25, false);
#line 85 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                                                                                  Write(Localizer["Hide Replies"]);

#line default
#line hidden
            EndContext();
            BeginContext(5086, 93, true);
            WriteLiteral("<i class=\"arrow-up\"></i></button>\n                        <ul class=\"review-replies d-none\">\n");
            EndContext();
#line 87 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                             foreach (var reply in review.Replies)
                            {

#line default
#line hidden
            BeginContext(5276, 97, true);
            WriteLiteral("                                <li class=\"review-reply\">\n                                    <p>");
            EndContext();
            BeginContext(5374, 13, false);
#line 90 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                  Write(reply.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(5387, 56, true);
            WriteLiteral("</p>\n                                    <p>By: <strong>");
            EndContext();
            BeginContext(5444, 17, false);
#line 91 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                              Write(reply.ReplierName);

#line default
#line hidden
            EndContext();
            BeginContext(5461, 19, true);
            WriteLiteral("</strong> on <span>");
            EndContext();
            BeginContext(5481, 15, false);
#line 91 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                                                                   Write(reply.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(5496, 50, true);
            WriteLiteral("</span></p>\n                                </li>\n");
            EndContext();
#line 93 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(5576, 30, true);
            WriteLiteral("                        </ul>\n");
            EndContext();
#line 95 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(5628, 100, true);
            WriteLiteral("                    <div>\n                        <button class=\"btn-add-review-reply btn btn-link\">");
            EndContext();
            BeginContext(5729, 22, false);
#line 97 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                                                     Write(Localizer["Add Reply"]);

#line default
#line hidden
            EndContext();
            BeginContext(5751, 100, true);
            WriteLiteral("</button>\n                        <div class=\"add-review-reply d-none\">\n                            ");
            EndContext();
            BeginContext(5851, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d62c90bee3d750e3e79f474251872ab77ea1f8c31155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 99 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ReplyForm { ReviewId = review.Id };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5961, 82, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 103 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
            }


#line default
#line hidden
            BeginContext(6058, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(6070, 331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d62c90bee3d750e3e79f474251872ab77ea1f8c33308", async() => {
                BeginContext(6361, 9, true);
                WriteLiteral("View all ");
                EndContext();
                BeginContext(6371, 18, false);
#line 111 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                                            Write(Model.ReviewsCount);

#line default
#line hidden
                EndContext();
                BeginContext(6389, 8, true);
                WriteLiteral(" reviews");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-entityId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                        WriteLiteral(Model.EntityId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["entityId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-entityId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["entityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 109 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
                            WriteLiteral(Model.EntityTypeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["entityTypeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-entityTypeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["entityTypeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6401, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 112 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Reviews/Areas/Reviews/Views/Shared/Components/Review/Default.cshtml"
        }

#line default
#line hidden
            BeginContext(6412, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels.ReviewVm> Html { get; private set; }
    }
}
#pragma warning restore 1591