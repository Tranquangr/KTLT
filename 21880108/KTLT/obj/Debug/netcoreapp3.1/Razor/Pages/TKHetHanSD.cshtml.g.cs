#pragma checksum "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f68f17e6412f3a32da416a1ce3b00f9e8c96ce79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KTLT.Pages.Pages_TKHetHanSD), @"mvc.1.0.razor-page", @"/Pages/TKHetHanSD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68f17e6412f3a32da416a1ce3b00f9e8c96ce79", @"/Pages/TKHetHanSD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fd568c48e50b060534cbe45d2369be5a1992fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TKHetHanSD : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
  
    ViewData["Title"] = "TKHetHanSD";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5 class=""mt-5 text-danger"">THỐNG KÊ SẢN PHẨM HẾT HẠN SỬ DỤNG</h5>


<div class=""mt-5"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Mã sản phẩm</th>
                <th>Tên sản phẩm</th>
                <th>Loại sản phẩm</th>
                <th>Hạn sử dụng</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
             if (Model.dsSanpham.DsSp != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                 for (int i = 0; i < Model.dsSanpham.DsSp.Length; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                     if (Model.dsSanpham.DsSp[i] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                           Write(Model.dsSanpham.DsSp[i].Masp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                           Write(Model.dsSanpham.DsSp[i].Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                           Write(Model.dsSanpham.DsSp[i].LoaiSp.TenChungLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                           Write(Model.dsSanpham.DsSp[i].HSD.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\QUANG\Desktop\Kỹ thuật lập trình\KTLT_1\KTLT\Pages\TKHetHanSD.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KTLT.Pages.TKHetHanSDModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.TKHetHanSDModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KTLT.Pages.TKHetHanSDModel>)PageContext?.ViewData;
        public KTLT.Pages.TKHetHanSDModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591