#pragma checksum "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133092186cd030475cb65593d3d72cea4dae3afc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendMessages), @"mvc.1.0.view", @"/Views/Message/SendMessages.cshtml")]
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
#line 1 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133092186cd030475cb65593d3d72cea4dae3afc", @"/Views/Message/SendMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_SendMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
  
    ViewData["Title"] = "SendMessages";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gönderilen Mesajlar</h1>\r\n\r\n<table class=\"table table-bordered mt-3\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Kime</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Görüntüle</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
           Write(item.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
           Write(item.MessageSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 27 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
           Write(item.ReceiverUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
           Write(item.MessageDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 711, 2);
            WriteAttributeValue("", 672, "/Message/DeleteMessage2/", 672, 24, true);
#nullable restore
#line 29 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
WriteAttributeValue("", 696, item.MessageId, 696, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 822, 2);
            WriteAttributeValue("", 783, "/Message/MessageDetails/", 783, 24, true);
#nullable restore
#line 30 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"
WriteAttributeValue("", 807, item.MessageId, 807, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Görüntüle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Message\SendMessages.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Message/MessageAdd/\" class=\"btn btn-primary\">Mesaj Gönder</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
