#pragma checksum "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ee8f9df394a17e7abd07c8970ae2e999760b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Shared_TEST), @"mvc.1.0.view", @"/Areas/Client/Views/Shared/TEST.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ee8f9df394a17e7abd07c8970ae2e999760b63", @"/Areas/Client/Views/Shared/TEST.cshtml")]
    public class Areas_Client_Views_Shared_TEST : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.ClientWeb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.CodClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.NumDocument));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.CivilSta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.Birthdat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.SfirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.SlastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.DeathDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.InpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.Person_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.SlegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.SclieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumDocument));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.CivilSta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.Birthdat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.SfirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.SlastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeathDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.InpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.Person_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.SlegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.SclieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3079, "\"", 3102, 1);
#nullable restore
#line 97 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
WriteAttributeValue("", 3094, item.Id, 3094, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3155, "\"", 3178, 1);
#nullable restore
#line 98 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
WriteAttributeValue("", 3170, item.Id, 3170, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3233, "\"", 3256, 1);
#nullable restore
#line 99 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
WriteAttributeValue("", 3248, item.Id, 3248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Usuario\source\repos\WebApplication2\Areas\Client\Views\Shared\TEST.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.ClientWeb>> Html { get; private set; }
    }
}
#pragma warning restore 1591
