#pragma checksum "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fbadcbce7aede0fbe6990ba9a0f141751458447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
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
#line 1 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\_ViewImports.cshtml"
using WebProgramlama;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\_ViewImports.cshtml"
using WebProgramlama.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbadcbce7aede0fbe6990ba9a0f141751458447", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd35ac3d649362ce6b91da8d373992136127eda", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
  
    Layout = "~/Views/Shared/_AuthorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h2>Blog Listesi</h2>\n<br />\n<table class=\"table table-bordered\">\n    <tr>\n        <th>ID</th>\n        <th>Başlık</th>\n        <th>Tarih</th>\n");
            WriteLiteral("        <th>Güncelle</th>\n\n    </tr>\n");
#nullable restore
#line 20 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n            <td>");
#nullable restore
#line 26 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
           Write(item.BlogDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 645, 2);
            WriteAttributeValue("", 614, "/Author/UpdateBlog/", 614, 19, true);
#nullable restore
#line 28 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
WriteAttributeValue("", 633, item.BlogID, 633, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 32 "C:\Users\yagmu\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\Views\Author\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n<a href=\"/Author/AddNewBlog/\" class=\"btn btn-primary\">Yeni Blog Ekle</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
