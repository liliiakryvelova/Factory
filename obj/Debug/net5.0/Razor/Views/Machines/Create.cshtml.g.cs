#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3140fd4d4c3b9d5d7da4c22fd6f07ba584c299e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Create), @"mvc.1.0.view", @"/Views/Machines/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3140fd4d4c3b9d5d7da4c22fd6f07ba584c299e", @"/Views/Machines/Create.cshtml")]
    public class Views_Machines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a new Machine</h4>\r\n");
#nullable restore
#line 8 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
Write(Html.LabelFor(model => model.MachineName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
Write(Html.TextBoxFor(model => model.MachineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br />\r\n");
            WriteLiteral("  <hr />\r\n  <input type=\"submit\" value=\"Add new stylist\" />\r\n");
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Machines\Create.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591