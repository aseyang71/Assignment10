#pragma checksum "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d360c9d5db4257e106e880cb5a7d459c0cdad9"
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
#line 1 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/_ViewImports.cshtml"
using SharpenTheSaw;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/_ViewImports.cshtml"
using SharpenTheSaw.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/_ViewImports.cshtml"
using SharpenTheSaw.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d360c9d5db4257e106e880cb5a7d459c0cdad9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a9db9745400d145c9568f0d03ed36bfada57ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark text-black", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SharpenTheSaw.Infrastructure.PaginationTagHelper __SharpenTheSaw_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>");
#nullable restore
#line 4 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
Write(ViewBag.Team);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#Id</th>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Middle Initial</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Address</th>
                <th scope=""col"">City</th>
                <th scope=""col"">State</th>
                <th scope=""col"">Zip</th>
                <th scope=""col"">Phone</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
             foreach (var x in Model.Bowlers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
#nullable restore
#line 25 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                               Write(x.BowlerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
#nullable restore
#line 26 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
                   Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 35 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d360c9d5db4257e106e880cb5a7d459c0cdad98082", async() => {
                WriteLiteral("\n");
            }
            );
            __SharpenTheSaw_Infrastructure_PaginationTagHelper = CreateTagHelper<global::SharpenTheSaw.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__SharpenTheSaw_Infrastructure_PaginationTagHelper);
#nullable restore
#line 40 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
__SharpenTheSaw_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __SharpenTheSaw_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__SharpenTheSaw_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-teamname", "SharpenTheSaw.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 41 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
__SharpenTheSaw_Infrastructure_PaginationTagHelper.KeyValuePairs["teamname"] = Model.TeamName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-teamname", __SharpenTheSaw_Infrastructure_PaginationTagHelper.KeyValuePairs["teamname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "/Users/chy2021/Projects/Assignment10/SharpenTheSaw/Views/Home/Index.cshtml"
__SharpenTheSaw_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __SharpenTheSaw_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SharpenTheSaw_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __SharpenTheSaw_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __SharpenTheSaw_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
