#pragma checksum "C:\Users\songül bayer\source\repos\NetCore5.0\Views\Comment\CommentListByBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0b58a77d4c9fd7571af594fb4c21e0837b9df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_CommentListByBlog), @"mvc.1.0.view", @"/Views/Comment/CommentListByBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc0b58a77d4c9fd7571af594fb4c21e0837b9df6", @"/Views/Comment/CommentListByBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b419fd3f438d1438c6a3e5321a025e6b9a86795", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_CommentListByBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrate.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"comment-top\">\r\n    <h4>Comments</h4>\r\n    <div class=\"media\">\r\n        <img src=\"images/t1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 157, "\"", 163, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" />
        <div class=""media-body"">
            <h5 class=""mt-0"">Joseph Goh</h5>
            <p>
                Lorem Ipsum convallis diam consequat magna vulputate malesuada. id dignissim sapien velit id felis ac cursus eros.
                Cras a ornare elit.
            </p>

            <div class=""media mt-3"">
                <a class=""d-flex pr-3"" href=""#"">
                    <img src=""images/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 605, "\"", 611, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" />
                </a>
                <div class=""media-body"">
                    <h5 class=""mt-0"">Richard Spark</h5>
                    <p>
                        Lorem Ipsum convallis diam consequat magna vulputate malesuada. id dignissim sapien velit id felis ac cursus eros.
                        Cras a ornare elit.
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrate.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591