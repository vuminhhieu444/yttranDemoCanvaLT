#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb211516e5ed894dcb9fed7bc057dc9956ea8876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Menus_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Menus/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb211516e5ed894dcb9fed7bc057dc9956ea8876", @"/Areas/Admin/Views/Menus/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Menus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Yttran.Models.Menu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Menu services</h1>\r\n\r\n<p>\r\n    <a href=\"/Admin/Menus/Create/\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1047, 2);
            WriteAttributeValue("", 1021, "/Admin/Menus/Edit/", 1021, 18, true);
#nullable restore
#line 41 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
WriteAttributeValue("", 1039, item.Id, 1039, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1115, 2);
            WriteAttributeValue("", 1086, "/Admin/Menus/Details/", 1086, 21, true);
#nullable restore
#line 42 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
WriteAttributeValue("", 1107, item.Id, 1107, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1185, 2);
            WriteAttributeValue("", 1157, "/Admin/Menus/Delete/", 1157, 20, true);
#nullable restore
#line 43 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
WriteAttributeValue("", 1177, item.Id, 1177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Menus\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Yttran.Models.Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
