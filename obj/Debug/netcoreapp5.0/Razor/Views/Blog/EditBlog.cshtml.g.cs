#pragma checksum "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6570a9bd04c01b16f86d90eb515fa2c843803a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\_ViewImports.cshtml"
using NetCore5._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\_ViewImports.cshtml"
using NetCore5._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6570a9bd04c01b16f86d90eb515fa2c843803a9c", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b419fd3f438d1438c6a3e5321a025e6b9a86795", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrate.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditBlog</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog ThumImage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogCreateDate,  new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogStatus,  new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.WriterId,  new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 32 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 36 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrate.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591