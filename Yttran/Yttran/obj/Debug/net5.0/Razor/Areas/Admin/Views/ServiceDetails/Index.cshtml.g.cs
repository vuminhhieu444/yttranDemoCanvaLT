#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83682419b4cbbd5534380aab1c0d9ae08b57d715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ServiceDetails_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ServiceDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83682419b4cbbd5534380aab1c0d9ae08b57d715", @"/Areas/Admin/Views/ServiceDetails/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ServiceDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Yttran.Models.ServiceDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Service Details</h1>\r\n\r\n<p>\r\n    <a href=\"/Admin/ServiceDetails/Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 23 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 37 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MenuId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1005, "\"", 1047, 2);
            WriteAttributeValue("", 1012, "/Admin/ServiceDetails/Edit/", 1012, 27, true);
#nullable restore
#line 40 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
WriteAttributeValue("", 1039, item.Id, 1039, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1124, 2);
            WriteAttributeValue("", 1086, "/Admin/ServiceDetails/Details/", 1086, 30, true);
#nullable restore
#line 41 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
WriteAttributeValue("", 1116, item.Id, 1116, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1159, "\"", 1203, 2);
            WriteAttributeValue("", 1166, "/Admin/ServiceDetails/Delete/", 1166, 29, true);
#nullable restore
#line 42 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
WriteAttributeValue("", 1195, item.Id, 1195, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Yttran.Models.ServiceDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
