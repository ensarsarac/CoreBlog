#pragma checksum "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f43099babb741ab87561dc39e7bfe8baf760dcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43099babb741ab87561dc39e7bfe8baf760dcb3", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container-scroller"">

        <div class=""page-header"">
            <h3 class=""page-title"">
                <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                    <i class=""mdi mdi-home""></i>
                </span> Dashboard
            </h3>

        </div>
        <div class=""row"">
            <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-danger card-img-holder text-white"">
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f43099babb741ab87561dc39e7bfe8baf760dcb35003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4 class=\"font-weight-normal mb-3\">\r\n                            Toplam Blog Sayısı <i class=\"mdi mdi-chart-line mdi-24px float-right\"></i>\r\n                        </h4>\r\n                        <h2 class=\"mb-5\">");
#nullable restore
#line 27 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                    Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <h6 class=""card-text"">Core 5.0</h6>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-info card-img-holder text-white"">
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f43099babb741ab87561dc39e7bfe8baf760dcb37043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4 class=\"font-weight-normal mb-3\">\r\n                            Sizin Blog Sayınız <i class=\"mdi mdi-bookmark-outline mdi-24px float-right\"></i>\r\n                        </h4>\r\n                        <h2 class=\"mb-5\">");
#nullable restore
#line 39 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                    Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <h6 class=""card-text"">Core 5.0</h6>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-success card-img-holder text-white"">
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f43099babb741ab87561dc39e7bfe8baf760dcb39092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4 class=\"font-weight-normal mb-3\">\r\n                            Toplam Kategori Sayısı <i class=\"mdi mdi-diamond mdi-24px float-right\"></i>\r\n                        </h4>\r\n                        <h2 class=\"mb-5\">");
#nullable restore
#line 51 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                    Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <h6 class=""card-text"">Core 5.0</h6>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-12 grid-margin"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Son 4 Blog</h4>
                        ");
#nullable restore
#line 63 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                   Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Yazar Hakkında</h4>

                        
                        ");
#nullable restore
#line 75 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                   Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Blog Durumları</h4>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <tr>
                                    <th> # </th>
                                    <th> Kategori Adı </th>
                                    <th> Blog Durum </th>
                                    <th> Blog Yorum <p class=""text-secondary my-auto"">100 yorum üzerinden değerlendirilir</p> </th>
                                </tr>
                                <tbody>
");
#nullable restore
#line 94 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                     foreach (var item in Model.blogList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td> ");
#nullable restore
#line 97 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                            Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 98 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                            Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n");
#nullable restore
#line 100 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                             if (item.BlogStatus)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Aktif</td>\r\n");
#nullable restore
#line 103 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Pasif</td>\r\n");
#nullable restore
#line 107 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\r\n\r\n");
#nullable restore
#line 110 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                                  
                                                    int sayac = 0;
                                                    foreach (var com in Model.commentList)
                                                    {
                                                        if (com.BlogId == item.BlogId)
                                                        {
                                                            sayac++;
                                                        }
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                \r\n                                                <div class=\"progress\">\r\n                                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 5840, "\"", 5863, 3);
            WriteAttributeValue("", 5848, "width:", 5848, 6, true);
#nullable restore
#line 122 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
WriteAttributeValue(" ", 5854, sayac, 5855, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5861, "%;", 5861, 2, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"25\" aria-valuemin=\"0\" aria-valuemax=\"100\">");
#nullable restore
#line 122 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                                                                                                                                                                        Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                </div>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 126 "D:\Belgeler\CoreApp\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardList> Html { get; private set; }
    }
}
#pragma warning restore 1591