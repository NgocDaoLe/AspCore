#pragma checksum "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fbc01ec00534562c63b11a2624d6190a773d9b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietchudes_Index), @"mvc.1.0.view", @"/Views/Chitietchudes/Index.cshtml")]
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
#line 1 "C:\Users\X507M-PC\Desktop\AspCore\Views\_ViewImports.cshtml"
using shophoatuoi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X507M-PC\Desktop\AspCore\Views\_ViewImports.cshtml"
using shophoatuoi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbc01ec00534562c63b11a2624d6190a773d9b6", @"/Views/Chitietchudes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf082b0d169a355efaf564f2c5c9e7c7cd1a057", @"/Views/_ViewImports.cshtml")]
    public class Views_Chitietchudes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<shophoatuoi.Models.Chitietchude>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: deeppink;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""animated fadeIn"">
    <div class=""row clearfix"">
        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""card"">
                <div class=""header"">
                    <div class=""card-header"" style=""font-family:'Times New Roman', Times, serif; font-size:30px ;width: 50%; margin: 0px auto; text-align:center;"">
                        <strong class=""card-title"">Chi Tiết Chủ Đề - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbc01ec00534562c63b11a2624d6190a773d9b64407", async() => {
                WriteLiteral("Tạo Mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                                                                               WriteLiteral(ViewBag.SpMa);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</strong>
                    </div>
                </div>
                     <div class=""body"">
                    <div class=""table-responsive"">
                        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <table class=""table table-bordered table-striped table-hover js-basic-example dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr>
                                                <th>
                                                    ");
#nullable restore
#line 25 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.CtcdMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 28 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.CdMaNavigation.CdTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 31 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.SpMaNavigation.SpTen));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </th>
                                                <th style=""width: 80px""></th>
                                            </tr>
                                        </thead>

                                        <tbody>
");
#nullable restore
#line 38 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 42 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CtcdMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 45 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CdMaNavigation.CdTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 48 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.SpMaNavigation.SpTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3104, "\"", 3172, 1);
#nullable restore
#line 51 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
WriteAttributeValue("", 3111, Url.Action("Edit","CHITIETCHUDEs", new { id = item.CtcdMa }), 3111, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-orange waves-effect\"><i class=\"material-icons\">build</i></a>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3304, "\"", 3375, 1);
#nullable restore
#line 52 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
WriteAttributeValue("", 3311, Url.Action("Delete", "CHITIETCHUDEs", new { id = item.CtcdMa }), 3311, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-red waves-effect\"><i class=\"material-icons\">delete</i></a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\X507M-PC\Desktop\AspCore\Views\Chitietchudes\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<shophoatuoi.Models.Chitietchude>> Html { get; private set; }
    }
}
#pragma warning restore 1591
