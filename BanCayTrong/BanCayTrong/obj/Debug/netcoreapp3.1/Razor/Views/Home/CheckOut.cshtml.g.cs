#pragma checksum "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f1a0efaffc1f0b7e743678fc477626c0a18f5c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckOut), @"mvc.1.0.view", @"/Views/Home/CheckOut.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f1a0efaffc1f0b7e743678fc477626c0a18f5c7", @"/Views/Home/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de2f6d21a43c1c41fc686ec86a7400e62063932", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BanCayTrong.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
  
    ViewData["Title"] = "Xác nhận thanh toán";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1> Thông tin đơn hàng</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h3>Thông tin khách</h3>\r\n");
#nullable restore
#line 11 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
         if (ViewBag.khachhang != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1a0efaffc1f0b7e743678fc477626c0a18f5c75109", async() => {
                WriteLiteral("\r\n                <div class=\"my-3\">\r\n                    <label>Họ tên</label>\r\n                    <input type=\"text\" disabled");
                BeginWriteAttribute("value", " value=\"", 434, "\"", 464, 1);
#nullable restore
#line 16 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 442, ViewBag.khachhang.Ten, 442, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"hoten\" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Email</label>\r\n                    <input type=\"email\" disabled");
                BeginWriteAttribute("value", " value=\"", 654, "\"", 686, 1);
#nullable restore
#line 20 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 662, ViewBag.khachhang.Email, 662, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"email\" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Điện thoại</label>\r\n                    <input type=\"text\" disabled");
                BeginWriteAttribute("value", " value=\"", 880, "\"", 916, 1);
#nullable restore
#line 24 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 888, ViewBag.khachhang.Dienthoai, 888, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"dienthoai\" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Địa chỉ</label> <br />\r\n");
#nullable restore
#line 28 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                      
                        foreach (DiaChi dc in ViewBag.diachi)
                        {
                            string tmp = dc.Diachi1 + ", " + dc.Phuongxa + ", " + dc.Quanhuyen + ", " + dc.Tinhthanh;
                            if (dc.Macdinh == 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1436, "\"", 1449, 1);
#nullable restore
#line 34 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1441, dc.Madc, 1441, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"madiachi\"");
                BeginWriteAttribute("value", " value=\"", 1466, "\"", 1482, 1);
#nullable restore
#line 34 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1474, dc.Madc, 1474, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked=\"true\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 1539, "\"", 1553, 1);
#nullable restore
#line 35 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1545, dc.Madc, 1545, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                                                 Write(tmp);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (Mặc định)</label><br>\r\n");
#nullable restore
#line 36 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1731, "\"", 1744, 1);
#nullable restore
#line 39 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1736, dc.Madc, 1736, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"madiachi\"");
                BeginWriteAttribute("value", " value=\"", 1761, "\"", 1777, 1);
#nullable restore
#line 39 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1769, dc.Madc, 1769, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 1819, "\"", 1833, 1);
#nullable restore
#line 40 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1825, dc.Madc, 1825, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                                                 Write(tmp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br>\r\n");
#nullable restore
#line 41 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                            }

                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"my-3\">\r\n                    <input type=\"submit\" value=\"Xác nhận đặt hàng\" class=\"btn btn-success\" />\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1a0efaffc1f0b7e743678fc477626c0a18f5c713273", async() => {
                WriteLiteral(@"
                <div class=""my-3"">
                    <label>Họ tên</label>
                    <input type=""text"" name=""hoten"" class=""form-control"" />
                </div>
                <div class=""my-3"">
                    <label>Email</label>
                    <input type=""email"" name=""email"" class=""form-control"" />
                </div>
                <div class=""my-3"">
                    <label>Điện thoại</label>
                    <input type=""text"" name=""dienthoai"" class=""form-control"" />
                </div>
                <div class=""my-3"">
                    <label>Địa chỉ</label> <br />
                    Địa chỉ cụ thể: <input type=""text"" name=""diachicuthe"" class=""form-control"" />
                    Phường xã: <input type=""text"" name=""phuongxa"" class=""form-control"" />
                    Quận huyện: <input type=""text"" name=""quanhuyen"" class=""form-control"" />
                    Tỉnh thành: <input type=""text"" name=""tinhthanh"" class=""form-control"" />
           ");
                WriteLiteral("     </div>\r\n                <div class=\"my-3\">\r\n                    <input type=\"submit\" value=\"Xác nhận đặt hàng\" class=\"btn btn-success\" />\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h3>Thông tin giỏ hàng</h3>\r\n");
#nullable restore
#line 82 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
         if (Model.Count > 0)
        {
            int stt = 1;
            int thanhtien = 0;
            int tongtien = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <tr>
                    <th>STT</th>
                    <th>Sản phẩm</th>
                    <th>Giá</th>
                    <th>Số lượng</th>
                    <th>Thành tiền</th>
                </tr>

");
#nullable restore
#line 97 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                 foreach (var i in Model)
                {
                    thanhtien = i.mathang.Giaban * i.soluong;
                    tongtien += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"align-middle\">\r\n                        <td>");
#nullable restore
#line 102 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                        Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f1a0efaffc1f0b7e743678fc477626c0a18f5c717721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4279, "~/images/mathang/", 4279, 17, true);
#nullable restore
#line 104 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
AddHtmlAttributeValue("", 4296, i.mathang.Hinhanh, 4296, 20, false);

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
            WriteLiteral("\r\n                            ");
#nullable restore
#line 105 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                        Write(i.mathang.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 107 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                        Write(i.mathang.Giaban.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n\r\n                        <td>");
#nullable restore
#line 109 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                        Write(i.soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 110 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                        Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n                    </tr>\r\n");
#nullable restore
#line 112 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\" class=\"text-end fw-bold\">Tổng tiền</td>\r\n                    <td colspan=\"2\" class=\"fw-bold\">");
#nullable restore
#line 115 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
                                                Write(tongtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 118 "C:\Users\t0195\Desktop\ASP NET\DOAN\QLBanCayTrong\BanCayTrong\BanCayTrong\Views\Home\CheckOut.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BanCayTrong.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
