#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f6c5cf494ec6474af847b9c6a5073f50e37d0d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_UncheckedCourses), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/UncheckedCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Courses/UncheckedCourses.cshtml", typeof(AspNetCore.Pages_Admin_Courses_UncheckedCourses), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6c5cf494ec6474af847b9c6a5073f50e37d0d3", @"/Pages/Admin/Courses/UncheckedCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_UncheckedCourses : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/EditUncheckedCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
  
    ViewData["Title"] = "لیست  دروس بررسی نشده";

#line default
#line hidden
            BeginContext(132, 102, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"my-5 text-danger\"> <i class=\"fa fa-user-secret ml-2\"></i> ");
            EndContext();
            BeginContext(235, 17, false);
#line 10 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                                                    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(252, 40, true);
            WriteLiteral("</h1>\r\n\r\n    <!-- create succeeded -->\r\n");
            EndContext();
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(338, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(394, 19, false);
#line 16 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(413, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
    }

#line default
#line hidden
            BeginContext(438, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(444, 879, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f6c5cf494ec6474af847b9c6a5073f50e37d0d38180", async() => {
                BeginContext(469, 847, true);
                WriteLiteral(@"

        <div class=""row p-3"">

            <!-- title -->
            <div class=""col-12 col-sm-12 col-md-4"">
                <div class=""form-group"">
                    <input type=""text"" id=""title"" name=""title""
                           class=""form-control"">
                    <label for=""username"">عنوان دوره</label>
                </div>
            </div>

            <!-- search -->
            <div class=""col-12 col-sm-12 col-md-4"">
                <button class=""btn btn-primary""> <i class=""fa fa-search ml-2""></i> جستجو</button>
                <a href=""/Admin/Courses/UncheckedCourses"" class=""btn btn-secondary""> <i class=""fa fa-filter ml-2""></i> حذف فیلترها</a>
            </div>

            <!-- search -->
            <div class=""col-12 col-sm-12 col-md-4"">

            </div>

        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1323, 204, true);
            WriteLiteral("\r\n\r\n    <div class=\"my-3 clearfix\">\r\n        <!-- count -->\r\n        <a href=\"javascript:void(0)\"\r\n           class=\"btn btn-primary float-left english-font\">\r\n            <i class=\"fa fa-list ml-1\"></i> ");
            EndContext();
            BeginContext(1528, 18, false);
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                       Write(Model.CoursesCount);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 819, true);
            WriteLiteral(@"
        </a>
    </div>

    <!-- users table -->
    <div class=""table-responsive"">
        <table class=""table table-striped table-bordered"">
            <tr>
                <th class=""th-sm"">
                    تصویر دوره
                </th>
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
                    درصد استاد
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
#line 81 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
             if (Model.CourseVM.Courses.Count == 0)
            {

#line default
#line hidden
            BeginContext(2433, 244, true);
            WriteLiteral("                <tr class=\"bg-dark text-light\">\r\n                    <td colspan=\"7\" class=\"py-4\">\r\n                        <i class=\"fas fa-exclamation-triangle ml-2\"></i> لیست دروس خالی است.\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 91 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                 foreach (var course in Model.CourseVM.Courses)
                {

#line default
#line hidden
            BeginContext(2809, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2893, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f6c5cf494ec6474af847b9c6a5073f50e37d0d313230", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2960, "~/Images/Courses/", 2960, 17, true);
#line 96 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
AddHtmlAttributeValue("", 2977, course.ImageName, 2977, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 97 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
AddHtmlAttributeValue("", 3035, course.Title, 3035, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3105, 82, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(3188, 15, false);
#line 100 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                            Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(3203, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3239, 12, false);
#line 101 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                       Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3251, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3287, 14, false);
#line 102 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                       Write(course.Teacher);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3337, 21, false);
#line 103 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                       Write(course.TeacherPercent);

#line default
#line hidden
            EndContext();
            BeginContext(3358, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(3415, 20, false);
#line 104 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                            Write(course.EpisodesCount);

#line default
#line hidden
            EndContext();
            BeginContext(3435, 87, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n\r\n                            ");
            EndContext();
            BeginContext(3522, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f6c5cf494ec6474af847b9c6a5073f50e37d0d317676", async() => {
                BeginContext(3750, 101, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                 WriteLiteral(course.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3855, 62, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 116 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                }

#line default
#line hidden
#line 116 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3951, 34, true);
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 122 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
     if (Model.CourseVM.PageCount > 1)
    {

#line default
#line hidden
            BeginContext(4032, 172, true);
            WriteLiteral("        <!-- pagination -->\r\n        <nav aria-label=\"Page navigation\" class=\"my-3\">\r\n            <ul class=\"pagination pagination-circle pg-dark justify-content-center\">\r\n");
            EndContext();
#line 127 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                 for (int i = 1; i <= Model.CourseVM.PageCount; i++)
                {

#line default
#line hidden
            BeginContext(4293, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4316, "\"", 4399, 3);
            WriteAttributeValue("", 4324, "page-item", 4324, 9, true);
            WriteAttributeValue(" ", 4333, "english-font", 4334, 13, true);
#line 129 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
WriteAttributeValue(" ", 4346, (Model.CourseVM.CurrentPage == i) ? "active" : "", 4347, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4400, 29, true);
            WriteLiteral(">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4429, "\"", 4460, 2);
            WriteAttributeValue("", 4436, "/Admin/Courses?pageId=", 4436, 22, true);
#line 130 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
WriteAttributeValue("", 4458, i, 4458, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4461, 19, true);
            WriteLiteral(" class=\"page-link\">");
            EndContext();
            BeginContext(4481, 1, false);
#line 130 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4482, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 132 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
                }

#line default
#line hidden
            BeginContext(4534, 35, true);
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
            EndContext();
#line 135 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\UncheckedCourses.cshtml"
    }

#line default
#line hidden
            BeginContext(4576, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Courses.UncheckedCoursesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.UncheckedCoursesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.UncheckedCoursesModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Courses.UncheckedCoursesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
