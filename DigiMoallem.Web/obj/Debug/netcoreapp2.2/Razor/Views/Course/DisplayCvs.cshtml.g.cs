#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68001f5882e32ca3c32840f7a5b1d24c642457f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_DisplayCvs), @"mvc.1.0.view", @"/Views/Course/DisplayCvs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/DisplayCvs.cshtml", typeof(AspNetCore.Views_Course_DisplayCvs))]
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
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Accounts;

#line default
#line hidden
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Courses;

#line default
#line hidden
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Courses;

#line default
#line hidden
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Display;

#line default
#line hidden
#line 7 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.General;

#line default
#line hidden
#line 8 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Interfaces;

#line default
#line hidden
#line 9 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Works;

#line default
#line hidden
#line 10 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Helpers.Converters;

#line default
#line hidden
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Users;

#line default
#line hidden
#line 12 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.UserPanel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68001f5882e32ca3c32840f7a5b1d24c642457f", @"/Views/Course/DisplayCvs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fe694c4a9b53c5ef0debe01dfffe622713273d", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_DisplayCvs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid d-block mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
  
    ViewData["Title"] = $"رزومه {Model.FirstName} {Model.LastName}";

#line default
#line hidden
            BeginContext(92, 122, true);
            WriteLiteral("\r\n<section class=\"container my-4\">\r\n    <div class=\"card\">\r\n\r\n        <!-- fullname -->\r\n        <div class=\"card-header\">");
            EndContext();
            BeginContext(215, 17, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                            Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(232, 185, true);
            WriteLiteral("</div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-sm-4\">\r\n\r\n                    <!-- user avatar -->\r\n                    ");
            EndContext();
            BeginContext(417, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d68001f5882e32ca3c32840f7a5b1d24c642457f6116", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 427, "~/images/avatars/", 427, 17, true);
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
AddHtmlAttributeValue("", 444, Model.UserAvatar, 444, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
AddHtmlAttributeValue("", 494, Model.FirstName, 494, 16, false);

#line default
#line hidden
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
AddHtmlAttributeValue(" ", 510, Model.LastName, 511, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(590, 114, true);
            WriteLiteral("\r\n\r\n                    <h1 class=\"text-center border-bottom border-secondary pb-4 my-3\" style=\"font-size:1.5rem\">");
            EndContext();
            BeginContext(705, 15, false);
#line 22 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                                                                                                         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(720, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(722, 14, false);
#line 22 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                                                                                                                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(736, 274, true);
            WriteLiteral(@"</h1>

                </div>
                <div class=""col-12 col-sm-8"">

                    <h4 class=""mb-4"">مدرس دیجی معلم</h4>

                    <div class=""my-5"">
                        <h5>رشته تحصیلی:</h5>
                        <p class=""text-dark"">");
            EndContext();
            BeginContext(1011, 21, false);
#line 31 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                                        Write(Model.ScientificField);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 151, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div>\r\n                        <h5>توضیحات:</h5>\r\n                        <p class=\"text-dark\">");
            EndContext();
            BeginContext(1184, 17, false);
#line 36 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 192, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"my-5\">\r\n                        <h5 class=\"mb-4\">مهارت ها:</h5>\r\n                        <ul class=\"list-group text-dark\">\r\n");
            EndContext();
#line 42 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                             foreach (var skill in Model.Skills.Split("-"))
                            {

#line default
#line hidden
            BeginContext(1501, 98, true);
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    ");
            EndContext();
            BeginContext(1600, 5, false);
#line 45 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                               Write(skill);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 47 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                            }

#line default
#line hidden
            BeginContext(1677, 219, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n\r\n                    <div class=\"my-4\">\r\n                        <h5 class=\"mb-4\">سوابق کاری:</h5>\r\n                        <ul class=\"list-group text-dark\">\r\n");
            EndContext();
#line 54 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                             foreach (var experience in Model.Experiences.Split("-"))
                            {

#line default
#line hidden
            BeginContext(2014, 98, true);
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    ");
            EndContext();
            BeginContext(2113, 10, false);
#line 57 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                               Write(experience);

#line default
#line hidden
            EndContext();
            BeginContext(2123, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 59 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Course\DisplayCvs.cshtml"
                            }

#line default
#line hidden
            BeginContext(2195, 147, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
