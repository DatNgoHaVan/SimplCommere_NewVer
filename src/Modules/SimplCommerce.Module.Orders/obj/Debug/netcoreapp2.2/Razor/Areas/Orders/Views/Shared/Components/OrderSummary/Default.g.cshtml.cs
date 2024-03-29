#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ced399d9c2b6729dd818ce81bd98d340e1413a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Orders_Views_Shared_Components_OrderSummary_Default), @"mvc.1.0.view", @"/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml", typeof(AspNetCore.Areas_Orders_Views_Shared_Components_OrderSummary_Default))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ced399d9c2b6729dd818ce81bd98d340e1413a4", @"/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/Orders/Views/_ViewImports.cshtml")]
    public class Areas_Orders_Views_Shared_Components_OrderSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.CartVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 5, true);
            WriteLiteral("\n<h3>");
            EndContext();
            BeginContext(84, 26, false);
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
Write(Localizer["Order summary"]);

#line default
#line hidden
            EndContext();
            BeginContext(110, 50, true);
            WriteLiteral(" </h3>\n<table class=\"table\">\n    <tr>\n        <th>");
            EndContext();
            BeginContext(161, 20, false);
#line 6 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
       Write(Localizer["Product"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 38, true);
            WriteLiteral("</th>\n        <th class=\"text-center\">");
            EndContext();
            BeginContext(220, 21, false);
#line 7 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                           Write(Localizer["Quantity"]);

#line default
#line hidden
            EndContext();
            BeginContext(241, 37, true);
            WriteLiteral("</th>\n        <th class=\"text-right\">");
            EndContext();
            BeginContext(279, 18, false);
#line 8 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                          Write(Localizer["Price"]);

#line default
#line hidden
            EndContext();
            BeginContext(297, 16, true);
            WriteLiteral("</th>\n    </tr>\n");
            EndContext();
#line 10 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
            BeginContext(358, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(405, 16, false);
#line 14 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
           Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(421, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                 if (item.VariationOptions.Any())
                {

#line default
#line hidden
            BeginContext(490, 47, true);
            WriteLiteral("                    <ul class=\"list-unstyled\">\n");
            EndContext();
#line 18 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                         foreach (var attr in item.VariationOptions)
                        {

#line default
#line hidden
            BeginContext(632, 38, true);
            WriteLiteral("                            <li><span>");
            EndContext();
            BeginContext(671, 15, false);
#line 20 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                 Write(attr.OptionName);

#line default
#line hidden
            EndContext();
            BeginContext(686, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(696, 10, false);
#line 20 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                                          Write(attr.Value);

#line default
#line hidden
            EndContext();
            BeginContext(706, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(738, 26, true);
            WriteLiteral("                    </ul>\n");
            EndContext();
#line 23 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                }

#line default
#line hidden
            BeginContext(782, 54, true);
            WriteLiteral("            </td>\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(837, 13, false);
#line 25 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(850, 41, true);
            WriteLiteral("</td>\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(892, 23, false);
#line 26 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                              Write(item.ProductPriceString);

#line default
#line hidden
            EndContext();
            BeginContext(915, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 28 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(941, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(963, 23, false);
#line 30 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
       Write(Localizer["Order note"]);

#line default
#line hidden
            EndContext();
            BeginContext(986, 49, true);
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
            EndContext();
            BeginContext(1036, 15, false);
#line 31 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                      Write(Model.OrderNote);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 37, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
            EndContext();
            BeginContext(1089, 21, false);
#line 34 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
       Write(Localizer["Subtotal"]);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 49, true);
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
            EndContext();
            BeginContext(1160, 28, false);
#line 35 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                      Write(Model.SubTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 39, true);
            WriteLiteral("<input type=\"hidden\" id=\"orderSubtotal\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1227, "\"", 1250, 1);
#line 35 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
WriteAttributeValue("", 1235, Model.SubTotal, 1235, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1251, 40, true);
            WriteLiteral(" /></td>\n    </tr>\n    <tr>\n        <td>");
            EndContext();
            BeginContext(1292, 21, false);
#line 38 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
       Write(Localizer["Shipping"]);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 75, true);
            WriteLiteral("</td>\n        <td colspan=\"2\" id=\"orderSummaryShipping\" class=\"text-right\">");
            EndContext();
            BeginContext(1389, 26, false);
#line 39 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                                                Write(Model.ShippingAmountString);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 41 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
     if (!Model.IsProductPriceIncludeTax)
    {

#line default
#line hidden
            BeginContext(1479, 106, true);
            WriteLiteral("        <tr>\n            <td>Tax</td>\n            <td colspan=\"2\" id=\"orderSummaryTax\" class=\"text-right\">");
            EndContext();
            BeginContext(1586, 21, false);
#line 45 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                                               Write(Model.TaxAmountString);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 47 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(1633, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(1655, 21, false);
#line 49 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
       Write(Localizer["Discount"]);

#line default
#line hidden
            EndContext();
            BeginContext(1676, 49, true);
            WriteLiteral("</td>\n        <td colspan=\"2\" class=\"text-right\">");
            EndContext();
            BeginContext(1726, 28, false);
#line 50 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                      Write(Model.Discount.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 58, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>\n            <strong>");
            EndContext();
            BeginContext(1813, 24, false);
#line 54 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
               Write(Localizer["Order Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
#line 55 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
             if (Model.IsProductPriceIncludeTax)
            {

#line default
#line hidden
            BeginContext(1910, 24, true);
            WriteLiteral("                <span> (");
            EndContext();
            BeginContext(1935, 25, false);
#line 57 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                   Write(Localizer["VAT included"]);

#line default
#line hidden
            EndContext();
            BeginContext(1960, 9, true);
            WriteLiteral(")</span>\n");
            EndContext();
#line 58 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1983, 81, true);
            WriteLiteral("        </td>\n        <td colspan=\"2\" class=\"text-right\"><strong id=\"orderTotal\">");
            EndContext();
            BeginContext(2065, 30, false);
#line 60 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Orders/Areas/Orders/Views/Shared/Components/OrderSummary/Default.cshtml"
                                                              Write(Model.OrderTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 34, true);
            WriteLiteral("</strong></td>\n    </tr>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.CartVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
