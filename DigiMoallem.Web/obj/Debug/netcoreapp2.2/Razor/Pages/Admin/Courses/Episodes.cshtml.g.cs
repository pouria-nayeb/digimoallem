#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126fe936a5aa316b3b2f9667fa53e16247c831e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_Episodes), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/Episodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Courses/Episodes.cshtml", typeof(AspNetCore.Pages_Admin_Courses_Episodes), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126fe936a5aa316b3b2f9667fa53e16247c831e9", @"/Pages/Admin/Courses/Episodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_Episodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateEpisode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/EditEpisode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Courses/DeleteEpisode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
  
    ViewData["Title"] = "لیست بخش ها";

#line default
#line hidden
            BeginContext(161, 87, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"my-5\"> <i class=\"fa fa-database ml-2\"></i> ");
            EndContext();
            BeginContext(249, 17, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(266, 40, true);
            WriteLiteral("</h1>\r\n\r\n    <!-- create succeeded -->\r\n");
            EndContext();
#line 14 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(352, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(408, 19, false);
#line 17 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(427, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
    }

#line default
#line hidden
            BeginContext(452, 24, true);
            WriteLiteral("\r\n    <!-- add -->\r\n    ");
            EndContext();
            BeginContext(476, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126fe936a5aa316b3b2f9667fa53e16247c831e98040", async() => {
                BeginContext(589, 48, true);
                WriteLiteral(" <i class=\"fa fa-plus ml-2\"></i> افزودن بخش جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                  WriteLiteral(ViewData["CourseId"].ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(641, 615, true);
            WriteLiteral(@"

    <!-- users table -->
    <div class=""table-responsive"">
        <table class=""table table-dark table-striped table-bordered"">
            <tr>
                <th class=""th-sm"">
                    شناسه
                </th>
                <th class=""th-sm"">
                    عنوان بخش
                </th>
                <th class=""th-sm"">
                    زمان بخش
                </th>
                <th class=""th-sm"">
                    نوع بخش
                </th>
                <th class=""th-sm"">
                    دستورات
                </th>
            </tr>
");
            EndContext();
#line 44 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
             if (Model.CourseEpisodes.Count == 0)
            {

#line default
#line hidden
            BeginContext(1322, 246, true);
            WriteLiteral("                <tr class=\"bg-dark text-light\">\r\n                    <td colspan=\"5\" class=\"py-4\">\r\n                        <i class=\"fas fa-exclamation-triangle ml-2\"></i> لیست بخش ها خالی است.\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 54 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                 foreach (var episode in Model.CourseEpisodes)
                {
                    

#line default
#line hidden
#line 56 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                     if (User.Identity.Name == _courseService.GetCourseById(episode.Course.CourseId).User.UserName)
                    {

#line default
#line hidden
            BeginContext(1839, 83, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(1923, 23, false);
#line 59 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                Write(episode.CourseEpisodeId);

#line default
#line hidden
            EndContext();
            BeginContext(1946, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1986, 13, false);
#line 60 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                           Write(episode.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2039, 21, false);
#line 61 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                           Write(episode.EpisodeLength);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                 if (episode.IsFree)
                                {
                                    

#line default
#line hidden
            BeginContext(2232, 8, true);
            WriteLiteral(" رایگان ");
            EndContext();
#line 65 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                         
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(2399, 6, true);
            WriteLiteral(" نقدی ");
            EndContext();
#line 69 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                       
                                }

#line default
#line hidden
            BeginContext(2449, 121, true);
            WriteLiteral("                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(2570, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126fe936a5aa316b3b2f9667fa53e16247c831e915132", async() => {
                BeginContext(2810, 109, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                     WriteLiteral(episode.CourseEpisodeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2923, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2957, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126fe936a5aa316b3b2f9667fa53e16247c831e917913", async() => {
                BeginContext(3198, 108, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-trash ml-2\"></i> حذف\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                     WriteLiteral(episode.CourseEpisodeId);

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
            BeginContext(3310, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                    }

#line default
#line hidden
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                     
                }

#line default
#line hidden
#line 88 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3435, 36, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Courses.EpisodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.EpisodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Courses.EpisodesModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Courses.EpisodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
