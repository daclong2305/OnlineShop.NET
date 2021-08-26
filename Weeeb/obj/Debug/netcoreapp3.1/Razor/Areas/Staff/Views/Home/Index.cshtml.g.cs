#pragma checksum "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a58d660e1a214484a697964ba81cc911a30de8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Staff_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Staff/Views/Home/Index.cshtml")]
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
#line 1 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\_ViewImports.cshtml"
using Weeeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\_ViewImports.cshtml"
using Weeeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58d660e1a214484a697964ba81cc911a30de8d8", @"/Areas/Staff/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91a5482b7722685eda7e0472e455c60b01d2d6b", @"/Areas/Staff/_ViewImports.cshtml")]
    public class Areas_Staff_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewModel9>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
  
    ViewData["title"] = "Trang chủ";
    Layout = "~/Areas/Staff/Views/Shared/_Layouta.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Dashboard</h1>
            </div>
            <!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">Dashboard v1</li>
                </ol>
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</div>
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 34 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                       Write(ViewBag.countord0);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <!-- <h3>150</h3> -->

                        <p>Đơn hàng mới</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                    <a href=""/Staff/Order/OrderIndex"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 50 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                       Write(ViewBag.countpro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <p>Sản phẩm</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/Staff/Product/ProductIndex"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 64 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                       Write(ViewBag.countpro5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <p>Sắp hết hàng</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/Staff/Product/ProductIndex"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 78 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                       Write(ViewBag.countpro0);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <p>Hết hàng</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/Staff/Product/ProductIndex"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5 class=""card-title"">Thống kê báo cáo</h5>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type");
            WriteLiteral(@"=""button"" class=""btn btn-tool dropdown-toggle"" data-toggle=""dropdown"">
                                    <i class=""fas fa-wrench""></i>
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" role=""menu"">
                                    <a href=""#"" class=""dropdown-item"">Action</a>
                                    <a href=""#"" class=""dropdown-item"">Another action</a>
                                    <a href=""#"" class=""dropdown-item"">Something else here</a>
                                    <a class=""dropdown-divider""></a>
                                    <a href=""#"" class=""dropdown-item"">Separated link</a>
                                </div>
                            </div>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
              ");
            WriteLiteral(@"      </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""row"">
                            <!-- /.col -->
                            <div class=""col-md-6"">
                                <p class=""text-center"">
                                    <strong>Mục tiêu trong tháng</strong>
                                </p>

                                <div class=""progress-group"">
                                    Tổng số đơn hàng ghi nhận
                                    <span class=""float-right"">
                                        <b>
                                            ");
#nullable restore
#line 130 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                       Write(ViewBag.countordall);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 131 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                               var percent = @ViewBag.countordall * 100 / 200; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </b>/200\r\n                                    </span>\r\n                                    <div class=\"progress progress-sm\">\r\n                                        <div class=\"progress-bar bg-primary\"");
            BeginWriteAttribute("style", " style=\"", 6199, "\"", 6223, 3);
            WriteAttributeValue("", 6207, "width:", 6207, 6, true);
#nullable restore
#line 135 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6213, percent, 6214, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6222, "%", 6222, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->

                                <div class=""progress-group"">
                                    Đơn hàng đã hoàn thành
                                    <span class=""float-right"">
                                        <b>
                                            ");
#nullable restore
#line 144 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                       Write(ViewBag.countord1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 145 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                               var percent1 = @ViewBag.countord1 * 100 / 200; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </b>/200\r\n                                    </span>\r\n                                    <div class=\"progress progress-sm\">\r\n                                        <div class=\"progress-bar bg-danger\"");
            BeginWriteAttribute("style", " style=\"", 7012, "\"", 7037, 3);
            WriteAttributeValue("", 7020, "width:", 7020, 6, true);
#nullable restore
#line 149 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7026, percent1, 7027, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7036, "%", 7036, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    </div>
                                </div>

                                <!-- /.progress-group -->
                                <div class=""progress-group"">
                                    <span class=""progress-text"">Tổng số sản phẩm bán ra</span>
                                    <span class=""float-right"">
                                        <b>
                                            ");
#nullable restore
#line 158 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                       Write(ViewBag.soldpro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 159 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                               var percent2 = @ViewBag.soldpro * 100 / 500; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </b>/500\r\n                                    </span>\r\n                                    <div class=\"progress progress-sm\">\r\n                                        <div class=\"progress-bar bg-success\"");
            BeginWriteAttribute("style", " style=\"", 7859, "\"", 7884, 3);
            WriteAttributeValue("", 7867, "width:", 7867, 6, true);
#nullable restore
#line 163 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7873, percent2, 7874, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7883, "%", 7883, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    </div>
                                </div>

                                <!-- /.progress-group -->
                                <div class=""progress-group"">
                                    Số lượng feedback sản phẩm
                                    <span class=""float-right"">
                                        <b>
                                            ");
#nullable restore
#line 172 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                       Write(ViewBag.countrev);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 173 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                               var percent3 = @ViewBag.countrev * 100 / 500; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </b>/500\r\n                                    </span>\r\n                                    <div class=\"progress progress-sm\">\r\n                                        <div class=\"progress-bar bg-warning\"");
            BeginWriteAttribute("style", " style=\"", 8676, "\"", 8701, 3);
            WriteAttributeValue("", 8684, "width:", 8684, 6, true);
#nullable restore
#line 177 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8690, percent3, 8691, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8700, "%", 8700, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    </div>
                                </div>
                                <!-- /.progress-group -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-md-6"">
                                <p class=""text-center"">
                                    <strong>Top 3 khách hàng mua nhiều nhất</strong>
                                </p>
                                <table class=""table table-bordered table-hover"">
                                    <tr>
                                        <th>TOP</th>
                                        <th>Người dùng</th>
                                        <th>Số đơn hàng</th>
                                    </tr>
");
#nullable restore
#line 193 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                       var i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 198 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\'fas fa-crown\'></i>\r\n");
#nullable restore
#line 199 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                                   i = i + 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 202 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                           Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 205 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                           Write(item.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 208 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </table>
                            </div>
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- ./card-body -->
                    <div class=""card-footer"">
                        <div class=""row"">
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-success""><i class=""fas fa-caret-up""></i> 17%</span>
                                    <h5 class=""description-header"">
                                        ");
#nullable restore
#line 221 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                   Write(ViewBag.sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ
                                    </h5>
                                    <span class=""description-text"">Tổng doanh thu</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                            <!-- /.col -->
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-warning""><i class=""fas fa-caret-left""></i> 0%</span>
                                    <h5 class=""description-header"">
                                        ");
#nullable restore
#line 232 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                   Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </h5>
                                    <span class=""description-text"">Số lượng người dùng</span>
                                </div>
                                <!-- /.description-block -->
                            </div>

                            <!-- /.col -->
                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-success""><i class=""fas fa-caret-up""></i> 20%</span>
                                    <h5 class=""description-header"">
                                        ");
#nullable restore
#line 244 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                   Write(ViewBag.countproall);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </h5>
                                    <span class=""description-text"">Tổng số sản phẩm</span>
                                </div>
                                <!-- /.description-block -->
                            </div>

                            <div class=""col-sm-3 col-6"">
                                <div class=""description-block border-right"">
                                    <span class=""description-percentage text-success""><i class=""fas fa-caret-up""></i> 20%</span>
                                    <h5 class=""description-header"">
                                        ");
#nullable restore
#line 255 "D:\C#\Weeeb3\Weeeb\Weeeb\Areas\Staff\Views\Home\Index.cshtml"
                                   Write(ViewBag.brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </h5>
                                    <span class=""description-text"">Thương hiệu</span>
                                </div>
                                <!-- /.description-block -->
                            </div>
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- /.card-footer -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
    </div>
    <!-- /.container-fluid -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewModel9>> Html { get; private set; }
    }
}
#pragma warning restore 1591
