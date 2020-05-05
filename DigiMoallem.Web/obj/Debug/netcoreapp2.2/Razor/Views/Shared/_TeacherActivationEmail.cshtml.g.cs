#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_TeacherActivationEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cdc689a4e5dd554d3a69945a6ae91c411b9eb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TeacherActivationEmail), @"mvc.1.0.view", @"/Views/Shared/_TeacherActivationEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TeacherActivationEmail.cshtml", typeof(AspNetCore.Views_Shared__TeacherActivationEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cdc689a4e5dd554d3a69945a6ae91c411b9eb6", @"/Views/Shared/_TeacherActivationEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f46ee54e3ec075b06ba192b910ab63bbfe2ccba", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TeacherActivationEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 289, true);
            WriteLiteral(@"
<div style=""direction:rtl; padding: 1.5rem; border:3px inset black;border-radius:5px;max-width: 450px; margin:0 auto;background-color: #444;color:white;"">
    <img src=""logo.png"" style=""display: block;margin: 0 auto; max-width:100%"" />
    <h2 style=""text-align: center;""> نام کاربری: ");
            EndContext();
            BeginContext(303, 14, false);
#line 5 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_TeacherActivationEmail.cshtml"
                                            Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(317, 279, true);
            WriteLiteral(@" </h2>
    <table style=""width:100%;max-width:350px;margin:16px auto;border:1px solid black;border-collapse: collapse;padding: 15px;text-align: center;"" border=""1"">
        <tr>
            <td style=""padding: 16px;"">پست الکترونیک</td>
            <td style=""padding: 16px;"">");
            EndContext();
            BeginContext(597, 11, false);
#line 9 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_TeacherActivationEmail.cshtml"
                                  Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(608, 129, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"padding: 16px;\">رمز عبور</td>\r\n            <td style=\"padding: 16px;\">");
            EndContext();
            BeginContext(738, 17, false);
#line 13 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_TeacherActivationEmail.cshtml"
                                  Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(755, 290, true);
            WriteLiteral(@"</td>
        </tr>
    </table>
    <p style=""text-align: center;"">
        با تشکر از ثبت نام شما استاد عزیز در سامانه دیجی معلم.
        <a href=""https://digimoallem.ir"" style=""display: block;color:#fff;padding: 8px 0;"">
            سایت دیجی معلم
        </a>

    </p>
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