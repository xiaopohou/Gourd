#pragma checksum "F:\core\Gourd\Gourd.IdentityService\Views\ApiSecrets\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9a994cbbf1bff212f0ff3ac3a23fd533765ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApiSecrets_Edit), @"mvc.1.0.view", @"/Views/ApiSecrets/Edit.cshtml")]
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
#line 1 "F:\core\Gourd\Gourd.IdentityService\Views\_ViewImports.cshtml"
using Gourd.IdentityService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\core\Gourd\Gourd.IdentityService\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\core\Gourd\Gourd.IdentityService\Views\_ViewImports.cshtml"
using IdentityServer4.EntityFramework.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\core\Gourd\Gourd.IdentityService\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9a994cbbf1bff212f0ff3ac3a23fd533765ec8", @"/Views/ApiSecrets/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc31a1b7195ca8f8b2b96888064d5d96f9c8862", @"/Views/_ViewImports.cshtml")]
    public class Views_ApiSecrets_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\core\Gourd\Gourd.IdentityService\Views\ApiSecrets\Edit.cshtml"
  
    ViewData["Title"] = "编辑";
    Layout = "/Views/Shared/_IFrame.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\core\Gourd\Gourd.IdentityService\Views\ApiSecrets\Edit.cshtml"
Write(Html.Partial("~/Views/ApiSecrets/_CreateOrEdit.cshtml"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591