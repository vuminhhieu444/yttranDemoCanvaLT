#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\SlideLogoes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d8c913e26f48053b9ccc45a99e14e7a21f7806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SlideLogoes_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/SlideLogoes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d8c913e26f48053b9ccc45a99e14e7a21f7806", @"/Areas/Admin/Views/SlideLogoes/Create.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_SlideLogoes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yttran.Models.SlideLogo>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\SlideLogoes\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>SlideLogo</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form enctype=\"multipart/form-data\" asp-action=\"Create\" method=\"post\">\r\n            ");
#nullable restore
#line 15 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\SlideLogoes\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""SlideLogo.SlidePath"" class=""control-label"">Slide</label>
                <input asp-for=""SlideLogo.SlidePath"" type=""file"" name=""SlidePath"" class=""form-control"" />
                <span asp-validation-for=""SlideLogo.SlidePath"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SlideLogo.LogoPath""  class=""control-label"">Logo</label>
                <input asp-for=""SlideLogo.LogoPath"" type=""file"" name=""LogoPath"" class=""form-control"" />
                <span asp-validation-for=""SlideLogo.LogoPath"" class=""text-danger""></span>
            </div>
");
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a href=\"/Admin/SlideLogoes/Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yttran.Models.SlideLogo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591