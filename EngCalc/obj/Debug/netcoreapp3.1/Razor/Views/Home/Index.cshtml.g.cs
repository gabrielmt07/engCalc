#pragma checksum "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1217a0b6a12f7320afb13445607b40afe6f036"
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
#line 1 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\_ViewImports.cshtml"
using EngCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\_ViewImports.cshtml"
using EngCalc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1217a0b6a12f7320afb13445607b40afe6f036", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a5ade6c27ef01a0776bc7c61182f4feb8f70cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaractGeom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Somar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1217a0b6a12f7320afb13445607b40afe6f0363955", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <b>Largura: </b>
            <input name=""width"" id=""width"" type=""text"" />
            <b>m</b>
        </div>
        <div class=""form-group"">
            <b>Altura: </b>
            <input name=""height"" id=""height"" type=""text"" />
            <b>m</b>
        </div>
        <button class=""btn btn-primary"">Calcular</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"alert alert-danger\" role=\"alert\">Área = ");
#nullable restore
#line 25 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                       Write(Model.area.ToString("N3", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m<sup>2</sup></div>\r\n        <div class=\"alert alert-warning\" role=\"alert\">Inércia = ");
#nullable restore
#line 26 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                           Write(Model.inercia.ToString("N3", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m<sup>4</sup></div>\r\n        <div class=\"alert alert-success\" role=\"alert\">Ws = ");
#nullable restore
#line 27 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                      Write(Model.wS.ToString("N3", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m<sup>3</sup></div>\r\n        <div class=\"alert alert-primary\" role=\"alert\">Wi = ");
#nullable restore
#line 28 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                      Write(Model.wI.ToString("N3", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m<sup>3</sup></div>\r\n        <script>\r\n            document.getElementById(\"width\").value = ");
#nullable restore
#line 30 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                Write(Model.width.ToString(System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            document.getElementById(\"height\").value = ");
#nullable restore
#line 31 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
                                                 Write(Model.height.ToString(System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </script>\r\n");
#nullable restore
#line 33 "C:\Users\GABRIEL\source\repos\EngCalc\EngCalc\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaractGeom> Html { get; private set; }
    }
}
#pragma warning restore 1591