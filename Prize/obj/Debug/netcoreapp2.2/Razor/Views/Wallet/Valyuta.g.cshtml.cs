#pragma checksum "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Wallet\Valyuta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84806cb1f2ca6446c002b638cc774cc012baa637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallet_Valyuta), @"mvc.1.0.view", @"/Views/Wallet/Valyuta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wallet/Valyuta.cshtml", typeof(AspNetCore.Views_Wallet_Valyuta))]
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
#line 1 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize;

#line default
#line hidden
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\_ViewImports.cshtml"
using Prize.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84806cb1f2ca6446c002b638cc774cc012baa637", @"/Views/Wallet/Valyuta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c9426c31ee4617d416847aaccd2722e64dd104", @"/Views/_ViewImports.cshtml")]
    public class Views_Wallet_Valyuta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Wallet\Valyuta.cshtml"
  
    ViewData["Title"] = "Valyuta";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 590, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-6 offset-3"" style=""font-size:18px;text-align:center"">
            <label class=""col-form-label"">Dollar</label>
            <input type=""number"" name="""" value="""" class=""form-control elprice"" onfocusout=""myFunction()"" />

            <label class=""col-form-label""> Elprice</label>

            <input type=""number"" name="""" value="""" class=""form-control dollar"" />


            <button type=""button"" class=""btn btn-success"" style=""margin:30px 0px 0 0px;"">Deyish</button>

        </div>
    </div>
</div>
");
            EndContext();
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
