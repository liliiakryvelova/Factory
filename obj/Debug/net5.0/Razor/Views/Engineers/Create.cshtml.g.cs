#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1513297dc42206e03a79cca365efdb961b3c82ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Create), @"mvc.1.0.view", @"/Views/Engineers/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1513297dc42206e03a79cca365efdb961b3c82ce", @"/Views/Engineers/Create.cshtml")]
    public class Views_Engineers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a new engineer</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
Write(Html.LabelFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
Write(Html.TextBoxFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add new engineer\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 15 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 16 "C:\Users\lilia\Epicodus\ASP.NET\resubmission\Factory\Views\Engineers\Create.cshtml"
Write(Html.ActionLink("Show all engineers", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
