#pragma checksum "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086157ee980021442235a2472f951e2b7d45cdcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductCreate), @"mvc.1.0.view", @"/Views/Admin/ProductCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086157ee980021442235a2472f951e2b7d45cdcc", @"/Views/Admin/ProductCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb119b37be0cd09db54539a9f3edd5608713490", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthUp.ViewModel.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
  
    ViewData["Title"] = "ProductCreate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"titlefont mb-5\">Create Product</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
 using (Html.BeginForm("ProductCreate", "Admin", FormMethod.Post))
{



#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 17 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextBoxFor(m => m.ThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 25 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Benefits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Benefits, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Dosage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Dosage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Ingredient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Ingredient, new { @class = "form-control", rows = "3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Size, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 41 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.CategoryExpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextBoxFor(m => m.CategoryExpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.CategoryExpose, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 46 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.ProductExpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextBoxFor(m => m.ProductExpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.ProductExpose, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group overflow-hidden\">\r\n        ");
#nullable restore
#line 51 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Function));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-control overflow-hidden\">\r\n");
#nullable restore
#line 53 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
             foreach (var item in ViewBag.Functions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"m-3 width-30 float-left\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2207, "\"", 2225, 1);
#nullable restore
#line 56 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2215, item.Name, 2215, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2226, "\"", 2241, 1);
#nullable restore
#line 56 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2231, item.Name, 2231, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Function\">\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2312, "\"", 2328, 1);
#nullable restore
#line 57 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2318, item.Name, 2318, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
#nullable restore
#line 61 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Function, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group overflow-hidden\">\r\n        ");
#nullable restore
#line 65 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-control overflow-hidden\">\r\n");
#nullable restore
#line 67 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
             foreach (var item in ViewBag.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"m-3 width-30 float-left\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2839, "\"", 2857, 1);
#nullable restore
#line 70 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2847, item.Name, 2847, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2858, "\"", 2873, 1);
#nullable restore
#line 70 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2863, item.Name, 2863, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Category\">\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2944, "\"", 2960, 1);
#nullable restore
#line 71 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
WriteAttributeValue("", 2950, item.Name, 2950, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 73 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
#nullable restore
#line 75 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Category, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 79 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.LabelFor(m => m.ProductImages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 80 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"
   Write(Html.TextAreaFor(m => m.ProductImages, new { @class = "form-control", rows = "3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary mb-5\">Submit</button>\r\n");
#nullable restore
#line 84 "C:\Users\Yoonkun Lee\Desktop\New Guinea\HealthUp\HealthUp.Web\Views\Admin\ProductCreate.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthUp.ViewModel.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
