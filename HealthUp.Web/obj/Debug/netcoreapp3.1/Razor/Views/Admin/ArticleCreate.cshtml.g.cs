#pragma checksum "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "412375462d0e1627f70826bdea0ebb9c397c3fad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ArticleCreate), @"mvc.1.0.view", @"/Views/Admin/ArticleCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412375462d0e1627f70826bdea0ebb9c397c3fad", @"/Views/Admin/ArticleCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb119b37be0cd09db54539a9f3edd5608713490", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ArticleCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthUp.ViewModel.ArticleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
  
    ViewData["Title"] = "ArticleCreate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"titlefont mb-5\">ArticleCreate</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
 using (Html.BeginForm("ArticleCreate", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.ThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.ThumbnailImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.BannerImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.BannerImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group overflow-hidden\">\r\n        ");
#nullable restore
#line 25 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.RelateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-control overflow-hidden\">\r\n");
#nullable restore
#line 27 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
             foreach (var item in ViewBag.ProductList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"m-3 width-30 float-left\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1222, "\"", 1240, 1);
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1230, item.Name, 1230, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1241, "\"", 1256, 1);
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1246, item.Name, 1246, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"RelateProduct\">\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1332, "\"", 1348, 1);
#nullable restore
#line 31 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1338, item.Name, 1338, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
#nullable restore
#line 35 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.RelateProduct, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Body, new { @class = "form-control", rows = "20" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Body, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary mb-5\">Submit</button>\r\n");
#nullable restore
#line 44 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthUp.ViewModel.ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591