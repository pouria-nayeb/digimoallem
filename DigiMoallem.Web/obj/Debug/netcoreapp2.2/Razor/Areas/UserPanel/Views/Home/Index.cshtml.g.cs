#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "338809e1a0ba26fd2c1593a74340ff0285661ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Home_Index), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserPanel/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_UserPanel_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"338809e1a0ba26fd2c1593a74340ff0285661ce5", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a85b0e6a29d1913285eb1cfc8d59cce96508e14", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPanelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "UserPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "پروفایل کاربری";
    var userId = userService.GetUserIdByUserName(User.Identity.Name);

#line default
#line hidden
            BeginContext(268, 226, true);
            WriteLiteral("\r\n<div class=\"loader d-flex justify-content-center align-items-center\" style=\"display: block;\">\r\n    <i class=\"fa fa-circle-notch fa-3x text-white fa-spin\"></i>\r\n</div>\r\n\r\n<div class=\"container my-4\" style=\"display:none;\">\r\n\r\n");
            EndContext();
#line 17 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(540, 87, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <i class=\"fa fa-check ml-2\"></i>");
            EndContext();
            BeginContext(628, 19, false);
#line 20 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(647, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(672, 359, true);
            WriteLiteral(@"
    <div class=""row"">

        <div class=""col-12 col-md-8"">

            <div class=""card"">
                <div class=""card-header"">
                    <i class=""fa fa-user-secret ml-1""></i> اطلاعات پروفایل
                </div>
                <div class=""card-body"">

                    <div class=""clearfix my-3"">
                        ");
            EndContext();
            BeginContext(1031, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338809e1a0ba26fd2c1593a74340ff0285661ce58336", async() => {
                BeginContext(1168, 107, true);
                WriteLiteral("\r\n                            <i class=\"fa fa-user-edit ml-1\"></i> ویرایش اطلاعات\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(1279, 293, true);
            WriteLiteral(@"
                    </div>

                    <div class=""table-responsive"">
                        <table class=""table table-bordered table-striped"">
                            <tr>
                                <th>نام و نام خانوادگی</th>
                                <td>
");
            EndContext();
#line 46 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                     if (Model.FirstName == null)
                                    {

#line default
#line hidden
            BeginContext(1678, 61, true);
            WriteLiteral("                                        <span>نامشخض</span>\r\n");
            EndContext();
#line 49 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1859, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(1906, 15, false);
#line 52 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1921, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1923, 14, false);
#line 52 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 53 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1985, 218, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>نام کاربری</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(2204, 14, false);
#line 58 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                    Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2218, 189, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>پست الکترونیک</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(2408, 11, false);
#line 62 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                    Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2419, 164, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>تلفن تماس</th>\r\n                                <td>");
            EndContext();
            BeginContext(2585, 67, false);
#line 66 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                Write(Model.PhoneNumber != null ? Model.PhoneNumber.ToString() : "نامشخص");

#line default
#line hidden
            EndContext();
            BeginContext(2653, 173, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>موجودی حساب کاربری</th>\r\n                                <td>");
            EndContext();
            BeginContext(2827, 35, false);
#line 70 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                               Write(Model.Balance.ToString("#,0 تومان"));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 168, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>تاریخ ثبت نام</th>\r\n                                <td>");
            EndContext();
            BeginContext(3031, 34, false);
#line 74 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                               Write(Model.RegisterDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(3065, 176, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>گروه های علاقه مندی</th>\r\n                                <td>\r\n");
            EndContext();
#line 79 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                     if (userService.GetUserGroups(userId).Any())
                                    {

                                        

#line default
#line hidden
#line 82 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                         foreach (var groupId in userService.GetUserGroups(userId))
                                        {

#line default
#line hidden
            BeginContext(3509, 138, true);
            WriteLiteral("                                            <button class=\"btn btn-outline-info btn-sm\">\r\n                                                ");
            EndContext();
            BeginContext(3648, 41, false);
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                           Write(courseService.GetGroupById(groupId).Title);

#line default
#line hidden
            EndContext();
            BeginContext(3689, 57, true);
            WriteLiteral("\r\n                                            </button>\r\n");
            EndContext();
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                         

                                    }
                                    else
                                    {
                                        

#line default
#line hidden
            BeginContext(3957, 35, true);
            WriteLiteral("گروهی در لیست علایق شما وجود ندارد.");
            EndContext();
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                                        
                                    }

#line default
#line hidden
            BeginContext(4040, 201, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>آخرین ورود شما</th>\r\n                                <td>");
            EndContext();
            BeginContext(4242, 32, false);
#line 98 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                               Write(Model.UpdateDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(4274, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 100 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                             if (permissionService.CheckPermission(22, User.Identity.Name))
                            {
                                

#line default
#line hidden
#line 102 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.ScientificField))
                                {

#line default
#line hidden
            BeginContext(4559, 150, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>رشته دانشگاهی</th>\r\n                                        <td>");
            EndContext();
            BeginContext(4710, 21, false);
#line 106 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.ScientificField);

#line default
#line hidden
            EndContext();
            BeginContext(4731, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 108 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 109 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.EducationalLevel))
                                {

#line default
#line hidden
            BeginContext(4936, 148, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>مقطع تحصیلی</th>\r\n                                        <td>");
            EndContext();
            BeginContext(5085, 22, false);
#line 113 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.EducationalLevel);

#line default
#line hidden
            EndContext();
            BeginContext(5107, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 115 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 116 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.CardNumber))
                                {

#line default
#line hidden
            BeginContext(5306, 147, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>شماره کارت</th>\r\n                                        <td>");
            EndContext();
            BeginContext(5454, 16, false);
#line 120 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.CardNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5470, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 122 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 123 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.Sheba))
                                {

#line default
#line hidden
            BeginContext(5664, 146, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>شماره شبا</th>\r\n                                        <td>");
            EndContext();
            BeginContext(5811, 11, false);
#line 127 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.Sheba);

#line default
#line hidden
            EndContext();
            BeginContext(5822, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 129 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 130 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.Description))
                                {

#line default
#line hidden
            BeginContext(6022, 144, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>توضیحات</th>\r\n                                        <td>");
            EndContext();
            BeginContext(6167, 17, false);
#line 134 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(6184, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 136 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 137 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (Model.Skills != null)
                                {

#line default
#line hidden
            BeginContext(6364, 220, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>مهارت ها</th>\r\n                                        <td>\r\n                                            <ul class=\"list-group p-0\">\r\n");
            EndContext();
#line 143 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                 foreach (var skill in Model.Skills.Split("-"))
                                                {

#line default
#line hidden
            BeginContext(6732, 80, true);
            WriteLiteral("                                                    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(6813, 5, false);
#line 145 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                           Write(skill);

#line default
#line hidden
            EndContext();
            BeginContext(6818, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 146 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(6876, 141, true);
            WriteLiteral("                                            </ul>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 150 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 151 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (Model.Experiences != null)
                                {

#line default
#line hidden
            BeginContext(7152, 222, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>سوابق کاری</th>\r\n                                        <td>\r\n                                            <ul class=\"list-group p-0\">\r\n");
            EndContext();
#line 157 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                 foreach (var experience in Model.Experiences.Split("-"))
                                                {

#line default
#line hidden
            BeginContext(7532, 80, true);
            WriteLiteral("                                                    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(7613, 10, false);
#line 159 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                           Write(experience);

#line default
#line hidden
            EndContext();
            BeginContext(7623, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 160 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(7681, 141, true);
            WriteLiteral("                                            </ul>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 164 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 164 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(7888, 179, true);
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-12 col-md-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(8067, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "338809e1a0ba26fd2c1593a74340ff0285661ce529090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8101, 46, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8165, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8171, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338809e1a0ba26fd2c1593a74340ff0285661ce530585", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8207, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(8212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICourseService courseService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPermissionService permissionService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPanelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
