#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Comments/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a3da4a29f923401f35cfbfd06f28de06cdd9a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Comments_Views_Comment__ReplyFormSuccess), @"mvc.1.0.view", @"/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml", typeof(AspNetCore.Areas_Comments_Views_Comment__ReplyFormSuccess))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Comments/Areas/Comments/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Comments/Areas/Comments/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a3da4a29f923401f35cfbfd06f28de06cdd9a2", @"/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b18b37fdf10ebd4e5da15d287bba8bbf9154ca2", @"/Areas/Comments/Views/_ViewImports.cshtml")]
    public class Areas_Comments_Views_Comment__ReplyFormSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Comments.Areas.Comments.ViewModels.CommentForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 65, true);
            WriteLiteral("\n<div class=\"alert alert-success\" role=\"alert\">\n    <h4>\n        ");
            EndContext();
            BeginContext(141, 63, false);
#line 5 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Comments/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml"
   Write(Localizer["Thank you {0} for your reply.", Model.CommenterName]);

#line default
#line hidden
            EndContext();
            BeginContext(204, 19, true);
            WriteLiteral("\n    </h4>\n\n    <p>");
            EndContext();
            BeginContext(224, 58, false);
#line 8 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Comments/Areas/Comments/Views/Comment/_ReplyFormSuccess.cshtml"
  Write(Localizer["Your reply will be shown within the next 24h."]);

#line default
#line hidden
            EndContext();
            BeginContext(282, 11, true);
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Comments.Areas.Comments.ViewModels.CommentForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
