#pragma checksum "C:\cluna\ProjectGit\AppProperty\appProperty\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42cb979937b426abab372c1e60e2384818cf718b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\cluna\ProjectGit\AppProperty\appProperty\Views\_ViewImports.cshtml"
using appProperty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\cluna\ProjectGit\AppProperty\appProperty\Views\_ViewImports.cshtml"
using appProperty.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42cb979937b426abab372c1e60e2384818cf718b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70659b9db6253c0fbc5bb3e697ea45f2723b9686", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\cluna\ProjectGit\AppProperty\appProperty\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutHome";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Main Slider-->
<section class=""hero-slider"" style=""background-image: url(img/hero-slider/main-bg.jpg);"">
    <div class=""owl-carousel large-controls dots-inside""
         data-owl-carousel=""{ &quot;nav&quot;: true, &quot;dots&quot;: true, &quot;loop&quot;: true, &quot;autoplay&quot;: true, &quot;autoplayTimeout&quot;: 5000 }"">
");
            WriteLiteral(@"        {
            <div class=""item"">
                <div class=""container padding-top-3x"">
                    <div class=""row justify-content-center align-items-center"">
                        <div class=""col-lg-5 col-md-6 padding-bottom-2x text-md-left text-center"">
                            <div class=""from-bottom"">
                                <img class=""d-inline-block w-150 mb-4"" src=""img/hero-slider/logo02.png"" alt=""Puma"">  <!--Logo-->
                                <div class=""h2 text-body text-normal mb-2 pt-1"">Puma Backpacks Collection</div>      <!--Description-->
                                <div class=""h2 text-body text-normal mb-4 pb-1"">starting at <span class=""text-bold"">$37.99</span></div> <!-- Price-->
                            </div><a class=""btn btn-primary scale-up delay-1"" href=""shop-grid-ls.html"">View Offers</a>  <!--Page to go-->
                        </div> 
                        <div class=""col-md-6 padding-bottom-2x mb-3""><img class=""d-block mx-auto"" s");
            WriteLiteral(@"rc=""img/hero-slider/02.png"" alt=""Puma Backpack""></div> <!--Pic-->
                    </div>
                </div>
            </div>
        }
        </div>
</section>

<!-- Popular Brands-->
<section class=""bg-faded padding-top-3x padding-bottom-3x"">
    <div class=""container"">
        <h3 class=""text-center mb-30 pb-2"">Popular Brands</h3>
        <div class=""owl-carousel"" data-owl-carousel=""{ &quot;nav&quot;: false, &quot;dots&quot;: false, &quot;loop&quot;: true, &quot;autoplay&quot;: true, &quot;autoplayTimeout&quot;: 3000, &quot;responsive&quot;: {&quot;0&quot;:{&quot;items&quot;:2}, &quot;470&quot;:{&quot;items&quot;:3},&quot;630&quot;:{&quot;items&quot;:4},&quot;991&quot;:{&quot;items&quot;:5},&quot;1200&quot;:{&quot;items&quot;:6}} }"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/01.png"" alt=""Adidas"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/02.png"" alt=""Brooks"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""");
            WriteLiteral(@"img/brands/03.png"" alt=""Valentino"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/04.png"" alt=""Nike"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/05.png"" alt=""Puma"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/06.png"" alt=""New Balance"">
            <img class=""d-block w-110 opacity-75 m-auto"" src=""img/brands/07.png"" alt=""Dior"">
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
