<<<<<<< HEAD
#pragma checksum "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab"
=======
#pragma checksum "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Index), @"mvc.1.0.view", @"/Views/Administration/Index.cshtml")]
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
#line 1 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\_ViewImports.cshtml"
using OnlineBabyshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\_ViewImports.cshtml"
using OnlineBabyshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab", @"/Views/Administration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d509ab7cbd5f1f00856129f9fe81aefbf12ecdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
  
    ViewData["Title"] = "All Users";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Users</h1>\r\n\r\n<p>\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab4727", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab4719", async() => {
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 19 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
       Write(Html.DisplayName("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 22 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
       Write(Html.DisplayName("PhoneNumber"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 25 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
       Write(Html.DisplayName("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 28 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
     foreach (var item in Model)


    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 36 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 39 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 39 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 42 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 42 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab8166", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab8144", async() => {
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 45 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 45 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
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
            WriteLiteral(" |\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab10349", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab10325", async() => {
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 46 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 46 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
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
            WriteLiteral(" |\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab12537", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0766a8dc3fa6f2f13bc95b05ea02ba5d0ab7ab12511", async() => {
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 47 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 47 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\Lexicon\Desktop\backup\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
=======
#line 51 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Index.cshtml"
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
