#pragma checksum "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6dd41d89b7e16f34ea1cefa2819d8d05dc31bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KTLT.Pages.Pages_SuaHoaDonNH), @"mvc.1.0.razor-page", @"/Pages/SuaHoaDonNH.cshtml")]
namespace KTLT.Pages
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
#line 1 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\_ViewImports.cshtml"
using KTLT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6dd41d89b7e16f34ea1cefa2819d8d05dc31bf", @"/Pages/SuaHoaDonNH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fd568c48e50b060534cbe45d2369be5a1992fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SuaHoaDonNH : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
  
    ViewData["Title"] = "SuaHoaDonNH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h5 class=\"mt-5 text-danger\">SỬA HÓA ĐƠN NHẬP HÀNG</h5>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec6dd41d89b7e16f34ea1cefa2819d8d05dc31bf4354", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-2\">\r\n        <label class=\"col-sm-2 col-form-label\">Số hóa đơn</label>\r\n        <div class=\"col-sm-5\">\r\n            <input type=\"text\" class=\"form-control\" id=\"inputEmail3\" name=\"shd\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 414, "\"", 442, 1);
#nullable restore
#line 14 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
WriteAttributeValue("", 422, Model.hoaDonNH.SoHD, 422, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-2\">\r\n        <label class=\"col-sm-2 col-form-label\">Sản phẩm</label>\r\n        <div class=\"col-sm-5\">\r\n            <select id=\"inputState\" class=\"form-select\" name=\"masp\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec6dd41d89b7e16f34ea1cefa2819d8d05dc31bf5508", async() => {
                    WriteLiteral("Chọn sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                 if (Model.dsSanpham.DsSp != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                     for (int i = 0; i < Model.dsSanpham.DsSp.Length; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec6dd41d89b7e16f34ea1cefa2819d8d05dc31bf7955", async() => {
#nullable restore
#line 26 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                                                                 Write(Model.dsSanpham.DsSp[i].Masp);

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ||  ");
#nullable restore
#line 26 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                                                                                                    Write(Model.dsSanpham.DsSp[i].Tensp);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                           WriteLiteral(Model.dsSanpham.DsSp[i].Masp);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\SuaHoaDonNH.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-2\">\r\n        <label class=\"col-sm-2 col-form-label\">Số lượng</label>\r\n        <div class=\"col-sm-5\">\r\n            <input type=\"text\" class=\"form-control\" id=\"inputEmail3\" name=\"sl\"");
                BeginWriteAttribute("value", " value=\"", 1358, "\"", 1366, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary mt-3\">Sửa hóa đơn</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KTLT.Pages.SuaHoaDonNHModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.SuaHoaDonNHModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.SuaHoaDonNHModel>)PageContext?.ViewData;
        public KTLT.Pages.SuaHoaDonNHModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
