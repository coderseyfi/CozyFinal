#pragma checksum "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ddd2b6339081ebaa174c6550bef59bbd2fc6ba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\_ViewImports.cshtml"
using Cozy.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\_ViewImports.cshtml"
using Cozy.Domain.Models.ViewModels.ContactPostInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\_ViewImports.cshtml"
using Cozy.Domain.Models.Entites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\_ViewImports.cshtml"
using Cozy.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\_ViewImports.cshtml"
using Cozy.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ddd2b6339081ebaa174c6550bef59bbd2fc6ba3", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9e1baa3380a4829a5ec1ceb33b86d7e2949f676", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Academy p513\FinalProject\Cozy Solution\Cozy.WebUI\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>

    <!-- slider-area-start -->
    <div class=""slider-area over-hidden"">
        <div class=""single-page blog-none page-height-2 position-relative d-flex
          align-items-center""
             style=""background-image:
          url(./assets/imgs/blog-slidebar-none-banner.jpg); min-height: 900px;"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 d-flex
                align-items-center justify-content-center"">
                        <div class=""page-title-content"">
                            <div class=""page-text text-center"">
                                <ul class=""blog-tag d-flex pb-25 justify-content-center"">
                                    <li>
                                        <a class=""d-inline-block
                          p-0"" href=""#"">Image,</a>
                                    </li>
                                    <li>
     ");
            WriteLiteral(@"                                   <a class=""d-inline-block
                          p-0"" href=""#"">Photography,</a>
                                    </li>
                                    <li>
                                        <a class=""d-inline-block
                          p-0"" href=""#"">Travel</a>
                                    </li>
                                </ul>
                                <h2 class=""text-white"">Men Wearing Canvas Boots</h2>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <nav aria-label=""breadcrumb"" class=""page-nav position-absolute "">
                <ol class=""breadcrumb bg-transparent justify-content-center"">
                    <li class=""breadcrumb-item"">
                        <a class=""secondary-color""
                           href=""index.html"">Home</a>
                    </li>
                    <li class=""breadcrumb-item"">
");
            WriteLiteral(@"                        <a class=""secondary-color""
                           href=""blog-right-sidebar.html"">Image</a>
                    </li>
                    <li class=""breadcrumb-item active text-capitalize text-white""
                        aria-current=""page""> Men Wearing Canvas Boots</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- slider-area-end=  -->
    <!-- blog-banner-area-start -->
    <div class=""blog-banner-area pt-65 pb-65 over-hidden"">
        <div class=""container-wrapper "">
            <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                <div class=""blog-banner-left mb-30"">
                    <img src=""./assets/imgs/img-blog-left.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2832, "\"", 2838, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <ul class=\"blog-post-data\">\r\n                <li class=\"post-date pr-35\">\r\n                    Post date:<a");
            BeginWriteAttribute("class", " class=\"", 3005, "\"", 3013, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""#"">26 Jun, 2020</a>
                </li>
                <li class=""post-view pr-20"">
                    <span class=""fa fa-eye pr-1""></span>533 Views
                </li>
                <li class=""post-comments"">
                    <span>
                        <i class=""far fa-comment""></i>
                    </span><span class=""px-1"">0</span>Comments
                </li>
            </ul>
        </div>
    </div>
    <!-- banner-area-end  -->
    <!-- blog-content-area-start -->
    <div class=""blog-content-area pb-90 over-hidden"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                    <div class=""blog-content pl-55 pr-55"">
                        <h3>Sunt In Qui Officia Deserunt</h3>
                        <p class=""pb-15"">
                            The tiles are highly resistant to water and
                            dirt and can be cleaned, so they are compa");
            WriteLiteral(@"tible with the
                            cultivation of plants and cooking, and the functions at the
                            window are expanded.
                        </p>
                        <p>
                            For me, the most important part of improving at photography
                            has been sharing it. Sign up for an Exposure account, or post
                            regularly to Tumblr, or both. Tell people you’re trying to get
                            better at photography. Talk about it. When you talk about it,
                            other people get excited about it.
                        </p>
                        <div class=""blog-footer d-sm-flex justify-content-between
                  pt-50"">
                            <ul class=""post-tag pb-20"">
                                <li><a class=""secondary-color d-block mr-1"" href=""#"">Image</a></li>
                                <li><a class=""secondary-color d-block mr-1"" href=""#"">");
            WriteLiteral(@"Photography</a></li>
                                <li><a class=""secondary-color d-block mr-1"" href=""#"">Travel</a></li>
                            </ul>
                            <ul class=""social-link pb-20"">
                                <li>
                                    <a class=""text-white d-block f-bg"" href=""#"">
                                        <i class=""fa-brands fa-facebook-f""></i>
                                    </a>
                                </li>
                                <li>
                                    <a class=""text-white d-block t-bg"" href=""#"">
                                        <i class=""fa-brands fa-twitter""></i>
                                    </a>
                                </li>
                                <li>
                                    <a class=""text-white d-block g-bg"" href=""#"">
                                        <i class=""fa-brands fa-google-plus-g""></i>
                                    </a>");
            WriteLiteral(@"
                                </li>
                            </ul>
                        </div>
                    </div>
                </div><!-- /col -->
            </div><!-- /row -->
        </div><!-- /container -->
    </div>
    <!-- blog-content-area-end  -->
    <!-- author-area-start   -->
    <div class=""author-post-area pt-100 pb-110 over-hidden"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                    <div class=""single-author-post pl-55 pr-55"">
                        <ul class=""blog-posts d-sm-flex justify-content-between pb-70"">
                            <li class=""mb-30"">
                                <h4>Miranda Skoczek Homestay</h4>
                            </li>
                            <li class=""text-right mb-30"">
                                <h4>How Wear The Summer Stlye</h4>
                            </li>
                        </ul>");
            WriteLiteral(@"
                        <div class=""author-post-details gray-bg2 pl-30 pr-30 pt-30
                  pb-20"">
                            <div class=""row"">
                                <div class=""col-xl-10 col-lg-10 col-md-9 col-sm-12 col-12"">
                                    <div class=""author-post mb-15"">
                                        <span class=""position-relative black-color pl-50 cmnt-own
                          pb-10 "">Admin</span>
                                        <span class=""comment-date"">4 days ago</span>
                                        <p class=""mt-10"">
                                            The tiles are highly resistant to water and dirt and
                                            can be cleaned, so they are compatible with the
                                            cultivation of plants and cooking, and the functions
                                            at the window are expanded
                                        </p>
   ");
            WriteLiteral(@"                                 </div>
                                </div><!-- /col -->
                            </div><!-- /row -->
                        </div>
                    </div>
                </div><!-- /col -->
            </div><!-- /row -->
        </div><!-- /container -->
    </div>
    <!-- author-area-end  -->
    <!-- blog section start -->
    <section class=""blog-section"">
        <div class=""container-wrapper"">
            <div class=""row g-0"">
                <div class=""col-xl-12  col-lg-12  col-md-12  col-sm-12 col-12"">
                    <div class=""container-wrapper__title text-center"">
                        <h2 class=""container-wrapper__title--head"">Recent Posts</h2>
                        <p class=""container-wrapper__title--text"">Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore.</p>
                    </div>
                </div>
            </div>
            <div class=""blog-slider"">
       ");
            WriteLiteral(@"         <div>
                    <div class=""pic"">
                        <div class=""blog-slider__item"">
                            <div class=""blog-slider__item__img over-hidden"">
                                <img src=""./assets/imgs/blog-img1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9418, "\"", 9424, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-slider__item__content"">
                                <ul class=""blog-slider__item__content--list d-flex"">
                                    <li class=""blog-slider__item__content--item"">
                                        <span>Post date:</span>
                                    </li>
                                    <li class=""blog-slider__item__content--item"">
                                        <a class=""date"" href=""#"">01 nov, 2020</a>
                                    </li>
                                </ul>
                                <h4>
                                    <a class=""blog-slider__item__content__link"" href=""blog-details.html"">Supt In Qui Officia Deserunt</a>
                                </h4>
                                <p>It is accompanied by a case that can contain up to three different diffusers and can be used for dry …</p>

                            <");
            WriteLiteral(@"/div>
                        </div>
                    </div>
                </div>
                <div>
                    <div class=""pic"">
                        <div class=""blog-slider__item"">
                            <div class=""blog-slider__item__img over-hidden"">
                                <img src=""./assets/imgs/blog-img2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10807, "\"", 10813, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-slider__item__content"">
                                <ul class=""blog-slider__item__content--list d-flex"">
                                    <li class=""blog-slider__item__content--item"">
                                        <span>Post date:</span>
                                    </li>
                                    <li class=""blog-slider__item__content--item"">
                                        <a class=""date"" href=""#"">01 nov, 2020</a>
                                    </li>
                                </ul>
                                <h4>
                                    <a class=""blog-slider__item__content__link"" href=""blog-details.html"">How Wear The Summer Style</a>
                                </h4>
                                <p>It is accompanied by a case that can contain up to three different diffusers and can be used for dry …</p>
                            </div>");
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div>
                    <div class=""pic"">
                        <div class=""blog-slider__item"">
                            <div class=""blog-slider__item__img over-hidden"">
                                <img src=""./assets/imgs/blog-img3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12191, "\"", 12197, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-slider__item__content"">
                                <ul class=""blog-slider__item__content--list d-flex"">
                                    <li class=""blog-slider__item__content--item"">
                                        <span>Post date:</span>
                                    </li>
                                    <li class=""blog-slider__item__content--item"">
                                        <a class=""date"" href=""#"">01 nov, 2020</a>
                                    </li>
                                </ul>
                                <h4>
                                    <a class=""blog-slider__item__content__link"" href=""blog-details.html"">Men Wearing Canvas Boots</a>
                                </h4>
                                <p>It is accompanied by a case that can contain up to three different diffusers and can be used for dry …</p>
                            </div>");
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div>
                    <div class=""pic"">
                        <div class=""blog-slider__item"">
                            <div class=""blog-slider__item__img over-hidden"">
                                <img src=""./assets/imgs/blog-img4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13574, "\"", 13580, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-slider__item__content"">
                                <ul class=""blog-slider__item__content--list d-flex"">
                                    <li class=""blog-slider__item__content--item"">
                                        <span>Post date:</span>
                                    </li>
                                    <li class=""blog-slider__item__content--item"">
                                        <a class=""date"" href=""#"">01 nov, 2020</a>
                                    </li>
                                </ul>
                                <h4>
                                    <a class=""blog-slider__item__content__link"" href=""blog-details.html"">Miranda Skoaled Homestead</a>
                                </h4>
                                <p>It is accompanied by a case that can contain up to three different diffusers and can be used for dry …</p>
                            </div>");
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- blog section end -->
    <!-- blog-area-start -->
    <div class=""reply-form-area pb-100 pt-95"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                    <div class=""reply-form contact-form-right pl-55 pr-55"">
                        <h3 class=""pb-10"">Leave a Reply </h3>
                        <p>
                            Your email address will not be published. Required fields are
                            marked *
                        </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ddd2b6339081ebaa174c6550bef59bbd2fc6ba321541", async() => {
                WriteLiteral(@"
                            <div class=""comment mb-30"">
                                <textarea name=""message"" class=""form-control"" id=""message""
                                          placeholder=""Comments""></textarea>
                            </div>
                            <a href=""#"" class=""btn text-white dark-black-bg transition-3"">
                                Post
                                Comments
                            </a>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div><!-- /col -->\r\n            </div><!-- /row -->\r\n        </div><!-- /container -->\r\n    </div>\r\n    <!-- blog-area-end -->\r\n\r\n</main>\r\n\r\n");
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
