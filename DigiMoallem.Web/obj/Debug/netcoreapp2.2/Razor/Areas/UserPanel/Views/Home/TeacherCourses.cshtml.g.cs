#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87074be866c75a746767131821c6361f3ad14dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Home_TeacherCourses), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Home/TeacherCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserPanel/Views/Home/TeacherCourses.cshtml", typeof(AspNetCore.Areas_UserPanel_Views_Home_TeacherCourses))]
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
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Helpers.Converters;

#line default
#line hidden
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.UserPanel;

#line default
#line hidden
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Transactions;

#line default
#line hidden
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Interfaces;

#line default
#line hidden
#line 7 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Admin.Courses;

#line default
#line hidden
#line 8 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Courses;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87074be866c75a746767131821c6361f3ad14dd", @"/Areas/UserPanel/Views/Home/TeacherCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a85b0e6a29d1913285eb1cfc8d59cce96508e14", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Home_TeacherCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:75px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "UserPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeacherShare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
  
    ViewData["Title"] = "لیست درسهای استاد";
    var userId = userService.GetUserIdByUserName(User.Identity.Name);

#line default
#line hidden
            BeginContext(230, 226, true);
            WriteLiteral("\r\n<div class=\"loader d-flex justify-content-center align-items-center\" style=\"display: block;\">\r\n    <i class=\"fa fa-circle-notch fa-3x text-white fa-spin\"></i>\r\n</div>\r\n\r\n<div class=\"container my-4\" style=\"display:none;\">\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(502, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(558, 19, false);
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(577, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
    }

#line default
#line hidden
            BeginContext(602, 219, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-12 col-md-8\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <i class=\"fa fa-chalkboard-teacher ml-1\"></i> ");
            EndContext();
            BeginContext(822, 17, false);
#line 28 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                                                 Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(839, 77, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n\r\n");
            EndContext();
#line 32 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                         if (Model.Courses.Any())
                        {

#line default
#line hidden
            BeginContext(994, 526, true);
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table table-bordered table-striped"">
                                    <tr>
                                        <th>شناسه درس</th>
                                        <th>تصویر درس</th>
                                        <th>عنوان درس</th>
                                        <th>سهم استاد</th>
                                        <th>جزئیات</th>
                                    </tr>
");
            EndContext();
#line 43 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                     foreach (var course in Model.Courses)
                                    {
                                        

#line default
#line hidden
#line 45 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                         if (course.TeacherId == userId ||
                                        permissionService.CheckPermission(2, User.Identity.Name))
                                        {

#line default
#line hidden
            BeginContext(1853, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(1956, 15, false);
#line 49 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                               Write(course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 113, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2084, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d87074be866c75a746767131821c6361f3ad14dd11683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2094, "~/images/courses/", 2094, 17, true);
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
AddHtmlAttributeValue("", 2111, course.ImageName, 2111, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
AddHtmlAttributeValue("", 2193, course.Title, 2193, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2309, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2473, 12, false);
#line 56 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                               Write(course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 109, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
            EndContext();
            BeginContext(2595, 21, false);
#line 58 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                               Write(course.TeacherPercent);

#line default
#line hidden
            EndContext();
            BeginContext(2616, 118, true);
            WriteLiteral(" درصد</td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2734, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d87074be866c75a746767131821c6361f3ad14dd15110", async() => {
                BeginContext(3101, 6, true);
                WriteLiteral("جزئیات");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
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
            BeginContext(3111, 108, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                        }

#line default
#line hidden
#line 67 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(3301, 82, true);
            WriteLiteral("                                    </table>\r\n                            </div>\r\n");
            EndContext();
#line 72 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                             if (Model.CurrentPage > 1)
                            {

#line default
#line hidden
            BeginContext(3473, 207, true);
            WriteLiteral("                                <div class=\"my-4\">\r\n                                    <!-- pagination -->\r\n                                    <ul class=\"pagination pagination-sm justify-content-center\">\r\n");
            EndContext();
#line 77 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                         for (int i = 1; i <= Model.PageCount; i++)
                                        {

#line default
#line hidden
            BeginContext(3808, 47, true);
            WriteLiteral("                                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3855, "\"", 3929, 3);
            WriteAttributeValue("", 3863, "page-item", 3863, 9, true);
            WriteAttributeValue(" ", 3872, "english-font", 3873, 13, true);
#line 79 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
WriteAttributeValue(" ", 3885, (Model.CurrentPage == i) ? "active" : "", 3886, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3930, 71, true);
            WriteLiteral(">\r\n                                                <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4001, "\"", 4045, 4);
            WriteAttributeValue("", 4008, "/TeacherCourses/", 4008, 16, true);
#line 80 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
WriteAttributeValue("", 4024, userId, 4024, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 4031, "?pageNumber=", 4031, 12, true);
#line 80 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
WriteAttributeValue("", 4043, i, 4043, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4046, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4048, 1, false);
#line 80 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4049, 57, true);
            WriteLiteral("</a>\r\n                                            </li>\r\n");
            EndContext();
#line 82 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4149, 83, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n");
            EndContext();
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                            }

#line default
#line hidden
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4347, 195, true);
            WriteLiteral("                            <div class=\"alert alert-warning\">\r\n                                <i class=\"fa fa-exclamation-triangle ml-1\"></i> درسی یافت نشد.\r\n                            </div>\r\n");
            EndContext();
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\TeacherCourses.cshtml"
                        }

#line default
#line hidden
            BeginContext(4569, 131, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        <div class=\"col-12 col-md-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(4700, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d87074be866c75a746767131821c6361f3ad14dd23177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4734, 46, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4798, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4804, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d87074be866c75a746767131821c6361f3ad14dd24672", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4840, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4845, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPermissionService permissionService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
