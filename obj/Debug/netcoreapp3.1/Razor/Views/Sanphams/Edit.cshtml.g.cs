#pragma checksum "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e47f6807bb87544993aba2f09858479b321743e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanphams_Edit), @"mvc.1.0.view", @"/Views/Sanphams/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e47f6807bb87544993aba2f09858479b321743e", @"/Views/Sanphams/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf082b0d169a355efaf564f2c5c9e7c7cd1a057", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanphams_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<shophoatuoi.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SANPHAMs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Times New Roman\', Times, serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n    <div class=\"card\">           \r\n        <div class=\"body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e47f6807bb87544993aba2f09858479b321743e5616", async() => {
                WriteLiteral(@"
                <div class=""row clearfix"" style=""font-family:'Times New Roman', Times, serif; width: 50%; margin: 0px auto; text-align:center;"">
                    <div class=""col-lg-offset-2 col-md-offset-2 col-sm-offset-4 col-xs-offset-5"">
                        <h3>
                            Cập Nhật Sản Phẩm
                        </h3>
                    </div>
                </div>
                    ");
#nullable restore
#line 18 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
               Write(Html.HiddenFor(model => model.SpMa));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""SpMa"">Mã Sản Phẩm</label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    ");
#nullable restore
#line 27 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.EditorFor(model => model.SpMa, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""SpTen"">Tên Sản Phẩm</label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    ");
#nullable restore
#line 40 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.EditorFor(model => model.SpTen, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 41 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.SpTen, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""SpGia"">Giá </label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    ");
#nullable restore
#line 54 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.EditorFor(model => model.SpGia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 55 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.SpGia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""SpMotachitiet"">Mô Tả Chi Tiết</label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    ");
#nullable restore
#line 68 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.EditorFor(model => model.SpMotachitiet, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 69 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.SpMotachitiet, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""SpGioithieu"">Giới Thiệu Sản Phẩm</label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    ");
#nullable restore
#line 82 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.EditorFor(model => model.SpGioithieu, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 83 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.SpGioithieu, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row clearfix"">
                        <div class=""col-lg-2 col-md-2 col-sm-4 col-xs-5 form-control-label"">
                            <label for=""HaMa"">Hình Ảnh Sản Phẩm</label>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8 col-xs-7"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <input list=""HaMa"" name=""HaMa"">
                                    <datalist id=""HaMa"">
                                        ");
#nullable restore
#line 98 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                                   Write(Html.EditorFor(model => model.HaMa, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 99 "C:\Users\X507M-PC\Desktop\AspCore\Views\Sanphams\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.HaMa, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </datalist>
                                </div>
                            </div>
                        </div>
                    </div>
                   <div class=""row clearfix"" style=""width: 50%; margin: 0px auto; text-align:center;"">
                    <div class=""col-lg-offset-2 col-md-offset-2 col-sm-offset-4 col-xs-offset-5"">
                        <input type=""submit"" value=""Lưu"" class=""btn btn-danger"" />
                        <button type=""button"" class="" btn btn-primary"">  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e47f6807bb87544993aba2f09858479b321743e14769", async() => {
                    WriteLiteral("Quay Trở Lại");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </button>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<shophoatuoi.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591
