#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c017e203d186fd6359189fbb60c91f9fef6f451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Users/Index.cshtml", typeof(AspNetCore.Pages_Admin_Users_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c017e203d186fd6359189fbb60c91f9fef6f451", @"/Pages/Admin/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success float-right ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Users/Teachers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info float-right ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Users/DeletedUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Users/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Users/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
  
    ViewData["Title"] = "لیست کاربران";

#line default
#line hidden
            BeginContext(110, 105, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <h1 class=\"my-5\"> <i class=\"fa fa-users text-success ml-2\"></i> ");
            EndContext();
            BeginContext(216, 17, false);
#line 10 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(233, 44, true);
            WriteLiteral("</h1>\r\n\r\n        <!-- create succeeded -->\r\n");
            EndContext();
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(331, 63, true);
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                ");
            EndContext();
            BeginContext(395, 19, false);
#line 16 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
           Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(414, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(447, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(457, 1297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f4519921", async() => {
                BeginContext(482, 1265, true);
                WriteLiteral(@"

            <div class=""row p-3"">

                <!-- userName -->
                <div class=""col-12 col-sm-12 col-md-4"">
                    <div class=""form-group"">
                        <input type=""text"" id=""username"" name=""filterUserName""
                               class=""form-control english-font text-direction-ltr text-left"">
                        <label for=""username"">نام کاربری</label>
                    </div>
                </div>

                <!-- email -->
                <div class=""col-12 col-sm-12 col-md-4"">
                    <div class=""form-group"">
                        <input type=""text"" id=""email"" name=""filterEmail""
                               class=""form-control english-font text-direction-ltr text-left"">
                        <label for=""email"">آدرس ایمیل</label>
                    </div>
                </div>

                <!-- search -->
                <div class=""col-12 col-sm-12 col-md-4"">
                    <button class=""bt");
                WriteLiteral("n btn-primary\"> <i class=\"fa fa-search ml-2\"></i> جستجو</button>\r\n                    <a href=\"/Admin/Users\" class=\"btn btn-secondary\"> <i class=\"fa fa-filter ml-2\"></i> حذف فیلترها</a>\r\n                </div>\r\n\r\n            </div>\r\n        ");
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
            BeginContext(1754, 78, true);
            WriteLiteral("\r\n\r\n        <div class=\"p-3 clearfix\">\r\n            <!-- add -->\r\n            ");
            EndContext();
            BeginContext(1832, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f45112889", async() => {
                BeginContext(1946, 81, true);
                WriteLiteral("\r\n                <i class=\"fa fa-plus ml-2\"></i> افزودن کاربر جدید\r\n            ");
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
            BeginContext(2031, 45, true);
            WriteLiteral("\r\n            <!-- teachers -->\r\n            ");
            EndContext();
            BeginContext(2076, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f45114672", async() => {
                BeginContext(2202, 89, true);
                WriteLiteral("\r\n                <i class=\"fa fa-chalkboard-teacher ml-2\"></i> لیست اساتید\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 50, true);
            WriteLiteral("\r\n            <!-- deleted users -->\r\n            ");
            EndContext();
            BeginContext(2345, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f45116468", async() => {
                BeginContext(2472, 80, true);
                WriteLiteral("\r\n                <i class=\"fa fa-users ml-2\"></i> کاربران حذف شده\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2556, 122, true);
            WriteLiteral("\r\n\r\n            <button class=\"btn btn-primary float-left english-font\">\r\n                <i class=\"fa fa-list ml-1\"></i> ");
            EndContext();
            BeginContext(2679, 16, false);
#line 72 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                           Write(Model.UsersCount);

#line default
#line hidden
            EndContext();
            BeginContext(2695, 738, true);
            WriteLiteral(@"
            </button>
        </div>

        <!-- users table -->
        <div class=""table-responsive"">
            <table class=""table table-dark table-striped table-bordered"">
                <tr>
                    <th class=""th-sm"">
                        نام کاربری
                    </th>
                    <th class=""th-sm"">
                        ایمیل
                    </th>
                    <th class=""th-sm"">
                        وضعیت
                    </th>
                    <th class=""th-sm"">
                        تاریخ ثبت نام
                    </th>
                    <th class=""th-sm"">
                        دستورات
                    </th>
                </tr>
");
            EndContext();
#line 96 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                 if (Model.UserViewModel.Users.Count == 0)
                {

#line default
#line hidden
            BeginContext(3512, 267, true);
            WriteLiteral(@"                    <tr class=""bg-dark text-light"">
                        <td colspan=""5"" class=""py-4"">
                            <i class=""fas fa-exclamation-triangle ml-2""></i> لیست کاربران خالی است.
                        </td>
                    </tr>
");
            EndContext();
#line 103 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 106 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                     foreach (var user in Model.UserViewModel.Users)
                    {

#line default
#line hidden
            BeginContext(3932, 83, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(4016, 13, false);
#line 109 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                                Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4029, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(4090, 10, false);
#line 110 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                                Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4100, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                  
                                    var status = user.IsActive ? "فعال" : "غیر فعال";
                                    

#line default
#line hidden
            BeginContext(4307, 6, false);
#line 114 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                     Write(status);

#line default
#line hidden
            EndContext();
            BeginContext(4357, 88, true);
            WriteLiteral("                            </td>\r\n                            <td class=\"english-font\">");
            EndContext();
            BeginContext(4446, 33, false);
#line 117 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                                Write(user.RegisterDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(4479, 93, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(4572, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f45122757", async() => {
                BeginContext(4791, 109, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                     WriteLiteral(user.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4904, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4938, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c017e203d186fd6359189fbb60c91f9fef6f45125522", async() => {
                BeginContext(5158, 112, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-trash-alt ml-2\"></i> حذف\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 127 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                     WriteLiteral(user.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5274, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 133 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                    }

#line default
#line hidden
#line 133 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(5384, 40, true);
            WriteLiteral("            </table>\r\n        </div>\r\n\r\n");
            EndContext();
#line 138 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
         if (Model.UserViewModel.PageCount > 1)
        {

#line default
#line hidden
            BeginContext(5484, 184, true);
            WriteLiteral("            <!-- pagination -->\r\n            <nav aria-label=\"Page navigation\" class=\"my-3\">\r\n                <ul class=\"pagination pagination-circle pg-dark justify-content-center\">\r\n");
            EndContext();
#line 143 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                     for (int i = 1; i <= Model.UserViewModel.PageCount; i++)
                    {

#line default
#line hidden
            BeginContext(5770, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5797, "\"", 5885, 3);
            WriteAttributeValue("", 5805, "page-item", 5805, 9, true);
            WriteAttributeValue(" ", 5814, "english-font", 5815, 13, true);
#line 145 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue(" ", 5827, (Model.UserViewModel.CurrentPage == i) ? "active" : "", 5828, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5886, 33, true);
            WriteLiteral(">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5919, "\"", 5948, 2);
            WriteAttributeValue("", 5926, "/Admin/Users?pageId=", 5926, 20, true);
#line 146 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 5946, i, 5946, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5949, 19, true);
            WriteLiteral(" class=\"page-link\">");
            EndContext();
            BeginContext(5969, 1, false);
#line 146 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(5970, 37, true);
            WriteLiteral("</a>\r\n                        </li>\r\n");
            EndContext();
#line 148 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6030, 43, true);
            WriteLiteral("                </ul>\r\n            </nav>\r\n");
            EndContext();
#line 151 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6084, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Users.IndexModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
