#pragma checksum "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1241d762619ba0d443aa5dda354f799e99917e73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Index.cshtml", typeof(AspNetCore.Views_Transaction_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1241d762619ba0d443aa5dda354f799e99917e73", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c9426c31ee4617d416847aaccd2722e64dd104", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prize.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendMoneyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(109, 101, true);
                WriteLiteral("\r\n\r\n    <style>\r\n        #table tbody td {\r\n            position: relative\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(213, 1669, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card-header"">
                <div>
                    <a id=""createTransaction"" style=""background: #d7b118;"" data-toggle=""modal"" data-target=""#exampleModal""
                       class=""pl-4 pr-4 btn btn-info btn-square btn-outline-dashed waves-effect waves-light""><i class=""ti-plus mr-2 ""></i>New</a>
                </div>
            </div>




            <table id=""table"" class=""table table-hover table-bordered "">
                <thead>
                    <tr>
                        <th>Transaction №<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
                        <th>Sender<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
                        <th>Receiver<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
                        <th>Amount<br /><input type=""text"" placeholder=""Source"" class=""form-con");
            WriteLiteral(@"trol"" /></th>
                        <th>Send Date<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
                        <th>Statusu<br /><input type=""text"" placeholder=""Source"" class=""form-control"" /></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>123 </td>
                        <td>Samir Kerimov </td>
                        <td>Qasim Mammadov   </td>
                        <td>100 </td>
                        <td> 02/08/2020 14:30</td>
                        <td> Appove</td>

                    </tr>
");
            EndContext();
#line 49 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                     if (Model != null)
                    {

                        

#line default
#line hidden
#line 52 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2029, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2100, 22, false);
#line 55 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(item.TransactionNubmer);

#line default
#line hidden
            EndContext();
            BeginContext(2122, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2166, 25, false);
#line 56 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(ViewBag.SendUser.Firstame);

#line default
#line hidden
            EndContext();
            BeginContext(2191, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2193, 25, false);
#line 56 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                          Write(ViewBag.SendUser.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(2218, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2262, 18, false);
#line 57 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(item.User.Firstame);

#line default
#line hidden
            EndContext();
            BeginContext(2280, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2282, 18, false);
#line 57 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                   Write(item.User.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(2300, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2344, 11, false);
#line 58 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2355, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2399, 42, false);
#line 59 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(item.SendDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2485, 23, false);
#line 60 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                               Write(item.StatusTrans.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2508, 44, true);
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                        }

#line default
#line hidden
#line 63 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(2602, 997, true);
            WriteLiteral(@"
                </tbody>
            </table>





            <!-- Modal -->
            <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Create Transaction</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-lg-12 p-5"">
                                        ");
            EndContext();
            BeginContext(3599, 2088, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1241d762619ba0d443aa5dda354f799e99917e7312302", async() => {
                BeginContext(3687, 400, true);
                WriteLiteral(@"

                                            <div>
                                                <div class=""form-group "">
                                                    <label class=""control-label"">Users</label>
                                                    <select   style=""width: 100%;"" required=""required"" placeholder=""Select"" id=""user"" class=""custom-select select2DropDown"">
");
                EndContext();
#line 93 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                         foreach (var item in ViewBag.Users)
                                                        {

#line default
#line hidden
                BeginContext(4240, 60, true);
                WriteLiteral("                                                            ");
                EndContext();
                BeginContext(4300, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1241d762619ba0d443aa5dda354f799e99917e7313545", async() => {
                    BeginContext(4327, 13, false);
#line 95 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                                                 Write(item.Firstame);

#line default
#line hidden
                    EndContext();
                    BeginContext(4340, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(4342, 13, false);
#line 95 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                                                                Write(item.Lastname);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 95 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4364, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "C:\Users\ga.mammadov\source\repos\Prize\Prize\Views\Transaction\Index.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(4425, 1255, true);
                WriteLiteral(@"                                                    </select>

                                                </div>
                                                <div class=""form-group"">
                                                    <label class=""control-label"">Amount</label>
                                                    <input class=""form-control amount"" type=""number"" min=""1"" required=""required"" aria-invalid=""True"" />

                                                </div>
                                                <div class=""form-group"">
                                                    <label class=""control-label"">Discount</label>
                                                    <input class=""form-control comisya"" readonly type=""number"" min=""1"" required=""required"" aria-invalid=""True"" />

                                                </div>
                                            </div>
                                            <div class=""justify-content-end");
                WriteLiteral(" p-3 row\">\r\n                                                <button type=\"button\" id=\"sendBTN\" class=\"btn btn-outline-dark\">Send</button>\r\n                                            </div>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5687, 299, true);
            WriteLiteral(@"
                                    </div>

                                </div>
                            </div>
                        </div>
                         
                    </div>
                </div>
            </div>

        </div>

    </div>

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6003, 2124, true);
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

       
        $(document).ready(function () {
            $("".amount"").keyup(function () {
                var point = $(this).val() / 100;
                $("".comisya"").val(point);

            })

            $(""#sendBTN"").click(function () {
                var amount = $("".amount"").val();
                var discount = $(""");
                WriteLiteral(@".comisya"").val();
                var userId = $(""#user :selected"").val();
                $.ajax({
                    type: ""Post"",
                    url: ""/Transaction/CreateTransaction"",
                    data: { id: userId , amount: amount , discount: discount},
                    success: function (response) {
                        if (response.status === ""success"") {
                            Toast.fire({
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
                ");
                WriteLiteral("    }\r\n\r\n                });\r\n            })\r\n        })\r\n \r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prize.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
