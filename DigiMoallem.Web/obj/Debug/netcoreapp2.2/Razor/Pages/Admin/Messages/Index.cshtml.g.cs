#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c649a10de8d26070e8ad771e4719e3cec31016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Messages_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Messages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Messages/Index.cshtml", typeof(AspNetCore.Pages_Admin_Messages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c649a10de8d26070e8ad771e4719e3cec31016", @"/Pages/Admin/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff04463b118475a92e5ef86a2eed7d859befe99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Messages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
  
    ViewBag.Title = "لیست پیام";

#line default
#line hidden
            BeginContext(106, 157, true);
            WriteLiteral("\r\n    <section class=\"container\">\r\n\r\n        <h1 class=\"text-capitalize display-4 mb-5\">\r\n            <i class=\"fa fa-envelope-open text-warning fa-fw\"></i> ");
            EndContext();
            BeginContext(264, 13, false);
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                              Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(277, 27, true);
            WriteLiteral("\r\n        </h1>\r\n\r\n        ");
            EndContext();
            BeginContext(304, 998, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c649a10de8d26070e8ad771e4719e3cec310166599", async() => {
                BeginContext(329, 966, true);
                WriteLiteral(@"

            <div class=""row p-3"">

                <!-- phoneNumber -->
                <div class=""col-12 col-sm-12 col-md-4"">
                    <div class=""form-group"">
                        <input type=""text"" id=""phoneNumber"" name=""phoneNumber""
                               class=""form-control english-font text-direction-ltr text-left"">
                        <label for=""username"">تلفن تماس</label>
                    </div>
                </div>

                <!-- search -->
                <div class=""col-12 col-sm-12 col-md-4"">
                    <button class=""btn btn-primary""> <i class=""fa fa-search ml-2""></i> جستجو</button>
                    <a href=""/Admin/Messages"" class=""btn btn-secondary""> <i class=""fa fa-filter ml-2""></i> حذف فیلترها</a>
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
            BeginContext(1302, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 41 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(1360, 97, true);
            WriteLiteral("            <div class=\"alert alert-success\">\r\n                <i class=\"fa fa-check fa-fw\"></i> ");
            EndContext();
            BeginContext(1458, 19, false);
#line 44 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                             Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(1477, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 46 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1510, 162, true);
            WriteLiteral("\r\n        <div class=\"clearfix\">\r\n            <button type=\"button\" class=\"btn btn-primary float-left mb-3\">\r\n                <i class=\"fa fa-th-list fa-fw\"></i> ");
            EndContext();
            BeginContext(1673, 19, false);
#line 50 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                               Write(Model.ContactsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1692, 43, true);
            WriteLiteral("\r\n            </button>\r\n        </div>\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
         if (Model.ContactPagingVM.Contacts.Any())
        {
            

#line default
#line hidden
#line 56 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
             foreach (Contact contact in Model.ContactPagingVM.Contacts)
            {


#line default
#line hidden
            BeginContext(1889, 140, true);
            WriteLiteral("                <div class=\"card border-primary mb-3\">\r\n                    <header class=\"card-header\">تلفن تماس: <span class=\"text-light\">");
            EndContext();
            BeginContext(2030, 19, false);
#line 60 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                                               Write(contact.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 121, true);
            WriteLiteral("</span></header>\r\n\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text text-light\">");
            EndContext();
            BeginContext(2171, 19, false);
#line 63 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                   Write(contact.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2190, 101, true);
            WriteLiteral("</p>\r\n\r\n                        <hr />\r\n\r\n                        <span class=\"my-2\">تاریخ درج پیام: ");
            EndContext();
            BeginContext(2292, 34, false);
#line 67 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                      Write(contact.SubmitDate.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(2326, 183, true);
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    <footer class=\"card-footer clearfix\">\r\n                        <span class=\"float-left small\">\r\n                            ");
            EndContext();
            BeginContext(2509, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c649a10de8d26070e8ad771e4719e3cec3101613106", async() => {
                BeginContext(2657, 102, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-pen fa-fw\"></i> ویرایش\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                 WriteLiteral(contact.ContactId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2763, 32, true);
            WriteLiteral("\r\n\r\n                            ");
            EndContext();
            BeginContext(2795, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c649a10de8d26070e8ad771e4719e3cec3101615668", async() => {
                BeginContext(2880, 105, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-trash-alt fa-fw\"></i> حذف\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                   WriteLiteral(contact.ContactId);

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
            BeginContext(2989, 92, true);
            WriteLiteral("\r\n                        </span>\r\n                        <span class=\"float-right mt-1\">\r\n");
            EndContext();
#line 83 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                             if (contact.IsChecked)
                            {

#line default
#line hidden
            BeginContext(3165, 95, true);
            WriteLiteral("                                <span class=\"badge badge-success text-light\">بررسی شده</span>\r\n");
            EndContext();
#line 86 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3356, 100, true);
            WriteLiteral("                                <span class=\"badge badge-danger text-capitalize\">بررسی نشده</span>\r\n");
            EndContext();
#line 90 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3487, 88, true);
            WriteLiteral("                        </span>\r\n                    </footer>\r\n                </div>\r\n");
            EndContext();
#line 94 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
            }

#line default
#line hidden
#line 94 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(3626, 238, true);
            WriteLiteral("            <div class=\"alert alert-primary border border-warning\">\r\n                <p class=\"mb-0\">\r\n                    <i class=\"fa fa-exclamation-triangle fa-fw mx-2\"></i> پیامی وجود ندارد.\r\n                </p>\r\n            </div>\r\n");
            EndContext();
#line 103 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3875, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
         if (Model.ContactPagingVM.PageCount > 1)
        {

#line default
#line hidden
            BeginContext(3939, 97, true);
            WriteLiteral("            <nav>\r\n                <ul class=\"pagination pagination-sm justify-content-center\">\r\n");
            EndContext();
#line 109 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                     for (int i = 1; i <= Model.ContactPagingVM.PageCount; i++)
                    {

#line default
#line hidden
            BeginContext(4140, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4167, "\"", 4241, 2);
            WriteAttributeValue("", 4175, "page-item", 4175, 9, true);
#line 111 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
WriteAttributeValue(" ", 4184, Model.ContactPagingVM.PageNumber == i ? "active" : "", 4185, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4242, 51, true);
            WriteLiteral(">\r\n                            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4293, "\"", 4329, 2);
            WriteAttributeValue("", 4300, "/Admin/Messages?PageNumber=", 4300, 27, true);
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
WriteAttributeValue("", 4327, i, 4327, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4330, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4332, 1, false);
#line 112 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                                                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4333, 37, true);
            WriteLiteral("</a>\r\n                        </li>\r\n");
            EndContext();
#line 114 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4393, 43, true);
            WriteLiteral("                </ul>\r\n            </nav>\r\n");
            EndContext();
#line 117 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Pages\Admin\Messages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4447, 20, true);
            WriteLiteral("\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMoallem.Web.Pages.Admin.Messages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Messages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DigiMoallem.Web.Pages.Admin.Messages.IndexModel>)PageContext?.ViewData;
        public DigiMoallem.Web.Pages.Admin.Messages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
