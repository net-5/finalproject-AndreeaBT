#pragma checksum "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e46f9ab0202709c296eba63f626c8c53e49ce7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speakers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speakers/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speakers_Details))]
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
#line 1 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e46f9ab0202709c296eba63f626c8c53e49ce7d", @"/Areas/Admin/Views/Speakers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cbfddc5984994e8dad86012996c8394c90c1314", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1468c5192c9d09d97196806c9961582ab168a746", @"/Areas/Admin/Views/Speakers/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Speakers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.SpeakersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
  
    ViewData["Title"] = "Details";
        Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(154, 86, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Speakers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(455, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(501, 38, false);
#line 22 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(539, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(603, 34, false);
#line 25 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(637, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(700, 45, false);
#line 28 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(745, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(809, 41, false);
#line 31 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(850, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(913, 44, false);
#line 34 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(957, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1021, 40, false);
#line 37 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1124, 44, false);
#line 40 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1232, 40, false);
#line 43 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1335, 43, false);
#line 46 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1442, 39, false);
#line 49 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1544, 44, false);
#line 52 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1652, 40, false);
#line 55 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1755, 41, false);
#line 58 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1860, 37, false);
#line 61 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1960, 44, false);
#line 64 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2068, 40, false);
#line 67 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2171, 41, false);
#line 70 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2276, 37, false);
#line 73 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2376, 42, false);
#line 76 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2482, 38, false);
#line 79 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2583, 43, false);
#line 82 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2626, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2690, 39, false);
#line 85 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(2729, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2792, 47, false);
#line 88 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2839, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2903, 43, false);
#line 91 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3009, 50, false);
#line 94 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3059, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3123, 46, false);
#line 97 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3169, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3232, 47, false);
#line 100 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3279, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3343, 43, false);
#line 103 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3386, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3449, 44, false);
#line 106 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3493, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3557, 40, false);
#line 109 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3597, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3660, 43, false);
#line 112 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3703, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3767, 39, false);
#line 115 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3806, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3854, 54, false);
#line 120 "C:\Users\barbu\source\repos\Last Project\Conference\Conference\Areas\Admin\Views\Speakers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3908, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3916, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e46f9ab0202709c296eba63f626c8c53e49ce7d19244", async() => {
                BeginContext(3938, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(3954, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.SpeakersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
