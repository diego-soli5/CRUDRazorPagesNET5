#pragma checksum "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1252358a95398a04e1af268ee035f28a32ee5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CRUDRazorPages.Web.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace CRUDRazorPages.Web.Pages
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
#line 1 "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\_ViewImports.cshtml"
using CRUDRazorPages.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1252358a95398a04e1af268ee035f28a32ee5e", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ef0e5c6bb25dadf464eede998e537df7022e1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">Ha ocurrido un error mientras se procesaba tu solicitud.</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\1dieg\Documents\.NET\.NET CORE\ASP.NET Razor Pages (MVVM)\CRUDRazorPages\CRUDRazorPages.Web\Pages\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Sugerencias</h3>\r\n<p>\r\n    Intentalo más tarde.\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
