#pragma checksum "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8652b585d04a4aaa927f89beef5f3687d2e9d373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\_ViewImports.cshtml"
using CMDb_Grupp10_IWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\_ViewImports.cshtml"
using CMDb_Grupp10_IWA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\_ViewImports.cshtml"
using CMDb_Grupp10_IWA.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8652b585d04a4aaa927f89beef5f3687d2e9d373", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a72938d0a012fd6425bf4df2bca1904f0cefd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--SEARCH INDEX-->                          
<!-- Search -->
<div class=""containersearch"">
    <section id=""search"">
        <div id=""searchfunction"">
            <input type=""text"" placeholder=""Enter a movie title or keyword"" id=""searchterm"" onfocus=""this.value=''""/>
            <button id=""searchbutton"" class=""button big"">Find</button>
        </div>
     </section>
");
            WriteLiteral("        <div id=\"searchresults\">\r\n            <h1 class=\"searchheader\">Search Results</h1>\r\n            <div id=\"searchcontainer\">\r\n\r\n            </div>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591