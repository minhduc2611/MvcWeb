#pragma checksum "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7858a2ed4b63b48cafa656cafe3d2e69678cd940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/_ViewImports.cshtml"
using project;

#line default
#line hidden
#line 2 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7858a2ed4b63b48cafa656cafe3d2e69678cd940", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229d22977632e367b33876458aad14c78337e6d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(38, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("products_breadcrumb", async() => {
                BeginContext(69, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(329, 42, true);
                WriteLiteral("    <section class=\"hero-wrap hero-wrap-2\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 371, "\"", 436, 4);
                WriteAttributeValue("", 379, "background-image:", 379, 17, true);
                WriteAttributeValue(" ", 396, "url(", 397, 5, true);
#line 13 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 401, Url.Content("~/images/bg_1.jpg"), 401, 33, false);

#line default
#line hidden
                WriteAttributeValue("", 434, ");", 434, 2, true);
                EndWriteAttribute();
                BeginContext(437, 462, true);
                WriteLiteral(@" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row no-gutters slider-text align-items-center justify-content-center"">
                <div class=""col-md-9 ftco-animate text-center"">
                    <h1 class=""mb-2 bread"">About</h1>
                    <p class=""breadcrumbs"">
                        <!-- breadcrumb  start here -->
                        <span class=""mr-2"">");
                EndContext();
                BeginContext(899, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53718e5b98c249948b5e35062f0e6462", async() => {
                    BeginContext(943, 42, true);
                    WriteLiteral("Home <i class=\"ion-ios-arrow-forward\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(989, 186, true);
                WriteLiteral("</span>\n                        <span>About <i class=\"ion-ios-arrow-forward\"></i></span>\n                    </p>\n                </div>\n            </div>\n        </div>\n    </section>\n");
                EndContext();
            }
            );
            BeginContext(1177, 147, true);
            WriteLiteral("\n<section class=\"ftco-section\">\n    <div class=\"container\">\n        <div class=\"row no-gutters\">\n            <div class=\"col-md-5 p-md-5 img img-2\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1324, "\"", 1389, 4);
            WriteAttributeValue("", 1332, "background-image:", 1332, 17, true);
            WriteAttributeValue(" ", 1349, "url(", 1350, 5, true);
#line 33 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 1354, Url.Content("~/images/bg_3.jpg"), 1354, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 1387, ");", 1387, 2, true);
            EndWriteAttribute();
            BeginContext(1390, 2639, true);
            WriteLiteral(@">
            </div>
            <div class=""col-md-7 wrap-about pb-md-5 ftco-animate"">
                <div class=""heading-section mb-5 pl-md-5"">
                    <div class=""pl-md-5 ml-md-5"">
                        <span class=""subheading subheading-with-line""><small class=""pr-2 bg-white"">About</small></span>
                        <h2 class=""mb-4"">We are the best Interior, Exterior &amp; Architecture Firm</h2>
                    </div>
                </div>
                <div class=""pl-md-5 ml-md-5 mb-5"">
                    <p>On her way she met a copy. The copy warned the Little Blind Text, that where it came from it would have been rewritten a thousand times and everything that was left from its origin would be the word ""and"" and the Little Blind Text should turn around and return to its own, safe country. But nothing the copy said could convince her and so it didn’t take long until a few insidious Copy Writers ambushed her, made her drunk with Longe and Parole and dragged her into their agency");
            WriteLiteral(@", where they abused her for their.</p>
                    <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove, the headline of Alphabet Village and the subline of her own road, the Line Lane. Pityful a rethoric question ran over her cheek, then she continued her way.</p>
                    <p><a href=""#"" class=""btn-custom"">Learn More <span class=""ion-ios-arrow-forward""></span></a></p>
                </div>
            </div>
        </div>
        <div class=""row mt-5 pt-4"">
            <div class=""col-md-4 ftco-animate"">
                <h3 class=""h4"">Mission</h3>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <h3 class=""h4"">Vission</h3>
                <p>A small river named Duden flows by");
            WriteLiteral(@" their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <h3 class=""h4"">Mosaic</h3>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-counter img"" id=""section-counter""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4029, "\"", 4094, 4);
            WriteAttributeValue("", 4037, "background-image:", 4037, 17, true);
            WriteAttributeValue(" ", 4054, "url(", 4055, 5, true);
#line 66 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 4059, Url.Content("~/images/bg_3.jpg"), 4059, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 4092, ");", 4092, 2, true);
            EndWriteAttribute();
            BeginContext(4095, 2916, true);
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""container"">
        <div class=""row d-md-flex align-items-center justify-content-end"">
            <div class=""col-lg-10"">
                <div class=""row d-md-flex align-items-center"">
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""18"">0</strong>
                                <span>Years of Experienced</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""351"">0</strong>
                                <span>Happy Clients</span>
                 ");
            WriteLiteral(@"           </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""564"">0</strong>
                                <span>Finished Projects</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md d-flex justify-content-center counter-wrap ftco-animate"">
                        <div class=""block-18"">
                            <div class=""text"">
                                <strong class=""number"" data-number=""300"">0</strong>
                                <span>Working Days</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section cla");
            WriteLiteral(@"ss=""ftco-section testimony-section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-3"">
            <div class=""col-md-7 heading-section ftco-animate"">
                <span class=""subheading subheading-with-line""><small class=""pr-2 bg-light"">Testimony</small></span>
                <h2 class=""mb-4"">Our satisfied customer says</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in</p>
            </div>
        </div>
        <div class=""row ftco-animate"">
            <div class=""col-md-12"">
                <div class=""carousel-testimony owl-carousel"">
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 7011, "\"", 7079, 4);
            WriteAttributeValue("", 7019, "background-image:", 7019, 17, true);
            WriteAttributeValue(" ", 7036, "url(", 7037, 5, true);
#line 122 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 7041, Url.Content("~/images/person_1.jpg"), 7041, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 7078, ")", 7078, 1, true);
            EndWriteAttribute();
            BeginContext(7080, 982, true);
            WriteLiteral(@">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <div class=""pl-5"">
                                    <p class=""name"">Garreth Smith</p>
                                    <span class=""position"">CEO Founder of Commercial Building</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 8062, "\"", 8129, 3);
            WriteAttributeValue("", 8070, "background-image:", 8070, 17, true);
            WriteAttributeValue(" ", 8087, "url(", 8088, 5, true);
#line 138 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 8092, Url.Content("~/images/person_2.jpg"), 8092, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8130, 978, true);
            WriteLiteral(@">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <div class=""pl-5"">
                                    <p class=""name"">Garreth Smith</p>
                                    <span class=""position"">CEO Founder of Interior Design</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 9108, "\"", 9175, 3);
            WriteAttributeValue("", 9116, "background-image:", 9116, 17, true);
            WriteAttributeValue(" ", 9133, "url(", 9134, 5, true);
#line 154 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 9138, Url.Content("~/images/person_3.jpg"), 9138, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9176, 965, true);
            WriteLiteral(@">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <div class=""pl-5"">
                                    <p class=""name"">Garreth Smith</p>
                                    <span class=""position"">Exterior Designer</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 10141, "\"", 10209, 4);
            WriteAttributeValue("", 10149, "background-image:", 10149, 17, true);
            WriteAttributeValue(" ", 10166, "url(", 10167, 5, true);
#line 170 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 10171, Url.Content("~/images/person_3.jpg"), 10171, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 10208, ")", 10208, 1, true);
            EndWriteAttribute();
            BeginContext(10210, 966, true);
            WriteLiteral(@">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <div class=""pl-5"">
                                    <p class=""name"">Garreth Smith</p>
                                    <span class=""position"">Landscape Designer</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 11176, "\"", 11243, 3);
            WriteAttributeValue("", 11184, "background-image:", 11184, 17, true);
            WriteAttributeValue(" ", 11201, "url(", 11202, 5, true);
#line 186 "/Users/minhduc/Desktop/MINHDUC/code/project/project/Views/Home/About.cshtml"
WriteAttributeValue("", 11206, Url.Content("~/images/person_2.jpg"), 11206, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11244, 886, true);
            WriteLiteral(@">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <div class=""pl-5"">
                                    <p class=""name"">Garreth Smith</p>
                                    <span class=""position"">System Analyst</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
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
