#pragma checksum "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ba02fc1b0d0dbc89fbd6857460fad7a3829af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KTLT.Pages.Pages_TaoHoaDonBH), @"mvc.1.0.razor-page", @"/Pages/TaoHoaDonBH.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ba02fc1b0d0dbc89fbd6857460fad7a3829af6", @"/Pages/TaoHoaDonBH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fd568c48e50b060534cbe45d2369be5a1992fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TaoHoaDonBH : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
  
    ViewData["Title"] = "Tạo hóa đơn bán hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h5 class=\"mt-5 text-danger\">THÊM HÓA ĐƠN BÁN HÀNG</h5>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ba02fc1b0d0dbc89fbd6857460fad7a3829af64073", async() => {
                WriteLiteral(@"
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Số hóa đơn</label>
        <div class=""col-sm-5"">
            <input type=""text"" class=""form-control"" id=""inputEmail3"" name=""shd"" required>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Sản phẩm</label>
        <div class=""col-sm-5"">
            <select id=""inputState"" class=""form-select"" name=""masp1"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ba02fc1b0d0dbc89fbd6857460fad7a3829af64814", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
#line 22 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                 if (Model.dsSanpham != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                     if (Model.dsSanpham.DsSp != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                         for (int i = 0; i < Model.dsSanpham.DsSp.Length; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ba02fc1b0d0dbc89fbd6857460fad7a3829af67320", async() => {
#nullable restore
#line 28 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                                                                     Write(Model.dsSanpham.DsSp[i].Masp);

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ||  ");
#nullable restore
#line 28 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
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
#line 28 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
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
#line 29 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TaoHoaDonBH.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Số lượng</label>
        <div class=""col-sm-5"">
            <input type=""text"" class=""form-control"" id=""inputEmail3"" name=""sl1"" required>
        </div>
    </div>

    <button type=""submit"" class=""btn btn-primary mt-3"">Thêm hóa đơn</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KTLT.Pages.TaoHoaDonBHModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.TaoHoaDonBHModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.TaoHoaDonBHModel>)PageContext?.ViewData;
        public KTLT.Pages.TaoHoaDonBHModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
