#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28dcfc4f1f989c0027af848d2c25c4fdc7c43d02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dcfc4f1f989c0027af848d2c25c4fdc7c43d02", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae303af3b1ab63ab81fe330170c9bf6fbfbe3176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SearchWidgetPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GroupPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CoursePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
  
    ViewBag.Title = "صفحه اصلی";

#line default
#line hidden
            BeginContext(66, 187, true);
            WriteLiteral("\r\n    <div class=\"container clearfix\">\r\n\r\n        <h1 class=\"text-center title-font-size my-5 pt-5\">با دیجی معلم، سریع، آسان و مطمئن یاد بگیر</h1>\r\n\r\n        <!-- search box -->\r\n        ");
            EndContext();
            BeginContext(253, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dcfc4f1f989c0027af848d2c25c4fdc7c43d025898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(292, 68, true);
            WriteLiteral("\r\n\r\n        <!-- categories -->\r\n        <div class=\"row mx-auto\">\r\n");
            EndContext();
#line 16 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
             foreach (var group in Model.Groups)
            {

#line default
#line hidden
            BeginContext(425, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(441, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dcfc4f1f989c0027af848d2c25c4fdc7c43d027531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = group;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(504, 253, true);
            WriteLiteral("        </div>\r\n\r\n        <br /><br />\r\n\r\n        <h3 class=\"my-3 py-3 border-bottom border-dark\">\r\n            <i class=\"fa fa-clock ml-2\"></i> جدیدترین دوره ها\r\n        </h3>\r\n\r\n        <!-- latest courses -->\r\n        <div class=\"row mx-auto pb-5\">\r\n");
            EndContext();
#line 30 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
             foreach (var course in Model.LatestCourses)
            {

#line default
#line hidden
            BeginContext(830, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(846, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dcfc4f1f989c0027af848d2c25c4fdc7c43d0210028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 32 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = course;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(894, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(911, 42, true);
            WriteLiteral("        </div>\r\n\r\n        <br /><br />\r\n\r\n");
            EndContext();
#line 38 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
         if (Model.LatestFavoriteCourses.Any())
        {

#line default
#line hidden
            BeginContext(1013, 146, true);
            WriteLiteral("            <h3 class=\"my-3 py-3 border-bottom border-dark\">\r\n                <i class=\"fa fa-clock ml-2\"></i> برترین دوره ها\r\n            </h3>\r\n");
            EndContext();
            BeginContext(1161, 83, true);
            WriteLiteral("            <!-- favorite courses -->\r\n            <div class=\"row mx-auto pb-5\">\r\n");
            EndContext();
#line 46 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
                 foreach (var course in Model.LatestFavoriteCourses)
                {

#line default
#line hidden
            BeginContext(1333, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1353, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dcfc4f1f989c0027af848d2c25c4fdc7c43d0212950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 48 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = course;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1422, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1453, 12, true);
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
