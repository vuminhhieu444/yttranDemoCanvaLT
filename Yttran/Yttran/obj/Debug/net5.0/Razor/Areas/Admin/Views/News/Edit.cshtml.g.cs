#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\News\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f544fa8ce3536909cb6d1255a37ef0f629c01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f544fa8ce3536909cb6d1255a37ef0f629c01b", @"/Areas/Admin/Views/News/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_News_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yttran.Models.News>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\News\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>News</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form asp-action=\"Edit\" method=\"post\">\r\n            ");
#nullable restore
#line 15 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\News\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""News.Id"" />
            <div class=""form-group"">
                <label asp-for=""News.Title"" class=""control-label"">Title</label>
                <input asp-for=""News.Title"" name=""Title"" class=""form-control"" />
                <span asp-validation-for=""News.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""News.AllContent"" class=""control-label"">AllContent</label>
");
            WriteLiteral(@"                <textarea asp-for=""News.AllContent"" name=""AllContent"" rows=""5"" cols=""80""></textarea>
                <script>
                    CKEDITOR.replace('AllContent');
                </script>
                <span asp-validation-for=""News.AllContent"" class=""text-danger""></span>
            </div>
");
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a href=\"/Admin/News/Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yttran.Models.News> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
