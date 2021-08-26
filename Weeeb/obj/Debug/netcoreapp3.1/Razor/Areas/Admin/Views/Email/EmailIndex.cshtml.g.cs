#pragma checksum "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4a89cfd278f139566ab36a387173d91503ca46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_EmailIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/EmailIndex.cshtml")]
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
#line 1 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\_ViewImports.cshtml"
using Weeeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\_ViewImports.cshtml"
using Weeeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4a89cfd278f139566ab36a387173d91503ca46", @"/Areas/Admin/Views/Email/EmailIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91a5482b7722685eda7e0472e455c60b01d2d6b", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Email_EmailIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Email_Info>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
  
    ViewData["title"] = "Trang chủ";
    Layout = "~/Areas/Admin/Views/Shared/_Layouta.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Quản lý Email</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""/Admin/Home/Index"">Home</a></li>
                    <li class=""breadcrumb-item active"">DataTables</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""col-md-14"">
            <div class=""card "">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title"">Danh sách email</h4>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
");
#nullable restore
#line 30 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                         if (ViewBag.SuccessMsg != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                                ");
#nullable restore
#line 33 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                           Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 35 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""table-responsive ps"">
                        <div class=""row"">
                            <div class=""col-sm-12 col-md-6"">
                                <div class=""dt-buttons btn-group flex-wrap"">
                                    <button class=""btn btn-secondary buttons-copy buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Copy</span></button> <button class=""btn btn-secondary buttons-csv buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>CSV</span></button> <button class=""btn btn-secondary buttons-excel buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Excel</span></button><a href=""order_actions.php?action=pdf""> <button class=""btn btn-secondary buttons-pdf buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>PDF</span></button></a> <button class=""btn btn-secondary buttons-print"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Print</span></b");
            WriteLiteral(@"utton>
                                    <div class=""btn-group""><button class=""btn btn-secondary buttons-collection dropdown-toggle buttons-colvis"" tabindex=""0"" aria-controls=""example1"" type=""button"" aria-haspopup=""true"" aria-expanded=""false""><span>Column visibility</span></button></div>
                                </div>
                            </div>
                            <div class=""col-sm-12 col-md-6"">
                                <div id=""example1_filter"" class=""dataTables_filter"">
                                    <label>
                                        Tìm kiếm:
                                        <input id=""myInput"" type=""search"" class=""form-control form-control-sm""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3092, "\"", 3106, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""example1"" onkeyup=""filter()"">
                                    </label>
                                </div>
                            </div>
                        </div>
                        <table class=""table tablesorter table-hover"" id=""table-meo"">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>Mã Email</th>
                                    <th>Email</th>
                                    <th><a href=""/Admin/Email/CreateEmail"" class=""btn btn-success"">Thêm mới</a></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 63 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                                 foreach (var a in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 66 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                                       Write(a.email_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 67 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                                       Write(a.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4179, "\"", 4210, 2);
            WriteAttributeValue("", 4186, "EditEmail?Id=", 4186, 13, true);
#nullable restore
#line 69 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
WriteAttributeValue("", 4199, a.email_id, 4199, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'button\' rel=\'tooltip\'");
            BeginWriteAttribute("title", " title=\'", 4239, "\'", 4247, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" data-original-title=\'Edit User\'>\r\n                                                <div class=\'ripple-container\'>Sửa  </div>\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4494, "\"", 4527, 2);
            WriteAttributeValue("", 4501, "DeleteEmail?Id=", 4501, 15, true);
#nullable restore
#line 72 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
WriteAttributeValue("", 4516, a.email_id, 4516, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'button\' rel=\'tooltip\'");
            BeginWriteAttribute("title", " title=\'", 4556, "\'", 4564, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"" data-original-title='Delete User'>
                                                <div class='ripple-container'>Xóa</div>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 77 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Admin\Views\Email\EmailIndex.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                        <div class=""ps__rail-x"" style=""left: 0px; bottom: 0px;""><div class=""ps__thumb-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps__rail-y"" style=""top: 0px; right: 0px;""><div class=""ps__thumb-y"" tabindex=""0"" style=""top: 0px; height: 0px;""></div></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function filter() {
        // Declare variables
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById(""myInput"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""table-meo"");
        tr = table.getElementsByTagName(""tr"");

        // Loop through all table rows, and hide those who don't match the search query
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[0];
            if (td) {
            ");
            WriteLiteral(@"    txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                }
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Email_Info>> Html { get; private set; }
    }
}
#pragma warning restore 1591
