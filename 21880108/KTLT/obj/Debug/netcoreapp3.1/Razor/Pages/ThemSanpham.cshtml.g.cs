#pragma checksum "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d39df8633bb5a57d5a4be3936404e89febba2a72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KTLT.Pages.Pages_ThemSanpham), @"mvc.1.0.razor-page", @"/Pages/ThemSanpham.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d39df8633bb5a57d5a4be3936404e89febba2a72", @"/Pages/ThemSanpham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fd568c48e50b060534cbe45d2369be5a1992fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ThemSanpham : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
  
    ViewData["Title"] = "ThemSanpham";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5 class=\"mt-5 text-danger\">THÊM SẢN PHẨM</h5>\r\n");
#nullable restore
#line 8 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
 if (Model.dsChungLoai.dsloai == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Danh sách loại sản phẩm rỗng.</p>\r\n");
#nullable restore
#line 11 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39df8633bb5a57d5a4be3936404e89febba2a724183", async() => {
                WriteLiteral(@"
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Mã sản phẩm</label>
        <div class=""col-sm-5"">
            <input type=""text"" class=""form-control"" id=""inputEmail3"" name=""masp"" required>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Tên sản phẩm</label>
        <div class=""col-sm-5"">
            <input type=""text"" class=""form-control"" id=""inputPassword3"" name=""tensp"" required>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Hạn sử dụng</label>
        <div class=""col-sm-5"">
            <input type=""date"" class=""form-control"" id=""inputPassword3"" name=""hsd"" required>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Nhà sản xuất</label>
        <div class=""col-sm-5"">
            <input type=""text"" class=""form-control"" id=""inputPassword3"" name=""nhasx"" required>
        </div>
    </div>
    <div class=""ro");
                WriteLiteral(@"w mb-2"">
        <label class=""col-sm-2 col-form-label"">Ngày sản xuất</label>
        <div class=""col-sm-5"">
            <input type=""date"" class=""form-control"" id=""inputPassword3"" name=""nsx"" required>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Loại hàng</label>
        <div class=""col-sm-5"">
            <select id=""inputState"" class=""form-select"" name=""lsp"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39df8633bb5a57d5a4be3936404e89febba2a726025", async() => {
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
#line 50 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                 if (Model.dsChungLoai.dsloai != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                     for (int i = 0; i < Model.dsChungLoai.dsloai.Length; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39df8633bb5a57d5a4be3936404e89febba2a728267", async() => {
#nullable restore
#line 54 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                                                                            Write(Model.dsChungLoai.dsloai[i].TenChungLoai);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                           WriteLiteral(Model.dsChungLoai.dsloai[i].MaChungLoai);

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
#line 55 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\ThemSanpham.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""row mb-2"">
        <label class=""col-sm-2 col-form-label"">Giá</label>
        <div class=""col-sm-5"">
            <input type=""number"" class=""form-control"" id=""inputPassword3"" name=""gia"" required>
        </div>
    </div>

    <button type=""submit"" class=""btn btn-primary mt-3"">Thêm sảm phẩm</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KTLT.Pages.ThemSanphamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.ThemSanphamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.ThemSanphamModel>)PageContext?.ViewData;
        public KTLT.Pages.ThemSanphamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
