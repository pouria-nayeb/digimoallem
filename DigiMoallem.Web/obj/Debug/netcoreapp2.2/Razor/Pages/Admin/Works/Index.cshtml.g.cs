#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Works_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Works/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Works/Index.cshtml", typeof(AspNetCore.Pages_Admin_Works_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a991174f58218506b5c4a73e1a0e5ae5ab5c6f7", @"/Pages/Admin/Works/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Works_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:85px;max-height:45px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
  
    ViewBag.Title = "درخواست های تدریس";

#line default
#line hidden
            BeginContext(111, 139, true);
            WriteLiteral("\r\n<section class=\"container\">\r\n\r\n    <h1 class=\"text-capitalize display-4 mb-5\">\r\n        <i class=\"fa fa-list-alt text-danger fa-fw\"></i> ");
            EndContext();
            BeginContext(251, 13, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                    Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(264, 19, true);
            WriteLiteral("\r\n    </h1>\r\n\r\n    ");
            EndContext();
            BeginContext(283, 905, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f77923", async() => {
                BeginContext(308, 873, true);
                WriteLiteral(@"

        <div class=""row p-3"">

            <!-- email -->
            <div class=""col-12 col-sm-12 col-md-4"">
                <div class=""form-group"">
                    <input type=""text"" id=""email"" name=""email""
                           class=""form-control english-font text-direction-ltr text-left"">
                    <label for=""username"">پست الکترونیک</label>
                </div>
            </div>

            <!-- search -->
            <div class=""col-12 col-sm-12 col-md-4"">
                <button class=""btn btn-primary""> <i class=""fa fa-search ml-2""></i> جستجو</button>
                <a href=""/Admin/Works"" class=""btn btn-secondary""> <i class=""fa fa-filter ml-2""></i> حذف فیلترها</a>
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
            BeginContext(1188, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(1238, 89, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <i class=\"fa fa-check fa-fw\"></i> ");
            EndContext();
            BeginContext(1328, 19, false);
#line 44 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                         Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 46 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1372, 163, true);
            WriteLiteral("\r\n    <div class=\"clearfix\">\r\n        <button type=\"button\" class=\"btn btn-primary float-left mb-3 english-font\">\r\n            <i class=\"fa fa-th-list fa-fw\"></i> ");
            EndContext();
            BeginContext(1536, 16, false);
#line 50 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                           Write(Model.WorksCount);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 35, true);
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
     if (Model.WorkPagingVM.Works.Any())
    {
        

#line default
#line hidden
#line 56 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
         foreach (Work work in Model.WorkPagingVM.Works)
        {


#line default
#line hidden
            BeginContext(1707, 222, true);
            WriteLiteral("            <div class=\"card border-primary mb-3\">\r\n                <header class=\"card-header clearfix\">\r\n                    تلفن تماس: <span class=\"text-light english-font d-inline-block mt-3\">\r\n                        ");
            EndContext();
            BeginContext(1930, 11, false);
#line 62 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                   Write(work.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1941, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.PhoneNumber != null)
                        {

#line default
#line hidden
            BeginContext(2026, 36, true);
            WriteLiteral("                            <span>- ");
            EndContext();
            BeginContext(2063, 16, false);
#line 65 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                               Write(work.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 66 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2115, 31, true);
            WriteLiteral("                    </span>\r\n\r\n");
            EndContext();
#line 69 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                     if (!string.IsNullOrEmpty(work.AvatarName))
                    {

#line default
#line hidden
            BeginContext(2235, 83, true);
            WriteLiteral("                        <div class=\"my-2 float-left\">\r\n                            ");
            EndContext();
            BeginContext(2318, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f714446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/avatars/");
#line 72 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                           WriteLiteral(work.AvatarName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 74 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2539, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 77 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2596, 92, true);
            WriteLiteral("                </header>\r\n\r\n                <div class=\"card-body\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2688, "\"", 2753, 2);
            WriteAttributeValue("", 2695, "/Admin/Users/Index?filterUserName=&filterEmail=", 2695, 47, true);
#line 81 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
WriteAttributeValue("", 2742, work.Email, 2742, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2754, 58, true);
            WriteLiteral(" \r\n                       class=\"text-light english-font\">");
            EndContext();
            BeginContext(2813, 10, false);
#line 82 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                  Write(work.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2823, 131, true);
            WriteLiteral("</a>\r\n\r\n                    <hr />\r\n\r\n                    <h5>مهارت ها</h5>\r\n                    <p class=\"card-text text-light\">\r\n");
            EndContext();
#line 88 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.Skills != null)
                        {
                            

#line default
#line hidden
            BeginContext(3061, 30, false);
#line 90 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                       Write(work.Skills.Replace("-", ", "));

#line default
#line hidden
            EndContext();
#line 90 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                           
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3177, 78, true);
            WriteLiteral("                            <span class=\"badge badge-danger\">درج نشده</span>\r\n");
            EndContext();
#line 95 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3282, 121, true);
            WriteLiteral("                    </p>\r\n                    <h5>سوابق کاری</h5>\r\n                    <p class=\"card-text text-light\">\r\n");
            EndContext();
#line 99 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.Experiences != null)
                        {
                            

#line default
#line hidden
            BeginContext(3515, 35, false);
#line 101 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                       Write(work.Experiences.Replace("-", ", "));

#line default
#line hidden
            EndContext();
#line 101 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                                
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3636, 78, true);
            WriteLiteral("                            <span class=\"badge badge-danger\">درج نشده</span>\r\n");
            EndContext();
#line 106 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3741, 127, true);
            WriteLiteral("                    </p>\r\n                    <h5>زمینه های همکاری</h5>\r\n                    <p class=\"card-text text-light\">\r\n");
            EndContext();
#line 110 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.ContributionFields != null)
                        {
                            

#line default
#line hidden
            BeginContext(3987, 42, false);
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                       Write(work.ContributionFields.Replace("-", ", "));

#line default
#line hidden
            EndContext();
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                                       
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4115, 78, true);
            WriteLiteral("                            <span class=\"badge badge-danger\">درج نشده</span>\r\n");
            EndContext();
#line 117 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4220, 258, true);
            WriteLiteral(@"                    </p>
                    <hr />

                    <div class=""clearfix"">

                        <span class=""my-2 float-left"">
                            تاریخ درج پیام:
                            <span class=""english-font"">");
            EndContext();
            BeginContext(4479, 31, false);
#line 125 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                  Write(work.SubmitDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(4510, 44, true);
            WriteLiteral("</span>\r\n                        </span>\r\n\r\n");
            EndContext();
#line 128 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.Gender)
                        {

#line default
#line hidden
            BeginContext(4624, 66, true);
            WriteLiteral("                            <span class=\"float-right\">آقا</span>\r\n");
            EndContext();
#line 131 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4774, 67, true);
            WriteLiteral("                            <span class=\"float-right\">خانم</span>\r\n");
            EndContext();
#line 135 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4868, 30, true);
            WriteLiteral("                    </div>\r\n\r\n");
            EndContext();
#line 138 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                     if (!string.IsNullOrEmpty(work.CvTitle))
                    {

#line default
#line hidden
            BeginContext(4984, 72, true);
            WriteLiteral("                        <div class=\"my-2\">\r\n                            ");
            EndContext();
            BeginContext(5056, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f724694", async() => {
                BeginContext(5122, 7, true);
                WriteLiteral(" رزومه ");
                EndContext();
                BeginContext(5131, 36, false);
#line 141 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                                                                 Write(work.FirstName + " " + work.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(5168, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5065, "~/cvs/", 5065, 6, true);
#line 141 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
AddHtmlAttributeValue("", 5071, work.CvTitle, 5071, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5173, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 143 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5230, 160, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <footer class=\"card-footer clearfix\">\r\n                    <span class=\"float-left small\">\r\n                        ");
            EndContext();
            BeginContext(5390, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f727422", async() => {
                BeginContext(5532, 97, true);
                WriteLiteral("\r\n                            <i class=\"fa fa-pen fa-fw\"></i> درج بررسی\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                             WriteLiteral(work.WorkId);

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
            BeginContext(5633, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(5661, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a991174f58218506b5c4a73e1a0e5ae5ab5c6f729962", async() => {
                BeginContext(5748, 97, true);
                WriteLiteral("\r\n                            <i class=\"fa fa-trash-alt fa-fw\"></i> حذف\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 155 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                               WriteLiteral(work.WorkId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5849, 84, true);
            WriteLiteral("\r\n                    </span>\r\n                    <span class=\"float-right mt-1\">\r\n");
            EndContext();
#line 160 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                         if (work.IsChecked)
                        {

#line default
#line hidden
            BeginContext(6006, 91, true);
            WriteLiteral("                            <span class=\"badge badge-success text-light\">بررسی شده</span>\r\n");
            EndContext();
#line 163 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6181, 96, true);
            WriteLiteral("                            <span class=\"badge badge-danger text-capitalize\">بررسی نشده</span>\r\n");
            EndContext();
#line 167 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6304, 76, true);
            WriteLiteral("                    </span>\r\n                </footer>\r\n            </div>\r\n");
            EndContext();
#line 171 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
        }

#line default
#line hidden
#line 171 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
            BeginContext(6415, 227, true);
            WriteLiteral("        <div class=\"alert alert-primary border border-warning\">\r\n            <p class=\"mb-0\">\r\n                <i class=\"fa fa-exclamation-triangle fa-fw mx-2\"></i> درخواست همکاری وجود ندارد.\r\n            </p>\r\n        </div>\r\n");
            EndContext();
#line 180 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(6649, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 182 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
     if (Model.WorkPagingVM.PageCount > 1)
    {

#line default
#line hidden
            BeginContext(6702, 89, true);
            WriteLiteral("        <nav>\r\n            <ul class=\"pagination pagination-sm justify-content-center\">\r\n");
            EndContext();
#line 186 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                 for (int i = 1; i <= Model.WorkPagingVM.PageCount; i++)
                {

#line default
#line hidden
            BeginContext(6884, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6907, "\"", 6978, 2);
            WriteAttributeValue("", 6915, "page-item", 6915, 9, true);
#line 188 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
WriteAttributeValue(" ", 6924, Model.WorkPagingVM.PageNumber == i ? "active" : "", 6925, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6979, 47, true);
            WriteLiteral(">\r\n                        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7026, "\"", 7059, 2);
            WriteAttributeValue("", 7033, "/Admin/Works?PageNumber=", 7033, 24, true);
#line 189 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
WriteAttributeValue("", 7057, i, 7057, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7060, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7062, 1, false);
#line 189 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7063, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 191 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(7115, 35, true);
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
            EndContext();
#line 194 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Works\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(7157, 12, true);
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Works.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Works.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Works.IndexModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Works.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
