#pragma checksum "D:\Programming\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82485f64da6166a45df490a98c225506ef922afc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82485f64da6166a45df490a98c225506ef922afc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "D:\Programming\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SearchBox", async() => {
                BeginContext(67, 26, true);
                WriteLiteral("\r\n    <header>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 93, "\"", 100, 0);
                EndWriteAttribute();
                BeginContext(101, 285, true);
                WriteLiteral(@" class=""logo""><img src=""/images/logo.png""></a>
        <h1> با اساتید مجرب و کارآزموده در خودآموز تاپ لرن </h1>
        <h2> آموزش ببینید ، تجربه کسب کنید و بازار کار شوید </h2>
        <h3> با کمترین هزینه خودت یاد بگیر </h3>
    </header>
    <div class=""search-form"">
        ");
                EndContext();
                BeginContext(386, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82485f64da6166a45df490a98c225506ef922afc3983", async() => {
                    BeginContext(392, 32, true);
                    WriteLiteral("\r\n            <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("name", " name=\"", 424, "\"", 431, 0);
                    EndWriteAttribute();
                    BeginContext(432, 113, true);
                    WriteLiteral(" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(552, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(569, 182, true);
            WriteLiteral("<main id=\"home-page\">\r\n    <div class=\"container\">\r\n        <section class=\"terms-items\">\r\n            <header>\r\n                <h2> آخرین دوره های تاپ لرن </h2>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 751, "\"", 758, 0);
            EndWriteAttribute();
            BeginContext(759, 245, true);
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1011, 0);
            EndWriteAttribute();
            BeginContext(1012, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1096, "\"", 1103, 0);
            EndWriteAttribute();
            BeginContext(1104, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1485, "\"", 1492, 0);
            EndWriteAttribute();
            BeginContext(1493, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1577, "\"", 1584, 0);
            EndWriteAttribute();
            BeginContext(1585, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1966, "\"", 1973, 0);
            EndWriteAttribute();
            BeginContext(1974, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2065, 0);
            EndWriteAttribute();
            BeginContext(2066, 388, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2454, "\"", 2461, 0);
            EndWriteAttribute();
            BeginContext(2462, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2546, "\"", 2553, 0);
            EndWriteAttribute();
            BeginContext(2554, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2935, "\"", 2942, 0);
            EndWriteAttribute();
            BeginContext(2943, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3027, "\"", 3034, 0);
            EndWriteAttribute();
            BeginContext(3035, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3422, "\"", 3429, 0);
            EndWriteAttribute();
            BeginContext(3430, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3514, "\"", 3521, 0);
            EndWriteAttribute();
            BeginContext(3522, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3903, "\"", 3910, 0);
            EndWriteAttribute();
            BeginContext(3911, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3995, "\"", 4002, 0);
            EndWriteAttribute();
            BeginContext(4003, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4390, "\"", 4397, 0);
            EndWriteAttribute();
            BeginContext(4398, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4482, "\"", 4489, 0);
            EndWriteAttribute();
            BeginContext(4490, 411, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>

        <hr>

        <section class=""terms-items"">
            <header>
                <h2> دوره های محبوب تاپ لرن </h2>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4901, "\"", 4908, 0);
            EndWriteAttribute();
            BeginContext(4909, 245, true);
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5154, "\"", 5161, 0);
            EndWriteAttribute();
            BeginContext(5162, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5246, "\"", 5253, 0);
            EndWriteAttribute();
            BeginContext(5254, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5635, "\"", 5642, 0);
            EndWriteAttribute();
            BeginContext(5643, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5727, "\"", 5734, 0);
            EndWriteAttribute();
            BeginContext(5735, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6116, "\"", 6123, 0);
            EndWriteAttribute();
            BeginContext(6124, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6208, "\"", 6215, 0);
            EndWriteAttribute();
            BeginContext(6216, 388, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6604, "\"", 6611, 0);
            EndWriteAttribute();
            BeginContext(6612, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6696, "\"", 6703, 0);
            EndWriteAttribute();
            BeginContext(6704, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7085, "\"", 7092, 0);
            EndWriteAttribute();
            BeginContext(7093, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7177, "\"", 7184, 0);
            EndWriteAttribute();
            BeginContext(7185, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7572, "\"", 7579, 0);
            EndWriteAttribute();
            BeginContext(7580, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7664, "\"", 7671, 0);
            EndWriteAttribute();
            BeginContext(7672, 381, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8053, "\"", 8060, 0);
            EndWriteAttribute();
            BeginContext(8061, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8145, "\"", 8152, 0);
            EndWriteAttribute();
            BeginContext(8153, 387, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8540, "\"", 8547, 0);
            EndWriteAttribute();
            BeginContext(8548, 84, true);
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8632, "\"", 8639, 0);
            EndWriteAttribute();
            BeginContext(8640, 286, true);
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>
    </div>
</main>

");
            EndContext();
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