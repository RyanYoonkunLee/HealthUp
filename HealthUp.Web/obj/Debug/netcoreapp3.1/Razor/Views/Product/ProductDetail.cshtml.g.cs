#pragma checksum "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cca9128028660a57220ec13157bafa9771b0053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\_ViewImports.cshtml"
using HealthUp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\_ViewImports.cshtml"
using HealthUp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cca9128028660a57220ec13157bafa9771b0053", @"/Views/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb119b37be0cd09db54539a9f3edd5608713490", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthUp.ViewModel.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n    ");
#nullable restore
#line 8 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.LabelFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.TextBoxFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.LabelFor(m => m.description));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.TextBoxFor(m => m.description));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.LabelFor(m => m.benefits));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.TextBoxFor(m => m.benefits));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.LabelFor(m => m.size));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 15 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Product\ProductDetail.cshtml"
Write(Html.TextBoxFor(m => m.size));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthUp.ViewModel.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591