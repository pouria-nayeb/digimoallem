#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0b48a29aaa6b6a81885c98ec627d6c7a3bc658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Courses/Index.cshtml", typeof(AspNetCore.Pages_Admin_Courses_Index), null)]
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
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\_ViewImports.cshtml"
using DigiMoallem.BLL.Helpers.Converters;

#line default
#line hidden
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Users;

#line default
#line hidden
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Permissions;

#line default
#line hidden
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\_ViewImports.cshtml"
using DigiMoallem.BLL.Interfaces;

#line default
#line hidden
#line 7 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.General;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a0b48a29aaa6b6a81885c98ec627d6c7a3bc658", @"/Pages/Admin/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/Episodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
  
    ViewData["Title"] = "لیست دروس";

#line default
#line hidden
            BeginContext(149, 87, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"my-5\"> <i class=\"fa fa-database ml-2\"></i> ");
            EndContext();
            BeginContext(237, 17, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(254, 40, true);
            WriteLiteral("</h1>\r\n\r\n    <!-- create succeeded -->\r\n");
            EndContext();
#line 14 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(340, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(396, 19, false);
#line 17 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(415, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(440, 24, true);
            WriteLiteral("\r\n    <!-- add -->\r\n    ");
            EndContext();
            BeginContext(464, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0b48a29aaa6b6a81885c98ec627d6c7a3bc6588733", async() => {
                BeginContext(550, 63, true);
                WriteLiteral("\r\n        <i class=\"fa fa-plus ml-2\"></i> افزودن درس جدید\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(617, 700, true);
            WriteLiteral(@"

    <!-- users table -->
    <div class=""table-responsive"">
        <table class=""table table-striped table-bordered"">
            <tr>
                <th class=""th-sm"">
                    شناسه
                </th>
                <th class=""th-sm"">
                    عنوان دوره
                </th>
                <th class=""th-sm"">
                    نام استاد
                </th>
                <th class=""th-sm"">
                    طول دوره
                </th>
                <th class=""th-sm"">
                    تعداد بخش ها
                </th>
                <th class=""th-sm"">
                    دستورات
                </th>
            </tr>
");
            EndContext();
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
             if (Model.CourseVM.Courses.Count == 0)
            {

#line default
#line hidden
            BeginContext(1385, 244, true);
            WriteLiteral("                <tr class=\"bg-dark text-light\">\r\n                    <td colspan=\"6\" class=\"py-4\">\r\n                        <i class=\"fas fa-exclamation-triangle ml-2\"></i> لیست دروس خالی است.\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 61 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                 foreach (var course in Model.CourseVM.Courses)
                {

#line default
#line hidden
            BeginContext(1761, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1815, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a0b48a29aaa6b6a81885c98ec627d6c7a3bc65812299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1883, "~/Images/Courses/", 1883, 17, true);
#line 65 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
AddHtmlAttributeValue("", 1900, course.ImageName, 1900, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 66 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
AddHtmlAttributeValue("", 1959, course.Title, 1959, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2063, 82, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(2146, 15, false);
#line 70 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                            Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2197, 12, false);
#line 71 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                       Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2245, 14, false);
#line 72 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                       Write(course.Teacher);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(2316, 20, false);
#line 73 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                            Write(course.EpisodesCount);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 87, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n\r\n                            ");
            EndContext();
            BeginContext(2423, 318, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0b48a29aaa6b6a81885c98ec627d6c7a3bc65816268", async() => {
                BeginContext(2636, 101, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                 WriteLiteral(course.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2741, 32, true);
            WriteLiteral("\r\n\r\n                            ");
            EndContext();
            BeginContext(2773, 323, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0b48a29aaa6b6a81885c98ec627d6c7a3bc65819026", async() => {
                BeginContext(2990, 102, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-plus ml-2\"></i> بخش ها\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                 WriteLiteral(course.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3096, 62, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                }

#line default
#line hidden
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3192, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICourseService _courseService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Courses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.IndexModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Courses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
