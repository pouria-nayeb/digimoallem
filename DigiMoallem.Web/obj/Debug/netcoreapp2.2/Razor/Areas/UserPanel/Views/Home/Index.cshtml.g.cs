#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7402de8dcc06585ebcfb8bb24079d7f2b612eb52"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7402de8dcc06585ebcfb8bb24079d7f2b612eb52", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bace68dcdcaaa9950572cdaafe944e450dabb8d5", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPanelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "پروفایل کاربری";

#line default
#line hidden
            BeginContext(125, 226, true);
            WriteLiteral("\r\n<div class=\"loader d-flex justify-content-center align-items-center\" style=\"display: block;\">\r\n    <i class=\"fa fa-circle-notch fa-3x text-white fa-spin\"></i>\r\n</div>\r\n\r\n<div class=\"container my-4\" style=\"display:none;\">\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(397, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(453, 19, false);
#line 17 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(472, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(497, 545, true);
            WriteLiteral(@"
    <div class=""row"">

        <div class=""col-12 col-md-8"">

            <div class=""card"">
                <div class=""card-header"">
                    <i class=""fa fa-user-secret ml-1""></i> اطلاعات پروفایل
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered table-striped"">
                            <tr>
                                <th>نام و نام خانوادگی</th>
                                <td>
");
            EndContext();
#line 35 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                     if (Model.FirstName == null)
                                    {

#line default
#line hidden
            BeginContext(1148, 61, true);
            WriteLiteral("                                        <span>نامشخض</span>\r\n");
            EndContext();
#line 38 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1329, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(1376, 15, false);
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1393, 14, false);
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 42 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1455, 218, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>نام کاربری</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(1674, 14, false);
#line 47 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                    Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 189, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>پست الکترونیک</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(1878, 11, false);
#line 51 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                    Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 185, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>تلفن تماس</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(2076, 67, false);
#line 55 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                     Write(Model.PhoneNumber != null ? Model.PhoneNumber.ToString() : "نامشخص");

#line default
#line hidden
            EndContext();
            BeginContext(2144, 173, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>موجودی حساب کاربری</th>\r\n                                <td>");
            EndContext();
            BeginContext(2318, 35, false);
#line 59 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                               Write(Model.Balance.ToString("#,0 تومان"));

#line default
#line hidden
            EndContext();
            BeginContext(2353, 189, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th>تاریخ ثبت نام</th>\r\n                                <td class=\"english-font\">");
            EndContext();
            BeginContext(2543, 34, false);
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                    Write(Model.RegisterDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(2577, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                             if (permissionService.CheckPermission(22, User.Identity.Name))
                            {
                                

#line default
#line hidden
#line 67 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.ScientificField))
                                {

#line default
#line hidden
            BeginContext(2862, 148, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>مدرک تحصیلی</th>\r\n                                        <td>");
            EndContext();
            BeginContext(3011, 21, false);
#line 71 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.ScientificField);

#line default
#line hidden
            EndContext();
            BeginContext(3032, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 73 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 74 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.EducationalLevel))
                                {

#line default
#line hidden
            BeginContext(3237, 148, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>مقطع تحصیلی</th>\r\n                                        <td>");
            EndContext();
            BeginContext(3386, 22, false);
#line 78 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.EducationalLevel);

#line default
#line hidden
            EndContext();
            BeginContext(3408, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 81 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.CardNumber))
                                {

#line default
#line hidden
            BeginContext(3607, 147, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>شماره کارت</th>\r\n                                        <td>");
            EndContext();
            BeginContext(3755, 16, false);
#line 85 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.CardNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3771, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 88 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.Sheba))
                                {

#line default
#line hidden
            BeginContext(3965, 146, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>شماره شبا</th>\r\n                                        <td>");
            EndContext();
            BeginContext(4112, 11, false);
#line 92 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.Sheba);

#line default
#line hidden
            EndContext();
            BeginContext(4123, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 94 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 95 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.Description))
                                {

#line default
#line hidden
            BeginContext(4323, 144, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>توضیحات</th>\r\n                                        <td>");
            EndContext();
            BeginContext(4468, 17, false);
#line 99 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4485, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 101 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 102 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (Model.Skills != null)
                                {

#line default
#line hidden
            BeginContext(4665, 220, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>مهارت ها</th>\r\n                                        <td>\r\n                                            <ul class=\"list-group p-0\">\r\n");
            EndContext();
#line 108 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                 foreach (var skill in Model.Skills.Split("-"))
                                                {

#line default
#line hidden
            BeginContext(5033, 80, true);
            WriteLiteral("                                                    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(5114, 5, false);
#line 110 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                           Write(skill);

#line default
#line hidden
            EndContext();
            BeginContext(5119, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 111 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5177, 141, true);
            WriteLiteral("                                            </ul>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 115 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 116 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 if (Model.Experiences != null)
                                {

#line default
#line hidden
            BeginContext(5453, 222, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>سوابق کاری</th>\r\n                                        <td>\r\n                                            <ul class=\"list-group p-0\">\r\n");
            EndContext();
#line 122 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                 foreach (var experience in Model.Experiences.Split("-"))
                                                {

#line default
#line hidden
            BeginContext(5833, 80, true);
            WriteLiteral("                                                    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(5914, 10, false);
#line 124 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                                           Write(experience);

#line default
#line hidden
            EndContext();
            BeginContext(5924, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 125 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5982, 141, true);
            WriteLiteral("                                            </ul>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 129 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#line 129 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Areas\UserPanel\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(6189, 179, true);
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-12 col-md-4\">\r\n\r\n            ");
            EndContext();
            BeginContext(6368, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7402de8dcc06585ebcfb8bb24079d7f2b612eb5222056", async() => {
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
            BeginContext(6402, 46, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6466, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6472, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7402de8dcc06585ebcfb8bb24079d7f2b612eb5223551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6508, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(6513, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
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
