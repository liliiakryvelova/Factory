#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21590f191ba9fa37f628e469fa55cbda892505d4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21590f191ba9fa37f628e469fa55cbda892505d4", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Dr. Sillystringz's Factory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Dr. Sillystringz's Factory</h1>
</div>
<div class=""row"">
    <div class=""col-md-3"">
        <h2>Welcome to Dr. Sillystringz's Factory</h2>
        <p>Dr. Sillystringz's Factory is a sample application that
        demonstrates how to use Entity Framework 6 in an 
        ASP.NET MVC 5 web application.</p>
    </div>
    <div class=""col-md-3"">
      <p>");
#nullable restore
#line 19 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
    Write(Html.ActionLink("See all Engineers", "Index", "Engineers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <p>");
#nullable restore
#line 22 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
      Write(Html.ActionLink("Create a new Engineer", "Create", "Engineers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <hr />\r\n        <p>");
#nullable restore
#line 24 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
      Write(Html.ActionLink("Add a new Machine", "Create", "Machines"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <hr />\r\n        <p>");
#nullable restore
#line 26 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
      Write(Html.ActionLink("All Engineers and Machines", "AllEngineerMachine", "Engineers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <p>");
#nullable restore
#line 29 "C:\Users\lilia\Epicodus\ASP.NET\Factory\Factory\Views\Home\Index.cshtml"
      Write(Html.ActionLink("See all Machines", "Index", "Machines"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
