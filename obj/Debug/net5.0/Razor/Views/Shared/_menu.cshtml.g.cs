#pragma checksum "G:\tuandung\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f28c79269e8efc9b7894fd7089b53a8a4ce0fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
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
#line 1 "G:\tuandung\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\tuandung\Views\_ViewImports.cshtml"
using ASP.Net_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f28c79269e8efc9b7894fd7089b53a8a4ce0fbf", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4249edee1c5401150d5a65e7fd6d65bf92b5a3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"menu_container container\">\r\n    <div class=\"menu_title\">\r\n        Quản lý sinh\r\n    </div>\r\n    <div class=\"menu_item\">\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (7,14)-(7,68) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Lớp học", "class_student", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (10,14)-(10,62) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Sinh viên", "index", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (13,14)-(13,69) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Lý lịch sinh viên", "info", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (16,14)-(16,61) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Môn học", "course", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (19,14)-(19,57) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Điểm", "point", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row item\">\r\n            ");
#nullable restore
#line (22,14)-(22,73) 6 "G:\tuandung\Views\Shared\_menu.cshtml"
Write(Html.ActionLink("Kết quả học tập", "edu_result", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
