#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e080fc3a40e2bd18f5f34397018cda0b2effd05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_Episodes), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/Episodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Courses/Episodes.cshtml", typeof(AspNetCore.Pages_Admin_Courses_Episodes), @"{id:min(1)}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e080fc3a40e2bd18f5f34397018cda0b2effd05", @"/Pages/Admin/Courses/Episodes.cshtml")]
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
            BeginContext(166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
  
    ViewData["Title"] = "لیست بخش ها";

#line default
#line hidden
            BeginContext(215, 95, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <h1 class=\"my-5\"> <i class=\"fa fa-database ml-2\"></i> ");
            EndContext();
            BeginContext(311, 17, false);
#line 12 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(328, 44, true);
            WriteLiteral("</h1>\r\n\r\n        <!-- create succeeded -->\r\n");
            EndContext();
#line 15 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(426, 63, true);
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                ");
            EndContext();
            BeginContext(490, 19, false);
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
           Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(509, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 20 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
        }

#line default
#line hidden
            BeginContext(542, 32, true);
            WriteLiteral("\r\n        <!-- add -->\r\n        ");
            EndContext();
            BeginContext(574, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e080fc3a40e2bd18f5f34397018cda0b2effd058106", async() => {
                BeginContext(711, 48, true);
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
#line 24 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
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
            BeginContext(763, 695, true);
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
#line 47 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                 if (Model.CourseEpisodes.Count == 0)
                {

#line default
#line hidden
            BeginContext(1532, 266, true);
            WriteLiteral(@"                    <tr class=""bg-dark text-light"">
                        <td colspan=""5"" class=""py-4"">
                            <i class=""fas fa-exclamation-triangle ml-2""></i> لیست بخش ها خالی است.
                        </td>
                    </tr>
");
            EndContext();
#line 54 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 57 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                     foreach (var episode in Model.CourseEpisodes)
                    {
                        

#line default
#line hidden
#line 59 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                         if (User.Identity.Name == _courseService.GetCourseById(episode.Course.CourseId).User.UserName ||
                           _permissionService.CheckPermission(2, User.Identity.Name))
                        {

#line default
#line hidden
            BeginContext(2186, 91, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(2278, 23, false);
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                    Write(episode.CourseEpisodeId);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2345, 13, false);
#line 64 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                               Write(episode.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2358, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2402, 21, false);
#line 65 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                               Write(episode.EpisodeLength);

#line default
#line hidden
            EndContext();
            BeginContext(2423, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 67 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                     if (episode.IsFree)
                                    {
                                        

#line default
#line hidden
            BeginContext(2611, 8, true);
            WriteLiteral(" رایگان ");
            EndContext();
#line 69 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                             
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
            BeginContext(2794, 6, true);
            WriteLiteral(" نقدی ");
            EndContext();
#line 73 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                                                           
                                    }

#line default
#line hidden
            BeginContext(2848, 133, true);
            WriteLiteral("                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(2981, 373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e080fc3a40e2bd18f5f34397018cda0b2effd0515485", async() => {
                BeginContext(3233, 117, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                                    ");
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
#line 79 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
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
            BeginContext(3354, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3392, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e080fc3a40e2bd18f5f34397018cda0b2effd0518282", async() => {
                BeginContext(3645, 120, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-trash-alt ml-2\"></i> حذف\r\n                                    ");
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
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
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
            BeginContext(3769, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 91 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                        }

#line default
#line hidden
#line 91 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                         
                    }

#line default
#line hidden
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Courses\Episodes.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(3914, 48, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPermissionService _permissionService { get; private set; }
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
