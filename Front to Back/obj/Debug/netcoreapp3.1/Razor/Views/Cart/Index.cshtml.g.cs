#pragma checksum "C:\Users\Elnur\Desktop\P126\ASP\Admin-panel, Partial\Front to Back\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fb093b9b047010721e983322b3fa46036873023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Elnur\Desktop\P126\ASP\Admin-panel, Partial\Front to Back\Views\_ViewImports.cshtml"
using FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elnur\Desktop\P126\ASP\Admin-panel, Partial\Front to Back\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elnur\Desktop\P126\ASP\Admin-panel, Partial\Front to Back\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb093b9b047010721e983322b3fa46036873023", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c6c1b5c85d2a1b37ea5459476a243eac87af9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Elnur\Desktop\P126\ASP\Admin-panel, Partial\Front to Back\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container"">
        <div class=""row"">
            <div class=""home d-flex"">
                <a href=""home.html"">HOME</a>
                <i class=""fa-solid fa-angle-right""></i>
                <span>Cart</span>
            </div>
        </div>
    </div>

    <section>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-8"">
                    <div class=""cart-product mt-5"">
                        <div class=""row"">
                            <div class=""col-7 product-name"">
                                <p>Product</p>
                            </div>
                            <div class=""col-1 product-price"">
                                <p>Price</p>
                            </div>
                            <div class=""col-2 product-quantity"">
                                <p>Quantity</p>
                            </div>
                            <div class=""col-2 product-subtotal"">
           ");
            WriteLiteral(@"                     <p>Subtotal</p>
                            </div>
                        </div>
                        <div class=""all-products mt-2"">
                            <div class=""row"">
                                <div class=""col-7"">
                                    <img src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-62-90x90.jpg""");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 1457, "\"", 1505, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span>All Natural Italian-Style Chicken Meatballs</p>
                                </div>
                                <div class=""col-1 mt-4"">
                                    <p>$7.25</p>
                                </div>
                                <div class=""col-2 mt-4 d-flex"">
                                    <div class=""minus"">
                                        <span>-</span>
                                    </div>
                                    <div class=""count"">
                                        <span>1</span>
                                    </div>
                                    <div class=""plus"">
                                        <span>+</span>
                                    </div>
                                </div>
                                <div class=""col-2 mt-4 total"">
                                    <p>$7.25</p>
                                    <i class=""fa-soli");
            WriteLiteral(@"d fa-xmark""></i>
                                </div>
                            </div>
                        </div>
                        <div class=""all-products mt-2"">
                            <div class=""row"">
                                <div class=""col-7"">
                                    <img src=""https://klbtheme.com/bacola/wp-content/uploads/2021/04/product-image-60-90x90.jpg""");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 2941, "\"", 2989, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span>Angie's Boomchickapop Sweet & Salty Kettle Corn</p>
                                </div>
                                <div class=""col-1 mt-4"">
                                    <p>$3.29</p>
                                </div>
                                <div class=""col-2 mt-4 d-flex"">
                                    <div class=""minus"">
                                        <span>-</span>
                                    </div>
                                    <div class=""count"">
                                        <span>1</span>
                                    </div>
                                    <div class=""plus"">
                                        <span>+</span>
                                    </div>
                                </div>
                                <div class=""col-2 mt-4 total"">
                                    <p>$3.29</p>
                                    <i class=""fa-");
            WriteLiteral(@"solid fa-xmark""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-6"">
                            <input type=""text"" placeholder=""Coupon code"" class=""coupon-code"">
                            <button class=""apply-coupon"">Apply Coupon</button>
                        </div>
                        <div class=""col-6"">
                            <button class=""update-cart"">Update cart</button>
                        </div>
                    </div>
                </div>
                <div class=""col-4 mt-5"">
                    <div class=""shopping-details"">
                        <div class=""container"">
                            <h2>Cart Totals</h2>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 total"">
                                <th>Subt");
            WriteLiteral(@"otal</th>
                            </div>
                            <div class=""col-6 total-price"">
                                <th>$10.54</th>
                            </div>
                        </div>
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-4 mt-3"">
                                    <div class=""shipping"">
                                        <th>Shipping</th>
                                    </div>
                                </div>
                                <div class=""col-8 mt-3"">
                                    <div class=""shipping-details"">
                                        <div class=""shipping-info mt-1"">
                                            <span class=""flat-rate"">Flat rate:</span>
                                            <span class=""five-dol""> $5.00</span>
                                            <input type=""radio"" class=""fi");
            WriteLiteral(@"ve"" name=""myRadios"" value=""1"">
                                        </div>
                                        <div class=""shipping-info mt-1"">
                                            <span class=""free-shp"">Free Shipping</span>
                                            <input type=""radio"" class=""free-shipping"" name=""myRadios"" value=""2"">
                                        </div>
                                        <div class=""shipping-info mt-1"">
                                            <span class=""local-pick"">Local pickup</span>
                                            <input type=""radio"" class=""local-pickup"" name=""myRadios"" value=""3"">
                                        </div>
                                        <div class=""shipping-info mt-1"">
                                            <span class=""shipping-to"">Shipping to</span><strong> AL</strong>
                                            <br>
                                            <br>
          ");
            WriteLiteral(@"                              </div>
                                        <a href=""#"">Change Address</a>
                                    </div>
                                </div>
                                <div class=""total-price-products"">
                                    <div class=""row"">
                                        <div class=""col-6 mt-5"">
                                            <h6>Total</h6>
                                        </div>
                                        <div class=""col-6 mt-5"">
                                            <h4>$15.54</h4>
                                        </div>
                                    </div>
                                </div>
                                <button class=""btn-checkout mt-3"">Proceed to checkout</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</ma");
            WriteLiteral("in>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591