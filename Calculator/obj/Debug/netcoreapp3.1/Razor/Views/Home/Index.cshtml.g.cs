#pragma checksum "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c737e28cb03472b45b5caa23131083fb0853de22"
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
#line 1 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/_ViewImports.cshtml"
using Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/_ViewImports.cshtml"
using Calculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c737e28cb03472b45b5caa23131083fb0853de22", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e67062746af1871458f784ea0458845e6ba1335d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Calculator.Models.Calculate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div>\r\n");
#nullable restore
#line 7 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
         using (Html.BeginForm("Index", "home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"firstNum\">First Number</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"firstNum\" name=\"firstNum\"");
            BeginWriteAttribute("value", " value=\"", 350, "\"", 373, 1);
#nullable restore
#line 11 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
WriteAttributeValue("", 358, Model.firstNum, 358, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"secondNum\">Second Number</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"secondNum\" name=\"secondNum\"");
            BeginWriteAttribute("value", " value=\"", 588, "\"", 612, 1);
#nullable restore
#line 16 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
WriteAttributeValue("", 596, Model.secondNum, 596, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"total\">Total</label>\r\n                <p id=\"total \">");
#nullable restore
#line 21 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
                          Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
            WriteLiteral(@"            <button type=""submit"" class=""btn btn-info"" name=""operation"" value=""add"">+</button>
            <button type=""submit"" class=""btn btn-danger"" name=""operation"" value=""sub"">-</button>
            <button type=""submit"" class=""btn btn-warning"" name=""operation"" value=""multi"">*</button>
            <button type=""submit"" class=""btn btn-default"" name=""opeeration"" value=""div"">/</button>
");
#nullable restore
#line 28 "/Users/minhazur/VSProjects/Calculator/Calculator/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Calculator.Models.Calculate> Html { get; private set; }
    }
}
#pragma warning restore 1591
