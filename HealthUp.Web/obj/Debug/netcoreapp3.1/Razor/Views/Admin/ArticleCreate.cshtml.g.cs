#pragma checksum "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427badf40bb9192c4917e846d422167782197340"
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\_ViewImports.cshtml"
using HealthUp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\_ViewImports.cshtml"
using HealthUp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427badf40bb9192c4917e846d422167782197340", @"/Views/Admin/ArticleCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb119b37be0cd09db54539a9f3edd5608713490", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ArticleCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthUp.ViewModel.ArticleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mb-5 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
  
    ViewData["Title"] = "ArticleCreate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"titlefont mb-5 mt-4\">ArticleCreate</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
 using (Html.BeginForm("ArticleCreate", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.ThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.ThumbnailImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.BannerImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextBoxFor(m => m.BannerImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group overflow-hidden\">\r\n        ");
#nullable restore
#line 24 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.RelateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-control overflow-hidden\">\r\n");
#nullable restore
#line 26 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
             foreach (var item in ViewBag.ProductList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"m-3 width-30 float-left\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1225, "\"", 1241, 1);
#nullable restore
#line 29 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1233, item.Id, 1233, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1242, "\"", 1271, 2);
#nullable restore
#line 29 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1247, item.Name, 1247, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue(" ", 1257, item.Capsule, 1258, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"RelateProduct\">\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1347, "\"", 1377, 2);
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue("", 1353, item.Name, 1353, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
WriteAttributeValue(" ", 1363, item.Capsule, 1364, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
                                                                                         Write(item.Capsule);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
#nullable restore
#line 34 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.RelateProduct, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.LabelFor(m => m.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.TextAreaFor(m => m.Body, new { @class = "form-control", rows = "20" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Body, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary mb-5\">Submit</button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "427badf40bb9192c4917e846d42216778219734012535", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Yoonkun Lee\Desktop\Live Project\HealthUp\HealthUp.Web\Views\Admin\ArticleCreate.cshtml"
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
