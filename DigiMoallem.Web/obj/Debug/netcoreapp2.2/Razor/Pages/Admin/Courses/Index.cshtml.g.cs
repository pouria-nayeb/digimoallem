#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5182377faa4878f6693c345aa5b9cc3e84a77b6d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5182377faa4878f6693c345aa5b9cc3e84a77b6d", @"/Pages/Admin/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/Episodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(149, 106, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <h1 class=\"my-5\"> <i class=\"fa fa-book-open text-info ml-2\"></i> ");
            EndContext();
            BeginContext(256, 17, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                                                    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(273, 44, true);
            WriteLiteral("</h1>\r\n\r\n        <!-- create succeeded -->\r\n");
            EndContext();
#line 14 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(371, 63, true);
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                ");
            EndContext();
            BeginContext(435, 19, false);
#line 17 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
           Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(454, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(487, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(497, 938, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5182377faa4878f6693c345aa5b9cc3e84a77b6d9790", async() => {
                BeginContext(522, 906, true);
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
                    <a href=""/Admin/Courses"" class=""btn btn-secondary""> <i class=""fa fa-filter ml-2""></i> حذف فیلترها</a>
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
            BeginContext(1435, 79, true);
            WriteLiteral("\r\n\r\n        <div class=\"my-3 clearfix\">\r\n            <!-- add -->\r\n            ");
            EndContext();
            BeginContext(1514, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5182377faa4878f6693c345aa5b9cc3e84a77b6d12342", async() => {
                BeginContext(1623, 79, true);
                WriteLiteral("\r\n                <i class=\"fa fa-plus ml-2\"></i> افزودن درس جدید\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1706, 44, true);
            WriteLiteral("\r\n\r\n            <!-- count -->\r\n            ");
            EndContext();
            BeginContext(1750, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5182377faa4878f6693c345aa5b9cc3e84a77b6d14124", async() => {
                BeginContext(1850, 50, true);
                WriteLiteral("\r\n                <i class=\"fa fa-list ml-1\"></i> ");
                EndContext();
                BeginContext(1901, 18, false);
#line 60 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                           Write(Model.CoursesCount);

#line default
#line hidden
                EndContext();
                BeginContext(1919, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1937, 808, true);
            WriteLiteral(@"
        </div>

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
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                 if (Model.CourseVM.Courses.Count == 0)
                {

#line default
#line hidden
            BeginContext(2821, 264, true);
            WriteLiteral(@"                    <tr class=""bg-dark text-light"">
                        <td colspan=""6"" class=""py-4"">
                            <i class=""fas fa-exclamation-triangle ml-2""></i> لیست دروس خالی است.
                        </td>
                    </tr>
");
            EndContext();
#line 94 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 97 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                     foreach (var course in Model.CourseVM.Courses)
                    {

#line default
#line hidden
            BeginContext(3237, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3333, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5182377faa4878f6693c345aa5b9cc3e84a77b6d18284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3404, "~/Images/Courses/", 3404, 17, true);
#line 102 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
AddHtmlAttributeValue("", 3421, course.ImageName, 3421, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 103 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
AddHtmlAttributeValue("", 3483, course.Title, 3483, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3557, 90, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(3648, 15, false);
#line 106 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                                Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(3663, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3703, 12, false);
#line 107 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                           Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3715, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3755, 14, false);
#line 108 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                           Write(course.Teacher);

#line default
#line hidden
            EndContext();
            BeginContext(3769, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(3830, 20, false);
#line 109 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                                Write(course.EpisodesCount);

#line default
#line hidden
            EndContext();
            BeginContext(3850, 95, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n\r\n                                ");
            EndContext();
            BeginContext(3945, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5182377faa4878f6693c345aa5b9cc3e84a77b6d22303", async() => {
                BeginContext(4170, 109, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
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
            BeginContext(4283, 36, true);
            WriteLiteral("\r\n\r\n                                ");
            EndContext();
            BeginContext(4319, 343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5182377faa4878f6693c345aa5b9cc3e84a77b6d25078", async() => {
                BeginContext(4548, 110, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-plus ml-2\"></i> بخش ها\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                     WriteLiteral(course.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4662, 70, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 128 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                    }

#line default
#line hidden
#line 128 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(4774, 42, true);
            WriteLiteral("            </table>\r\n        </div>\r\n\r\n\r\n");
            EndContext();
#line 134 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
         if (Model.CourseVM.PageCount > 1)
        {

#line default
#line hidden
            BeginContext(4871, 184, true);
            WriteLiteral("            <!-- pagination -->\r\n            <nav aria-label=\"Page navigation\" class=\"my-3\">\r\n                <ul class=\"pagination pagination-circle pg-dark justify-content-center\">\r\n");
            EndContext();
#line 139 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                     for (int i = 1; i <= Model.CourseVM.PageCount; i++)
                    {

#line default
#line hidden
            BeginContext(5152, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5179, "\"", 5262, 3);
            WriteAttributeValue("", 5187, "page-item", 5187, 9, true);
            WriteAttributeValue(" ", 5196, "english-font", 5197, 13, true);
#line 141 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
WriteAttributeValue(" ", 5209, (Model.CourseVM.CurrentPage == i) ? "active" : "", 5210, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5263, 33, true);
            WriteLiteral(">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5296, "\"", 5327, 2);
            WriteAttributeValue("", 5303, "/Admin/Courses?pageId=", 5303, 22, true);
#line 142 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
WriteAttributeValue("", 5325, i, 5325, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5328, 19, true);
            WriteLiteral(" class=\"page-link\">");
            EndContext();
            BeginContext(5348, 1, false);
#line 142 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(5349, 37, true);
            WriteLiteral("</a>\r\n                        </li>\r\n");
            EndContext();
#line 144 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5409, 43, true);
            WriteLiteral("                </ul>\r\n            </nav>\r\n");
            EndContext();
#line 147 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5463, 12, true);
            WriteLiteral("\r\n    </div>");
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
