#pragma checksum "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a19dafd0b5c4f2f63fdbe43cecc49a340d9a83f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statictik2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statictik2/Default.cshtml")]
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
#line 1 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a19dafd0b5c4f2f63fdbe43cecc49a340d9a83f", @"/Areas/Admin/Views/Shared/Components/Statictik2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statictik2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"widget navy-bg no-padding\">\r\n            <div class=\"p-m\">\r\n                <h1");
            BeginWriteAttribute("class", " class=\"", 146, "\"", 154, 0);
            EndWriteAttribute();
            WriteLiteral(@">Dashboard</h1>

                <h3 class=""font-bold no-margins"">
                    Asp.Net Core 5.0
                </h3>
                <p>
                    Projemizin bu panelinde admin işlemleri bir area yapısı üzerinden gerçekleşmektedir. Sol tarafda yer alan side bar üzerinde ki yardım menüsüne ulaşıp takıldığınız noktalarla ilgili destek alabilirsiniz.
                </p>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Son Eklenen Blog</h1>
");
#nullable restore
#line 23 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
                 if (ViewBag.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3>");
#nullable restore
#line 25 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
                   Write(ViewBag.v1.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <small>");
#nullable restore
#line 26 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
                      Write(ViewBag.v1.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small> <br />\r\n                    <small>");
#nullable restore
#line 27 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
                      Write(ViewBag.v1.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 28 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>");
#nullable restore
#line 31 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
           Write(ViewBag.vNotBlog);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 32 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statictik2\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">$ 50,992</h1>

                <h3 class=""font-bold no-margins"">
                    Half-year revenue margin
                </h3>
                <small>Sales marketing.</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>");
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