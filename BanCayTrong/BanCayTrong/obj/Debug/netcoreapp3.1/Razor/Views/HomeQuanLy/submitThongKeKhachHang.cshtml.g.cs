#pragma checksum "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f248757cbd2055859a3452a1759b031cd72fc1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeQuanLy_submitThongKeKhachHang), @"mvc.1.0.view", @"/Views/HomeQuanLy/submitThongKeKhachHang.cshtml")]
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
#line 1 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\_ViewImports.cshtml"
using BanCayTrong;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\_ViewImports.cshtml"
using BanCayTrong.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f248757cbd2055859a3452a1759b031cd72fc1bf", @"/Views/HomeQuanLy/submitThongKeKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de2f6d21a43c1c41fc686ec86a7400e62063932", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeQuanLy_submitThongKeKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanCayTrong.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "submitThongKeKhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
  
    ViewData["Title"] = "Thống kê theo khách hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 class=\"text-info\">Thống kê theo khách hàng</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f248757cbd2055859a3452a1759b031cd72fc1bf4118", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label>Email khách hàng</label> <input type=""email"" name=""emailkhachhang"" />
            </div>
            <div class=""form-group"">
                <input class=""btn btn-info my-1"" type=""submit"" value=""Thống kê"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n<h5>Thông tin khách hàng</h5>\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Mã khách hàng\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
       Write(ViewBag.ttkhachhang.Makh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tên khách hàng\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
       Write(ViewBag.ttkhachhang.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Email\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
       Write(ViewBag.ttkhachhang.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Điện thoại\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
       Write(ViewBag.ttkhachhang.Dienthoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<label>Doanh thu từ khách hàng: ");
#nullable restore
#line 51 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                           Write(ViewData["tongtien"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</label>
<hr />

<div class=""border border-secondary"">
    <table class=""table"">
        <thead>
            <tr>
                <th>STT</th>
                <th>Mã hóa đơn</th>
                <th>Ngày lập</th>
                <th>Tổng tiền</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 65 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
              
                int stt = 1;
                foreach (HoaDon hd in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                       Write(hd.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                       Write(hd.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                       Write(hd.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeKhachHang.cshtml"
                    stt++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanCayTrong.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
