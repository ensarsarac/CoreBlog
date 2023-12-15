#pragma checksum "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19c01c6457cdd25a77af5a5ee74f1157b845a373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19c01c6457cdd25a77af5a5ee74f1157b845a373", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazarın Blogları</h1>
<table class=""table table-bordered table-striped"">
        <tr>
            <th>id</th>
            <th>Blog Başlığı</th>
            <th>Oluşturma Tarihi</th>
            <th>Kategori</th>
            <th>Durum</th>
            <th>Sil</th>
            <th>Düzenle</th>
        </tr>
    <tbody>



");
#nullable restore
#line 24 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
              
                if (item.BlogStatus)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Aktif</td> \r\n");
#nullable restore
#line 35 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Pasif</td>\r\n");
#nullable restore
#line 39 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 984, "\"", 1020, 2);
            WriteAttributeValue("", 991, "/Blog/BlogRemove/", 991, 17, true);
#nullable restore
#line 41 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1008, item.BlogId, 1008, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1113, 2);
            WriteAttributeValue("", 1084, "/Blog/BlogUpdate/", 1084, 17, true);
#nullable restore
#line 42 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1101, item.BlogId, 1101, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"/Blog/BlogAdd\" class=\"btn btn-primary\">Yeni Blog Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591