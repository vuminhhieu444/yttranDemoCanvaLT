#pragma checksum "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025faed1f777b1160f82d3ffd9a71a91fea3120a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ServiceDetails_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ServiceDetails/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025faed1f777b1160f82d3ffd9a71a91fea3120a", @"/Areas/Admin/Views/ServiceDetails/Details.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ServiceDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yttran.Models.ServiceDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ServiceDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Menu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Menu.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 664, "\"", 707, 2);
            WriteAttributeValue("", 671, "/Admin/ServiceDetails/Edit/", 671, 27, true);
#nullable restore
#line 29 "F:\Code C Sharp\Project\Yttran\Yttran\Areas\Admin\Views\ServiceDetails\Details.cshtml"
WriteAttributeValue("", 698, Model.Id, 698, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a href=\"/Admin/ServiceDetails/Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yttran.Models.ServiceDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
