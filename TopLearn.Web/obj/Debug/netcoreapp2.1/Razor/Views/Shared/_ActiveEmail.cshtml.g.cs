#pragma checksum "D:\Programming\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850f187b7f1afa7b576a85caa3e4233bb8dc7d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActiveEmail), @"mvc.1.0.view", @"/Views/Shared/_ActiveEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ActiveEmail.cshtml", typeof(AspNetCore.Views_Shared__ActiveEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850f187b7f1afa7b576a85caa3e4233bb8dc7d36", @"/Views/Shared/_ActiveEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActiveEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.Users.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 57, true);
            WriteLiteral("\r\n<div style=\"direction : rtl; padding : 20px\">\r\n    <h2>");
            EndContext();
            BeginContext(105, 14, false);
#line 4 "D:\Programming\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(119, 120, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>با تشکر از ثبت نام شما در تاپلرن.جهت ادامه کار می بایست حساب کاربری خود را فعال کنید</p>\r\n    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 239, "\"", 309, 2);
            WriteAttributeValue("", 246, "https://localhost:44333/Account/ActiveAccount/", 246, 46, true);
#line 6 "D:\Programming\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
WriteAttributeValue("", 292, Model.ActiveCode, 292, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 37, true);
            WriteLiteral(">فعالسازی حساب کاربری</a></p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.DataLayer.Entities.Users.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
