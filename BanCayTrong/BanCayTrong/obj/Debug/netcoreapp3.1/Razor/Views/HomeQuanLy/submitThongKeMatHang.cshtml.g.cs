#pragma checksum "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec09ea6a82ea908ad134ac7a7c93fcf4f433b117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeQuanLy_submitThongKeMatHang), @"mvc.1.0.view", @"/Views/HomeQuanLy/submitThongKeMatHang.cshtml")]
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
#line 1 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\_ViewImports.cshtml"
using BanCayTrong;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\_ViewImports.cshtml"
using BanCayTrong.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec09ea6a82ea908ad134ac7a7c93fcf4f433b117", @"/Views/HomeQuanLy/submitThongKeMatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de2f6d21a43c1c41fc686ec86a7400e62063932", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeQuanLy_submitThongKeMatHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanCayTrong.Models.CthoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "submitThongKeMatHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
  
    ViewData["Title"] = "Thống kê theo mặt hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-info\">Thống kê theo mặt hàng</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec09ea6a82ea908ad134ac7a7c93fcf4f433b1174647", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label>Mã mặt hàng</label> <input type=""text"" name=""mamathang"" />
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n<h5>Thông tin mặt hàng</h5>\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Mã mặt hàng\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
       Write(ViewBag.ttmathang.Mamh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tên\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
       Write(ViewBag.ttmathang.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Giá gốc\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
       Write(ViewBag.ttmathang.Giagoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Giá bán\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
       Write(ViewBag.ttmathang.Giaban);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Hình ảnh\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec09ea6a82ea908ad134ac7a7c93fcf4f433b1178317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1387, "~/images/mathang/", 1387, 17, true);
#nullable restore
#line 52 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
AddHtmlAttributeValue("", 1404, ViewBag.ttmathang.Hinhanh, 1404, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("            \r\n        </dd>\r\n    </dl>\r\n</div>\r\n<label>Doanh thu từ mặt hàng: ");
#nullable restore
#line 56 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
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
                <th>Đơn giá</th>
                <th>Số lượng</th>
                <th>Thành tiền</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 72 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
              
                int stt = 1;
                foreach (CthoaDon cthd in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(cthd.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(cthd.MahdNavigation.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 80 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(cthd.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 81 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(cthd.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
                           Write(cthd.Thanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 84 "C:\Users\t0195\Desktop\ASP NET\DOAN\BanCayTrong\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\HomeQuanLy\submitThongKeMatHang.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanCayTrong.Models.CthoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
