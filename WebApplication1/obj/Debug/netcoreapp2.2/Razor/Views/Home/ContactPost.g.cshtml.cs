#pragma checksum "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01439c637c28af0df3604f5f0b41bbe01086194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactPost), @"mvc.1.0.view", @"/Views/Home/ContactPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactPost.cshtml", typeof(AspNetCore.Views_Home_ContactPost))]
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
#line 1 "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01439c637c28af0df3604f5f0b41bbe01086194", @"/Views/Home/ContactPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
  
    ViewData["Title"] = "ขอบคุณที่ใช้บริการของเรา";

#line default
#line hidden
            BeginContext(62, 60, true);
            WriteLiteral("\r\n<h1>ขอบคุณที่ใช้บริการของเรา</h1>\r\n<div>ทางเราขอขอบคุณคุณ ");
            EndContext();
            BeginContext(123, 16, false);
#line 7 "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
                  Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 59, true);
            WriteLiteral(" เมื่อเจ้าหน้าที่ีับเรื่องแล้วทางเราจะติดต่อกลับไปที่\r\n    ");
            EndContext();
            BeginContext(199, 17, false);
#line 8 "D:\งาน ณพดนัย\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(216, 16, true);
            WriteLiteral(" โดยด่วน</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
