#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672af67b586c5e7cd7ba324e3b40966e48b93b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PaymentPaypalExpress_Views_Shared_Components_PaypalExpressLanding_Default), @"mvc.1.0.view", @"/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml", typeof(AspNetCore.Areas_PaymentPaypalExpress_Views_Shared_Components_PaypalExpressLanding_Default))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672af67b586c5e7cd7ba324e3b40966e48b93b90", @"/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/PaymentPaypalExpress/Views/_ViewImports.cshtml")]
    public class Areas_PaymentPaypalExpress_Views_Shared_Components_PaypalExpressLanding_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.PaymentPaypalExpress.ViewModels.PaypalExpressCheckoutForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(86, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml"
   
    var feeDisplay = "";
    if(Model.PaymentFee > 0)
    {
        feeDisplay = $"(+ {Model.PaymentFee}% Fee)";
    }

#line default
#line hidden
            BeginContext(212, 22, true);
            WriteLiteral("<label>Paypal Express ");
            EndContext();
            BeginContext(235, 10, false);
#line 10 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml"
                 Write(feeDisplay);

#line default
#line hidden
            EndContext();
            BeginContext(245, 162, true);
            WriteLiteral("</label>\n<div id=\"paypal-button\"></div>\n\n<script src=\"https://www.paypalobjects.com/api/checkout.js\"></script>\n\n<script>\n    paypal.Button.render({\n        env: \'");
            EndContext();
            BeginContext(408, 17, false);
#line 17 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.PaymentPaypalExpress/Areas/PaymentPaypalExpress/Views/Shared/Components/PaypalExpressLanding/Default.cshtml"
         Write(Model.Environment);

#line default
#line hidden
            EndContext();
            BeginContext(425, 1180, true);
            WriteLiteral(@"', // sandbox | production
        // Show the buyer a 'Pay Now' button in the checkout flow
        commit: true,
        payment: function (data, actions) {
            return paypal.request.post('/PaypalExpress/CreatePayment')
                .then(function (res) {
                    return res.paymentId;
                })
                .catch(function (error) { 
                    var errorDiv = document.getElementById(""paymentError"");
                    errorDiv.innerText = error
                    errorDiv.style.display = ""block"";
                });
        },

        onAuthorize: function (data, actions) {
            return paypal.request.post('/PaypalExpress/ExecutePayment', {
                paymentID: data.paymentID,
                payerID: data.payerID
            })
            .then(function (res) {
                window.location = ""/checkout/congratulation"";
            })
            .catch(function (error) {
                var errorDiv = document.getElementById(""paymentError"");
  ");
            WriteLiteral("              errorDiv.innerText = error\n                errorDiv.style.display = \"block\";\n            });\n        }\n    },\n    \'#paypal-button\');\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.PaymentPaypalExpress.ViewModels.PaypalExpressCheckoutForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
