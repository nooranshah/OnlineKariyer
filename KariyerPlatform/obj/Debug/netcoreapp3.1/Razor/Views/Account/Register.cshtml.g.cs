#pragma checksum "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d75eaf461e24286007bcbe0d4814200c8b911b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\_ViewImports.cshtml"
using KariyerPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\_ViewImports.cshtml"
using KariyerPlatform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d75eaf461e24286007bcbe0d4814200c8b911b7", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22045ca740e3d975c57a33d563d4a12f95ec23b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container text-light pt-5\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-sm-6\">\r\n                <h1>Kayıt Ol</h1>\r\n                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.Label(null, "Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.Label(null, "Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.UserName, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.Label(null, "Şifre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.Password, null, new { @class = " form-control", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.Label(null, "Şifre Tekrarı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.ConfirmPassword, null, new { @class = " form-control", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""form-group d-flex justify-content-end"">
                    <input type=""submit"" value=""Kaydol"" class=""btn btn-success"" />
                </div>
            </div>
        </div>        
    </div>
");
#nullable restore
#line 37 "C:\Users\Fatih\Desktop\Bootcamp\HW-Kariyer\KariyerPlatform\KariyerPlatform\Views\Account\Register.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
