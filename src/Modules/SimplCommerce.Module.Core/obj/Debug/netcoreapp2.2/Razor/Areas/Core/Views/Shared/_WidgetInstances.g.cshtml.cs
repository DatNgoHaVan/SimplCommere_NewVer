#pragma checksum "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e267a8bdec40682e82cf3dc865977d4d51e272f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_Shared__WidgetInstances), @"mvc.1.0.view", @"/Areas/Core/Views/Shared/_WidgetInstances.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Core/Views/Shared/_WidgetInstances.cshtml", typeof(AspNetCore.Areas_Core_Views_Shared__WidgetInstances))]
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
#line 1 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#line 2 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Account;

#line default
#line hidden
#line 4 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage;

#line default
#line hidden
#line 5 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e267a8bdec40682e82cf3dc865977d4d51e272f0", @"/Areas/Core/Views/Shared/_WidgetInstances.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f9af2dbfb59a463c9fdb28e6eb5cce06455bad", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_Shared__WidgetInstances : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.WidgetInstanceViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml"
 foreach (var widgetInstance in Model)
{
    if (widgetInstance.WidgetId == "HtmlWidget")
    {
        

#line default
#line hidden
            BeginContext(198, 33, false);
#line 7 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml"
   Write(Html.Raw(widgetInstance.HtmlData));

#line default
#line hidden
            EndContext();
#line 7 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml"
                                          
    }
    else
    {
        

#line default
#line hidden
            BeginContext(262, 102, false);
#line 11 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml"
   Write(await Component.InvokeAsync(widgetInstance.ViewComponentName, new { widgetInstance = widgetInstance }));

#line default
#line hidden
            EndContext();
#line 11 "/mnt/3B710B7935906684/Training/SimplCommerce_NewVer/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/_WidgetInstances.cshtml"
                                                                                                               
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.WidgetInstanceViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
