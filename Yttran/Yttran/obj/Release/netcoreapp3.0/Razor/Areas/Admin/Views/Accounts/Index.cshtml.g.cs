#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a127d45e0bd659d4c1d135ae3636ec92982890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a127d45e0bd659d4c1d135ae3636ec92982890", @"/Areas/Admin/Views/Accounts/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Yttran.Models.Account>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Accounts</h1>\r\n\r\n<p>\r\n    <a href=\"/Admin/Accounts/Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UsrerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UsrerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.EditorFor(modelItem => item.Password, new { htmlAttributes = new { type = "password", disabled = "disabled" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1297, "\"", 1333, 2);
            WriteAttributeValue("", 1304, "/Admin/Accounts/Edit/", 1304, 21, true);
#nullable restore
#line 47 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
WriteAttributeValue("", 1325, item.Id, 1325, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1365, "\"", 1404, 2);
            WriteAttributeValue("", 1372, "/Admin/Accounts/Details/", 1372, 24, true);
#nullable restore
#line 48 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
WriteAttributeValue("", 1396, item.Id, 1396, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1477, 2);
            WriteAttributeValue("", 1446, "/Admin/Accounts/Delete/", 1446, 23, true);
#nullable restore
#line 49 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
WriteAttributeValue("", 1469, item.Id, 1469, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Yttran.Models.Account>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591