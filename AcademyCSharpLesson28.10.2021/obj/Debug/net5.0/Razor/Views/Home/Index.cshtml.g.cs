#pragma checksum "C:\Users\ibrag\source\repos\AcademyCSharpLessons\AcademyCSharpLesson28.10.2021\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736322d759bc0f4da7d384cadefd93383a101eda"
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
#line 1 "C:\Users\ibrag\source\repos\AcademyCSharpLessons\AcademyCSharpLesson28.10.2021\Views\_ViewImports.cshtml"
using MVCproj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrag\source\repos\AcademyCSharpLessons\AcademyCSharpLesson28.10.2021\Views\_ViewImports.cshtml"
using MVCproj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"736322d759bc0f4da7d384cadefd93383a101eda", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ef2870e9aff55a8f7c13acb8fb658b320d1b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ibrag\source\repos\AcademyCSharpLessons\AcademyCSharpLesson28.10.2021\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

    var list = new List<string>() { "one", "two", "three" };

#line default
#line hidden
#nullable disable
            WriteLiteral("Hello to Academy\n\n<h4 style=\"color:red\">Hello Click on Products in superMarket ");
#nullable restore
#line 10 "C:\Users\ibrag\source\repos\AcademyCSharpLessons\AcademyCSharpLesson28.10.2021\Views\Home\Index.cshtml"
                                                        Write(currentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
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
