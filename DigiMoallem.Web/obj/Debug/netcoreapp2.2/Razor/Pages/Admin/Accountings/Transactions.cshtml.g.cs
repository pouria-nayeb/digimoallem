#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711f2277b6e0b6607210449a6941cd3b99bc3583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Accountings_Transactions), @"mvc.1.0.razor-page", @"/Pages/Admin/Accountings/Transactions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Accountings/Transactions.cshtml", typeof(AspNetCore.Pages_Admin_Accountings_Transactions), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711f2277b6e0b6607210449a6941cd3b99bc3583", @"/Pages/Admin/Accountings/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Accountings_Transactions : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Charge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Accountings/EditCharge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
  
    ViewData["Title"] = "لیست تراکنش ها";

#line default
#line hidden
            BeginContext(125, 87, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"my-5\"> <i class=\"fa fa-database ml-2\"></i> ");
            EndContext();
            BeginContext(213, 17, false);
#line 10 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(230, 40, true);
            WriteLiteral("</h1>\r\n\r\n    <!-- create succeeded -->\r\n");
            EndContext();
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
            BeginContext(316, 55, true);
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(372, 19, false);
#line 16 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
       Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(391, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
    }

#line default
#line hidden
            BeginContext(416, 65, true);
            WriteLiteral("\r\n    <div class=\"my-3 clearfix\">\r\n        <!-- add -->\r\n        ");
            EndContext();
            BeginContext(481, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "711f2277b6e0b6607210449a6941cd3b99bc35837383", async() => {
                BeginContext(582, 82, true);
                WriteLiteral("\r\n            <i class=\"fa fa-plus ml-1\"></i> شارژ حساب کاربر توسط ادمین\r\n        ");
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
            BeginContext(668, 114, true);
            WriteLiteral("\r\n\r\n        <button class=\"btn btn-primary float-left english-font\">\r\n            <i class=\"fa fa-list ml-1\"></i> ");
            EndContext();
            BeginContext(783, 23, false);
#line 29 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                       Write(Model.TransactionsCount);

#line default
#line hidden
            EndContext();
            BeginContext(806, 35, true);
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n\r\n");
            EndContext();
#line 33 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
     if (Model.TransactionPagingVM.PageCount > 1)
    {

#line default
#line hidden
            BeginContext(899, 172, true);
            WriteLiteral("        <!-- pagination -->\r\n        <nav aria-label=\"Page navigation\" class=\"my-3\">\r\n            <ul class=\"pagination pagination-circle pg-dark justify-content-center\">\r\n");
            EndContext();
#line 38 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                 for (int i = 1; i <= Model.TransactionPagingVM.PageCount; i++)
                {

#line default
#line hidden
            BeginContext(1171, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1194, "\"", 1287, 3);
            WriteAttributeValue("", 1202, "page-item", 1202, 9, true);
            WriteAttributeValue(" ", 1211, "english-font", 1212, 13, true);
#line 40 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
WriteAttributeValue(" ", 1224, (Model.TransactionPagingVM.PageNumber == i) ? "active" : "", 1225, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1288, 29, true);
            WriteLiteral(">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1317, "\"", 1369, 2);
            WriteAttributeValue("", 1324, "/Admin/Accountings/Transactions?pageNumber=", 1324, 43, true);
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
WriteAttributeValue("", 1367, i, 1367, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1370, 19, true);
            WriteLiteral(" class=\"page-link\">");
            EndContext();
            BeginContext(1390, 1, false);
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 43 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                }

#line default
#line hidden
            BeginContext(1443, 35, true);
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
            EndContext();
#line 46 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
    }

#line default
#line hidden
            BeginContext(1485, 789, true);
            WriteLiteral(@"
    <!-- transactions table -->
    <div class=""table-responsive"">
        <table class=""table table-striped table-bordered"">
            <tr>
                <th class=""th-sm"">
                    شناسه
                </th>
                <th class=""th-sm"">
                    پست الکترونیک
                </th>
                <th class=""th-sm"">
                    توضیحات
                </th>
                <th class=""th-sm"">
                    میزان واریزی
                </th>
                <th class=""th-sm"">
                    وضعیت
                </th>
                <th class=""th-sm"">
                    تاریخ
                </th>
                <th class=""th-sm"">
                    دستورات
                </th>
            </tr>
");
            EndContext();
#line 74 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
             if (Model.TransactionPagingVM.Exchanges.Count == 0)
            {

#line default
#line hidden
            BeginContext(2355, 249, true);
            WriteLiteral("                <tr class=\"bg-dark text-light\">\r\n                    <td colspan=\"7\" class=\"py-4\">\r\n                        <i class=\"fas fa-exclamation-triangle ml-2\"></i> لیست تراکنش ها خالی است.\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 84 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                 foreach (var transaction in Model.TransactionPagingVM.Exchanges)
                {

#line default
#line hidden
            BeginContext(2754, 75, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(2830, 22, false);
#line 87 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                            Write(transaction.ExchangeId);

#line default
#line hidden
            EndContext();
            BeginContext(2852, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(2909, 22, false);
#line 88 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                            Write(transaction.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2931, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2967, 23, false);
#line 89 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                       Write(transaction.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2990, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 91 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                             if (transaction.IsPay)
                            {

#line default
#line hidden
            BeginContext(3111, 79, true);
            WriteLiteral("                                <span class=\"badge badge-success\">موفق</span>\r\n");
            EndContext();
#line 94 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3286, 80, true);
            WriteLiteral("                                <span class=\"badge badge-danger\">ناموفق</span>\r\n");
            EndContext();
#line 98 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                            }

#line default
#line hidden
            BeginContext(3397, 59, true);
            WriteLiteral("                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(3457, 40, false);
#line 100 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                       Write(transaction.Amount.ThreeDigitSeperator());

#line default
#line hidden
            EndContext();
            BeginContext(3497, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"english-font\">");
            EndContext();
            BeginContext(3554, 43, false);
#line 101 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                            Write(transaction.TransactionDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(3597, 87, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n\r\n                            ");
            EndContext();
            BeginContext(3684, 335, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "711f2277b6e0b6607210449a6941cd3b99bc358318162", async() => {
                BeginContext(3914, 101, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-pen ml-2\"></i> ویرایش\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                 WriteLiteral(transaction.ExchangeId);

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
            BeginContext(4019, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                }

#line default
#line hidden
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4113, 32, true);
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
            EndContext();
#line 117 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
     if (Model.TransactionPagingVM.PageCount > 1)
    {

#line default
#line hidden
            BeginContext(4203, 172, true);
            WriteLiteral("        <!-- pagination -->\r\n        <nav aria-label=\"Page navigation\" class=\"my-3\">\r\n            <ul class=\"pagination pagination-circle pg-dark justify-content-center\">\r\n");
            EndContext();
#line 122 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                 for (int i = 1; i <= Model.TransactionPagingVM.PageCount; i++)
                {

#line default
#line hidden
            BeginContext(4475, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4498, "\"", 4591, 3);
            WriteAttributeValue("", 4506, "page-item", 4506, 9, true);
            WriteAttributeValue(" ", 4515, "english-font", 4516, 13, true);
#line 124 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
WriteAttributeValue(" ", 4528, (Model.TransactionPagingVM.PageNumber == i) ? "active" : "", 4529, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4592, 29, true);
            WriteLiteral(">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4621, "\"", 4673, 2);
            WriteAttributeValue("", 4628, "/Admin/Accountings/Transactions?pageNumber=", 4628, 43, true);
#line 125 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
WriteAttributeValue("", 4671, i, 4671, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4674, 19, true);
            WriteLiteral(" class=\"page-link\">");
            EndContext();
            BeginContext(4694, 1, false);
#line 125 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4695, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 127 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
                }

#line default
#line hidden
            BeginContext(4747, 35, true);
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
            EndContext();
#line 130 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Accountings\Transactions.cshtml"
    }

#line default
#line hidden
            BeginContext(4789, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Accountings.TransactionsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Accountings.TransactionsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Accountings.TransactionsModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Accountings.TransactionsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
