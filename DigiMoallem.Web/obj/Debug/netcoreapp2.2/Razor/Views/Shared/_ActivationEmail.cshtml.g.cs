#pragma checksum "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_ActivationEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fed7e57177ebe5fcd3153255137b0e43a8e02231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActivationEmail), @"mvc.1.0.view", @"/Views/Shared/_ActivationEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ActivationEmail.cshtml", typeof(AspNetCore.Views_Shared__ActivationEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed7e57177ebe5fcd3153255137b0e43a8e02231", @"/Views/Shared/_ActivationEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae303af3b1ab63ab81fe330170c9bf6fbfbe3176", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActivationEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 179, true);
            WriteLiteral("\r\n<div style=\"direction:rtl; padding: 1.5rem; border:3px inset black;border-radius:5px;max-width: 450px; margin:0 auto;background-color: #444;color:white;\">\r\n    <h2> نام کاربری: ");
            EndContext();
            BeginContext(193, 14, false);
#line 4 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_ActivationEmail.cshtml"
                Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(207, 123, true);
            WriteLiteral(" </h2>\r\n    <p>\r\n        با تشکر از ثبت نام شما در سامانه دیجی معلم، جهت فعال سازی حساب کاربری خود کافی است روی\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 330, "\"", 403, 2);
            WriteAttributeValue("", 337, "https://digimoallem.ir/Account/ActiveAccount/", 337, 45, true);
#line 7 "C:\Users\Nayeb\source\repos\DigiMoallem\DigiMoallem.Web\Views\Shared\_ActivationEmail.cshtml"
WriteAttributeValue("", 382, Model.ActivationCode, 382, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 134, true);
            WriteLiteral("> این لینک</a>\r\n        کلیک کنید.\r\n    </p>\r\n    <img src=\"logo.png\" style=\"display: block;margin: 0 auto; max-width:100%\" />\r\n</div>");
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
