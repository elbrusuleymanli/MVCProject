#pragma checksum "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00422cc2bdf22de8ed7600dd19ae7422bf71cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00422cc2bdf22de8ed7600dd19ae7422bf71cb3", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f4f34ecde63e925e73ef18d98496afb4480b3b", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("BgImage", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
     foreach (var banner in Model.AboutBanners)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <style>\r\n\r\n\r\n            .banner-area {\r\n                background: url(\'../img/banner/");
#nullable restore
#line 14 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                          Write(banner.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\') !important;\r\n        </style>\r\n");
#nullable restore
#line 16 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
");
#nullable restore
#line 26 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                             foreach (var item in Model.AboutBanners)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 28 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                               Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- About Start -->
<div class=""about-area pt-145 pb-155"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 43 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
             foreach (var item in Model.AboutEduHomes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <div class=\"about-content\">\r\n                        <h2>");
#nullable restore
#line 47 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                       Write(item.TitleOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 47 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                            Write(item.TitleSecond);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                        <p>");
#nullable restore
#line 48 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                      Write(item.DescUp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"hidden-sm\">");
#nullable restore
#line 49 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                        Write(item.DescDown);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00422cc2bdf22de8ed7600dd19ae7422bf71cb310479", async() => {
#nullable restore
#line 50 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                                                     Write(item.Button);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"about-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b00422cc2bdf22de8ed7600dd19ae7422bf71cb312310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1712, "~/img/about/", 1712, 12, true);
#nullable restore
#line 55 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1724, item.Image, 1724, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- About End -->
<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b00422cc2bdf22de8ed7600dd19ae7422bf71cb314410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>meet our teachers</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 76 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
             foreach (var item in Model.AboutTeachers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"single-teacher\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00422cc2bdf22de8ed7600dd19ae7422bf71cb316119", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b00422cc2bdf22de8ed7600dd19ae7422bf71cb316336", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2623, "~/img/teacher/", 2623, 14, true);
#nullable restore
#line 81 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2637, item.Image, 2637, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2><a href=\"teacher-details.html\">");
#nullable restore
#line 84 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <h4>Associate Professor</h4>\r\n                            <ul>\r\n                                <li><a href=\"https://www.facebook.com/devitems/?ref=bookmarks\">");
#nullable restore
#line 87 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                                                          Write(Html.Raw(item.Facebook));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"https://www.pinterest.com/devitemsllc/\">");
#nullable restore
#line 88 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                                                Write(Html.Raw(item.Pinterest));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"#\">");
#nullable restore
#line 89 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                           Write(Html.Raw(item.Vimeo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"https://twitter.com/devitemsllc\">");
#nullable restore
#line 90 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
                                                                         Write(Html.Raw(item.Twitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 95 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n<!-- Testimonial Area Start -->\r\n  ");
#nullable restore
#line 104 "C:\Users\HP\Desktop\MVCProject\MVCProject\Views\About\Index.cshtml"
Write(await Html.PartialAsync("_TestimonialPartialView", Model.Testimonials));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Testimonial Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=fkoEj95puX0"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 2021</h4>
 ");
            WriteLiteral(@"                           <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2021</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2021</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 2021</h4>
                            <p>I must explain to you how all thi");
            WriteLiteral(@"s mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2021</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2021</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591