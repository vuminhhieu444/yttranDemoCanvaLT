#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31153f44c283b9abcb1ef1914912fc48298d8082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31153f44c283b9abcb1ef1914912fc48298d8082", @"/Areas/Admin/Views/Accounts/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Accounts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yttran.Models.Account>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>Account</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form asp-action=\"Edit\" method=\"post\">\r\n            ");
#nullable restore
#line 15 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Account.Id"" />
            <div class=""form-group"">
                <label asp-for=""Account.UsrerName"" class=""control-label""> User name</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 588, "\"", 612, 1);
#nullable restore
#line 20 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Edit.cshtml"
WriteAttributeValue("", 596, Model.UsrerName, 596, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" asp-for=""Account.UsrerName"" name=""UsrerName"" class=""form-control"" />
                <span asp-validation-for=""Account.UsrerName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Account.Password"" class=""control-label"">Password</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 944, "\"", 967, 1);
#nullable restore
#line 25 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\Accounts\Edit.cshtml"
WriteAttributeValue("", 952, Model.Password, 952, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Account.Password\" name=\"Password\" class=\"form-control\" />\r\n                <span asp-validation-for=\"Account.Password\" class=\"text-danger\"></span>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a href=\"/Admin/Accounts/Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yttran.Models.Account> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
