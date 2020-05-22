#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_UserLoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea29f4210f01887a500705bb486339f70477bd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLoggedIn), @"mvc.1.0.view", @"/Views/Shared/_UserLoggedIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_UserLoggedIn.cshtml", typeof(AspNetCore.Views_Shared__UserLoggedIn))]
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
#line 3 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Accounts;

#line default
#line hidden
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Courses;

#line default
#line hidden
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Courses;

#line default
#line hidden
#line 6 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Display;

#line default
#line hidden
#line 7 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.General;

#line default
#line hidden
#line 8 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Interfaces;

#line default
#line hidden
#line 9 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.Works;

#line default
#line hidden
#line 10 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.Helpers.Converters;

#line default
#line hidden
#line 11 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.DAL.Entities.Users;

#line default
#line hidden
#line 12 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\_ViewImports.cshtml"
using DigiMoallem.BLL.DTOs.UserPanel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea29f4210f01887a500705bb486339f70477bd9", @"/Views/Shared/_UserLoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fe694c4a9b53c5ef0debe01dfffe622713273d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserLoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 288, true);
            WriteLiteral(@"
<div style=""direction:rtl; padding: 1.5rem; border:3px inset black;border-radius:5px;max-width: 450px; margin:0 auto;background-color: #fff;color:#333;"">
    <img src=""logo.png"" style=""display: block;margin: 0 auto; max-width:100%"" />
    <h2 style=""text-align: center;""> نام کاربری: ");
            EndContext();
            BeginContext(302, 14, false);
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_UserLoggedIn.cshtml"
                                            Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(316, 291, true);
            WriteLiteral(@" </h2>
    <table style=""width:100%;max-width:350px;margin:16px auto;border:1px solid black;border-collapse: collapse;padding: 15px;text-align: center;color: coral"" border=""1"">
        <tr>
            <td style=""padding: 16px;"">پست الکترونیک</td>
            <td style=""padding: 16px;"">");
            EndContext();
            BeginContext(608, 11, false);
#line 9 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_UserLoggedIn.cshtml"
                                  Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(619, 131, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"padding: 16px;\">تاریخ ورود</td>\r\n            <td style=\"padding: 16px;\">");
            EndContext();
            BeginContext(751, 38, false);
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_UserLoggedIn.cshtml"
                                  Write(Model.UpdateDate.Value.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(789, 92, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n\r\n    <p>\r\n        کاربر گرامی شما آخرین مرتبه در تاریخ ");
            EndContext();
            BeginContext(882, 38, false);
#line 18 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_UserLoggedIn.cshtml"
                                        Write(Model.UpdateDate.Value.ToPersianDate());

#line default
#line hidden
            EndContext();
            BeginContext(920, 540, true);
            WriteLiteral(@" وارد سایت دیجی معلّم شدید در صورتی شخص مورد نظر شما نیستید رمز عبور خود را در اولین فرصت تغییر دهید.
    </p>

    <hr />

    <p style=""text-align: center;"">
        با تشکر از شما کاربر عزیز در سامانه دیجی معلم.
        <a href=""https://digimoallem.ir"" style=""display: block;color:#fff;padding: 8px 0;"">
            سایت دیجی معلم
        </a>
    </p>

    <img src=""https://digimoallem.ir/images/resources/logo.png""
         alt=""لوگو دیجی معلّم""
         style=""display:block;margin:16px auto;max-width: 100%"" />
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591