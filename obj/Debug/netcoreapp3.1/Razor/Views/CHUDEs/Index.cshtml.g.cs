#pragma checksum "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48edd48f6c4fe89a7009923d45e62485951e9a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CHUDEs_Index), @"mvc.1.0.view", @"/Views/CHUDEs/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\_ViewImports.cshtml"
using shophoatuoi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\_ViewImports.cshtml"
using shophoatuoi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48edd48f6c4fe89a7009923d45e62485951e9a10", @"/Views/CHUDEs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf082b0d169a355efaf564f2c5c9e7c7cd1a057", @"/Views/_ViewImports.cshtml")]
    public class Views_CHUDEs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<shophoatuoi.Models.Chude>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

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
                        <strong class=""card-title"">Danh sách chủ đề -  ");
#nullable restore
#line 14 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                                                  Write(Html.ActionLink("Tạo mới", "Create",null,new {@style="color: deeppink;"}));

#line default
#line hidden
#nullable disable
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
#line 26 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.CdMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 29 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.CdTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<th style=\"width: 80px\"></th>\r\n                                            </tr>\r\n                                        </thead>\r\n\r\n                                        <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 40 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CdMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 43 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CdTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2562, "\"", 2621, 1);
#nullable restore
#line 47 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
WriteAttributeValue("", 2569, Url.Action("Edit","CHUDEs", new { id = item.CdMa }), 2569, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-orange waves-effect\"><i class=\"material-icons\">build</i></a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2715, "\"", 2777, 1);
#nullable restore
#line 48 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
WriteAttributeValue("", 2722, Url.Action("Delete", "CHUDEs", new { id = item.CdMa }), 2722, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-red waves-effect\"><i class=\"material-icons\">delete</i></a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\ASUS\OneDrive\Máy tính\shophoatuoi\shophoatuoi\Views\CHUDEs\Index.cshtml"
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
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<shophoatuoi.Models.Chude>> Html { get; private set; }
    }
}
#pragma warning restore 1591