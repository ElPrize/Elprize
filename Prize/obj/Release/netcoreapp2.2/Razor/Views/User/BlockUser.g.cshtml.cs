#pragma checksum "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5042257be3600faf6560cdaa50bc435992376330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_BlockUser), @"mvc.1.0.view", @"/Views/User/BlockUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/BlockUser.cshtml", typeof(AspNetCore.Views_User_BlockUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5042257be3600faf6560cdaa50bc435992376330", @"/Views/User/BlockUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c9426c31ee4617d416847aaccd2722e64dd104", @"/Views/_ViewImports.cshtml")]
    public class Views_User_BlockUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prize.Models.UserTranViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 971, true);
            WriteLiteral(@"
<h1>All User</h1>

<table id=""table"" class=""table table-hover table-bordered "">
    <thead>
        <tr>
            <th>Firstame<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Lastname<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Username<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Cash<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Transaction count<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Transaction discount<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Acvited<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
            <th>Block<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>

        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 25 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
         if (Model != null)
        {

            

#line default
#line hidden
#line 28 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1210, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(1259, 19, false);
#line 32 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.Users.Firstame);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1310, 19, false);
#line 33 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.Users.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1361, 19, false);
#line 34 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.Users.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1412, 15, false);
#line 35 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.Users.Cash);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1459, 14, false);
#line 36 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.tranCount);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1505, 12, false);
#line 37 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                   Write(item.tranDis);

#line default
#line hidden
            EndContext();
            BeginContext(1517, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                     if (item.Users.Acvited)
                    {

#line default
#line hidden
            BeginContext(1593, 42, true);
            WriteLiteral("                        <td>Acvited</td>\r\n");
            EndContext();
#line 41 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1707, 40, true);
            WriteLiteral("                        <td>Block</td>\r\n");
            EndContext();
#line 45 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                    }

#line default
#line hidden
            BeginContext(1770, 75, true);
            WriteLiteral("\r\n                    <td><button class=\"btn btn-danger btnBlock\" data-id=\"");
            EndContext();
            BeginContext(1846, 13, false);
#line 47 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
                                                                    Write(item.Users.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1859, 48, true);
            WriteLiteral("\">Unblock</button></td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
            }

#line default
#line hidden
#line 49 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\User\BlockUser.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1933, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1978, 1629, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000
        });

        var table = $('#table').DataTable({

            ""order"": [[0, ""desc""]]
        });
        table.columns().every(function () {
            var that = this;
            $('input', this.header()).on('keyup change', function () {
                if (that.search() !== this.value) {
                    that
                        .search(this.value)
                        .draw();
                }
            });
        });
        $('.btnBlock').click(function () {
            var userId = $(this).attr('data-id');
            $.ajax({
                type: ""Post"",
                url: ""/User/UnBlock"",
                data: { id: userId },
                success: function (response) {
                    if (response.status === ""success"") {
                        To");
                WriteLiteral(@"ast.fire({
                            type: response.status,
                            title: response.message
                        })
                        setInterval(function () {
                            window.location.href = response.url;
                        }, 1000);
                    }
                    else {
                        Toast.fire({
                            type: 'error',
                            title: response.message
                        })
                    }
                }

            });
        })



    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prize.Models.UserTranViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
