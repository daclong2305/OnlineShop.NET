#pragma checksum "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9b663f4bd58778914164cdd80d3d7ca3f54219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProduct), @"mvc.1.0.view", @"/Views/Product/GetProduct.cshtml")]
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
#line 1 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Weeeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Weeeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9b663f4bd58778914164cdd80d3d7ca3f54219", @"/Views/Product/GetProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7327607597b52ae4e95cf7058766c536c8b7e581", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Weeeb.Models.ViewModel2>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("review-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
  
    ViewData["Title"] = "Trang s???n ph???m";
    var a = ViewBag.CaseId;
    if (Context.Session.GetString("username") != null)
    {
        ViewData["acc"] = "Hi " + Context.Session.GetString("username");
    }
    else
    {
        ViewData["acc"] = "My Account";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css'>
<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
<style>
    body {
        background-color: white;
        color: #000;
        overflow-x: hidden
    }

    .card {
        margin: auto;
        padding: 20px;
        border-radius: 15px;
        margin-top: 0px;
        margin-bottom: 25px
    }

    fieldset.active {
        display: block !important
    }

    fieldset {
        display: none
    }

    .pic0 {
        width: 600px;
        height: 600px;
        margin-left: 50px;
        margin-right: auto;
        display: block
    }

    .product-pic {
        padding-left: 25px;
        padding-right: 150px;
        width: 100%
    }

    .thumbnails {
        position: absolute
    }

    .fit-image {
        width: 100%;
   ");
            WriteLiteral(@"     object-fit: cover
    }

    .tb {
        width: 82px;
        height: 82px;
        border: 1px solid grey;
        margin: 2px;
        opacity: 0.4;
        cursor: pointer
    }

    .tb-active {
        opacity: 1
    }

    .thumbnail-img {
        width: 80px;
        height: 80px
    }
</style>
<!-- /BREADCRUMB -->
<script type=""text/javascript"">
    jQuery(document).ready(function ($) {
        $("".scroll"").click(function (event) {
            // event.preventDefault();
            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 900);
        });
    });
</script>
<script>

    (function (global) {
        if (typeof (global) === ""undefined"") {
            throw new Error(""window is undefined"");
        }
        var _hash = ""!"";
        var noBackPlease = function () {
            global.location.href += ""#"";
            // making sure we have the fruit available for juice....
            // 50 milliseconds for just once do not cost much");
            WriteLiteral(@" (^__^)
            global.setTimeout(function () {
                global.location.href += ""!"";
            }, 50);
        };
        // Earlier we had setInerval here....
        global.onhashchange = function () {
            if (global.location.hash !== _hash) {
                global.location.hash = _hash;
            }
        };
        global.onload = function () {
            noBackPlease();
            // disables backspace on page except on input fields and textarea..
            document.body.onkeydown = function (e) {
                var elm = e.target.nodeName.toLowerCase();
                if (e.which === 8 && (elm !== 'input' && elm !== 'textarea')) {
                    // e.preventDefault();
                }
                // stopping event bubbling up the DOM tree..
                e.stopPropagation();
            };
        };
    })(window);
</script>

<!-- SECTION -->
<div class=""section main main-raised"">
    <!-- container -->
    <div class=""container"" ");
            WriteLiteral(@"asp-action=""GetProduct"">
        <!-- row -->
        <div class=""row"">
            <!-- Product main img -->
            <div class=""container-fluid col-md-7 px-sm-1 py-5 mx-auto"">
                <div class=""row justify-content-center"">
                    <div class=""d-flex"">
                        <div class=""card"">
                            <div class=""d-flex flex-column thumbnails"">
                                <div id=""f1"" class=""tb tb-active""> <img class=""thumbnail-img fit-image""");
            BeginWriteAttribute("src", " src=\"", 3899, "\"", 3970, 2);
            WriteAttributeValue("", 3905, "/product_images/", 3905, 16, true);
#nullable restore
#line 138 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 3921, Html.DisplayFor(model => model.pr.product_image), 3921, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                                <div id=\"f2\" class=\"tb\"> <img class=\"thumbnail-img fit-image\"");
            BeginWriteAttribute("src", " src=\"", 4074, "\"", 4145, 2);
            WriteAttributeValue("", 4080, "/product_images/", 4080, 16, true);
#nullable restore
#line 139 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 4096, Html.DisplayFor(model => model.pr.product_image), 4096, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                                <div id=\"f3\" class=\"tb\"> <img class=\"thumbnail-img fit-image\"");
            BeginWriteAttribute("src", " src=\"", 4249, "\"", 4320, 2);
            WriteAttributeValue("", 4255, "/product_images/", 4255, 16, true);
#nullable restore
#line 140 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 4271, Html.DisplayFor(model => model.pr.product_image), 4271, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                                <div id=\"f4\" class=\"tb\"> <img class=\"thumbnail-img fit-image\"");
            BeginWriteAttribute("src", " src=\"", 4424, "\"", 4495, 2);
            WriteAttributeValue("", 4430, "/product_images/", 4430, 16, true);
#nullable restore
#line 141 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 4446, Html.DisplayFor(model => model.pr.product_image), 4446, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                            </div>\r\n                            <fieldset id=\"f11\" class=\"active\">\r\n                                <div class=\"product-pic\"> <img class=\"pic0\"");
            BeginWriteAttribute("src", " src=\"", 4681, "\"", 4752, 2);
            WriteAttributeValue("", 4687, "/product_images/", 4687, 16, true);
#nullable restore
#line 144 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 4703, Html.DisplayFor(model => model.pr.product_image), 4703, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                            </fieldset>\r\n                            <fieldset id=\"f21\"");
            BeginWriteAttribute("class", " class=\"", 4850, "\"", 4858, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"product-pic\"> <img class=\"pic0\"");
            BeginWriteAttribute("src", " src=\"", 4937, "\"", 5008, 2);
            WriteAttributeValue("", 4943, "/product_images/", 4943, 16, true);
#nullable restore
#line 147 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 4959, Html.DisplayFor(model => model.pr.product_image), 4959, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                            </fieldset>\r\n                            <fieldset id=\"f31\"");
            BeginWriteAttribute("class", " class=\"", 5106, "\"", 5114, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"product-pic\"> <img class=\"pic0\"");
            BeginWriteAttribute("src", " src=\"", 5193, "\"", 5264, 2);
            WriteAttributeValue("", 5199, "/product_images/", 5199, 16, true);
#nullable restore
#line 150 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 5215, Html.DisplayFor(model => model.pr.product_image), 5215, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                            </fieldset>\r\n                            <fieldset id=\"f41\"");
            BeginWriteAttribute("class", " class=\"", 5362, "\"", 5370, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"product-pic\"> <img class=\"pic0\"");
            BeginWriteAttribute("src", " src=\"", 5449, "\"", 5520, 2);
            WriteAttributeValue("", 5455, "/product_images/", 5455, 16, true);
#nullable restore
#line 153 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 5471, Html.DisplayFor(model => model.pr.product_image), 5471, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                            </fieldset>
                        </div>
                    </div>
                </div>
            </div>
            <!-- FlexSlider -->
            <div class=""container-fluid col-md-5 px-sm-1 py-5 mx-auto"">
                <div class=""product-details"">
                    <h2 class=""product-name"">");
#nullable restore
#line 162 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                        Write(Html.DisplayFor(model => model.pr.product_title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <div>
                        <div class=""product-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <a class=""review-link"" href=""#review-form"">10 ????nh gi?? | Th??m ????nh gi?? c???a b???n</a>
                    </div>
                    <div>
                        <h3 class=""product-price"">");
#nullable restore
#line 174 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                             Write(Html.DisplayFor(model => model.pr.product_price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??<del class=\"product-old-price\">990.000 ??</del></h3>\r\n                        <span class=\"product-available\">C??N H??NG</span>\r\n                    </div>\r\n                    <p>");
#nullable restore
#line 177 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                  Write(Html.DisplayFor(model => model.pr.product_desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9b663f4bd58778914164cdd80d3d7ca3f5421916043", async() => {
                WriteLiteral(@"
                        <div class=""add-to-cart"">
                            <div class=""qty-label"">
                                S??? l?????ng: 
                                <input class=""input-select"" type=""number"" min=""1"" max=""99"" value=""1"" name=""quantity""/>
                                <input name=""id"" class=""id"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 7203, "\"", 7257, 1);
#nullable restore
#line 184 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 7211, Html.DisplayFor(model => model.pr.product_id), 7211, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden />
                            </div>
                            <div class=""btn-group"" style=""margin-left: 25px; margin-top: 15px"">
                                <button type=""submit"" class=""add-to-cart-btn"" id=""product""><i class=""fa fa-shopping-cart""></i> Th??m v??o gi???</button>
                            </div>
                        </div>
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
            WriteLiteral(@"
                    <ul class=""product-btns"">
                        <li><a href=""#""><i class=""fa fa-heart-o""></i> th??m v??o wishlist</a></li>
                        <li><a href=""#""><i class=""fa fa-exchange""></i> th??m so s??nh</a></li>
                    </ul>

                    <ul class=""product-links"">
                        <li>Lo???i:</li>
                        <li><a href=""#"">??i???n t???</a></li>
                        <li><a href=""#"">Thi??t b???</a></li>
                    </ul>

                    <ul class=""product-links"">
                        <li>Chia s???:</li>
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-envelope""></i></a></li>
                    </ul>

                </div>
            </div>


            <!-- /Product ");
            WriteLiteral(@"main img -->
            <!-- Product thumb imgs -->
            <!-- /Product thumb imgs -->
            <!-- Product details -->
            <!-- /Product details -->
            <!-- Product tab -->
            <div class=""col-md-12"">
                <div id=""product-tab"">
                    <!-- product tab nav -->
                    <ul class=""tab-nav"">
                        <li class=""active""><a data-toggle=""tab"" href=""#tab1"">M?? t???</a></li>
                        <li><a data-toggle=""tab"" href=""#tab2"">Chi ti???t</a></li>
                        <li><a data-toggle=""tab"" href=""#tab3"">????nh gi?? (3)</a></li>
                    </ul>
                    <!-- /product tab nav -->
                    <!-- product tab content -->
                    <div class=""tab-content"">
                        <!-- tab1  -->
                        <div id=""tab1"" class=""tab-pane fade in active"">
                            <div class=""row"">
                                <div class=""col-md-12"">
    ");
            WriteLiteral(@"                                <p>C??c ????? ??i???n t???, m???t h??ng ??i???n t??? ng??y nay ???? v?? c??ng ph??? bi???n v?? c???n thi???t trong cu???c s???ng ng?????i Vi???t. Ch??nh l?? b???i v?? t??nh ???ng d???ng, s??? d???ng cao c???a n?? cho cu???c s???ng, cho c??ng vi???c v?? cho gi???i tr??. C??c ????? d??ng ??i???n t??? ???????c ??a chu???ng hi???n nay nh?? c??c lo???i m??y t??nh, c??c lo???i di d???ng, c??c thi???t b??? nghe nh???c, c??c thi???t b??? ??i???n t??? ??i k??m???</p>
                                </div>
                            </div>
                        </div>
                        <!-- /tab1  -->
                        <!-- tab2  -->
                        <div id=""tab2"" class=""tab-pane fade in"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>");
#nullable restore
#line 244 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                  Write(Html.DisplayFor(model => model.pr.product_desc));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <!-- /tab2  -->
                        <!-- tab3  -->
                        <div id=""tab3"" class=""tab-pane fade in"">
                            <div class=""row"">
                                <!-- Rating -->
                                <div class=""col-md-3"">
                                    <div id=""rating"">
                                        <div class=""rating-avg"">
                                            <span>4.5</span>
                                            <div class=""rating-stars"">
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i c");
            WriteLiteral(@"lass=""fa fa-star-o""></i>
                                            </div>
                                        </div>
                                        <ul class=""rating"">
                                            <li>
                                                <div class=""rating-stars"">
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                </div>
                                                <div class=""rating-progress"">
                                                    <div style=""width: 80%;""></div>
                                                </div>
                                   ");
            WriteLiteral(@"             <span class=""sum"">3</span>
                                            </li>
                                            <li>
                                                <div class=""rating-stars"">
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                </div>
                                                <div class=""rating-progress"">
                                                    <div style=""width: 60%;""></div>
                                                </div>
                                                <span class=""sum"">2</span>
                                            </li>
 ");
            WriteLiteral(@"                                           <li>
                                                <div class=""rating-stars"">
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                </div>
                                                <div class=""rating-progress"">
                                                    <div></div>
                                                </div>
                                                <span class=""sum"">0</span>
                                            </li>
                                            <li>
                                                <div class=""ra");
            WriteLiteral(@"ting-stars"">
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                </div>
                                                <div class=""rating-progress"">
                                                    <div></div>
                                                </div>
                                                <span class=""sum"">0</span>
                                            </li>
                                            <li>
                                                <div class=""rating-stars"">
                                                    <i class=""fa fa-star""></i>
               ");
            WriteLiteral(@"                                     <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                    <i class=""fa fa-star-o""></i>
                                                </div>
                                                <div class=""rating-progress"">
                                                    <div></div>
                                                </div>
                                                <span class=""sum"">0</span>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- /Rating -->
                                <!-- Reviews -->
                                <div class=""col-md-6"">
                                    <div ");
            WriteLiteral("id=\"reviews\">\r\n                                        <ul class=\"reviews\">\r\n");
#nullable restore
#line 339 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                             foreach (var item in Model.rv)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <div class=\"review-heading\">\r\n                                                        <h5 class=\"name\">");
#nullable restore
#line 343 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                                                    Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                        <p class=""date"">27 DEC 2018, 8:0 PM</p>
                                                        <div class=""review-rating"">
                                                            <i class=""fa fa-star""></i>
                                                            <i class=""fa fa-star""></i>
                                                            <i class=""fa fa-star""></i>
                                                            <i class=""fa fa-star""></i>
                                                            <i class=""fa fa-star-o empty""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""review-body"">
                                                        <p>");
#nullable restore
#line 354 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                                      Write(item.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 357 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </ul>
                                        <ul class=""reviews-pagination"">
                                            <li class=""active"">1</li>
                                            <li><a href=""#"">2</a></li>
                                            <li><a href=""#"">3</a></li>
                                            <li><a href=""#"">4</a></li>
                                            <li><a href=""#""><i class=""fa fa-angle-right""></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- /Reviews -->
                                <!-- Review Form -->
                                <div class=""col-md-3 mainn"">
                                    <div id=""review-form"">
");
#nullable restore
#line 372 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                         if (Context.Session.GetString("username") != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9b663f4bd58778914164cdd80d3d7ca3f5421931878", async() => {
                WriteLiteral("\r\n                                            B??nh lu???n d?????i t??n: <b>");
#nullable restore
#line 375 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                                              Write(Context.Session.GetString("username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                                            <input class=\"input\" name=\"user_id\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 19497, "\"", 19516, 1);
#nullable restore
#line 376 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 19505, ViewBag.id, 19505, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                            <input class=\"input\" name=\"product_id\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 19623, "\"", 19651, 1);
#nullable restore
#line 377 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 19631, Model.pr.product_id, 19631, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                            <textarea class=""input"" name=""comment"" placeholder=""Your Review""></textarea>
                                            <div class=""input-rating"">
                                                <span>Your Rating: </span>
                                                <div class=""stars"">
                                                    <input id=""star5"" value=""5"" type=""radio""><label for=""star5""></label>
                                                    <input id=""star4"" value=""4"" type=""radio""><label for=""star4""></label>
                                                    <input id=""star3"" value=""3"" type=""radio""><label for=""star3""></label>
                                                    <input id=""star2"" value=""2"" type=""radio""><label for=""star2""></label>
                                                    <input id=""star1"" value=""1"" type=""radio""><label for=""star1""></label>
                                                </div>
       ");
                WriteLiteral("                                     </div>\r\n                                            <button type=\"submit\" class=\"primary-btn\">Submit</button>\r\n                                        ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#nullable restore
#line 391 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h1>????ng nh???p ????? review</h1>\r\n");
#nullable restore
#line 395 "D:\C#\Weeeb3\Weeeb\Weeeb\Views\Product\GetProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <!-- /Review Form -->
                            </div>
                        </div>
                        <!-- /tab3  -->
                    </div>
                    <!-- /product tab content  -->
                </div>
            </div>
            <!-- /product tab -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
<!-- Section -->
<!-- /Section -->
<!-- NEWSLETTER -->
<!-- /NEWSLETTER -->
<!-- FOOTER -->
<script>
    $(document).ready(function () {

        $("".tb"").hover(function () {

            $("".tb"").removeClass(""tb-active"");
            $(this).addClass(""tb-active"");

                                                    current_fs = $("".active"");

                                                    next_fs = $(this).attr('id');
                                                    next_fs = ""#"" + n");
            WriteLiteral(@"ext_fs + ""1"";

            $(""fieldset"").removeClass(""active"");
            $(next_fs).addClass(""active"");

                                                    current_fs.animate({}, {
                                                    step: function () {
                                                            current_fs.css({
                                                                'display': 'none',
                        'position': 'relative'
                                                            });
                                                            next_fs.css({
                                                                'display': 'block'
                                                            });
                                                        }
                                                    });
                                                });

                                            });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weeeb.Models.ViewModel2> Html { get; private set; }
    }
}
#pragma warning restore 1591
