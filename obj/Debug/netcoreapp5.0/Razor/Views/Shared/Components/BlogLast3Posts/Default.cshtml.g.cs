#pragma checksum "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc17ba68616851f2950e393f0d405e00b4975f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Posts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Posts/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc17ba68616851f2950e393f0d405e00b4975f8", @"/Views/Shared/Components/BlogLast3Posts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b419fd3f438d1438c6a3e5321a025e6b9a86795", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Posts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Latest Posts</h3>\r\n");
#nullable restore
#line 5 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 252, "\"", 289, 2);
            WriteAttributeValue("", 259, "/Blog/BlogReadAll/", 259, 18, true);
#nullable restore
#line 9 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 277, item.BlogId, 277, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 317, "\"", 338, 1);
#nullable restore
#line 10 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 323, item.BlogImage, 323, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 371, "\"", 377, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 564, 2);
            WriteAttributeValue("", 534, "/Blog/BlogReadAll/", 534, 18, true);
#nullable restore
#line 19 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 552, item.BlogId, 552, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n\r\n            </div>\r\n          \r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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