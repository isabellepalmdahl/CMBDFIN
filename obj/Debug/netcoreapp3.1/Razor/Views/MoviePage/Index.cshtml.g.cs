#pragma checksum "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26454324b032b0b275a2cb2456a699395217806e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoviePage_Index), @"mvc.1.0.view", @"/Views/MoviePage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26454324b032b0b275a2cb2456a699395217806e", @"/Views/MoviePage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a72938d0a012fd6425bf4df2bca1904f0cefd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_MoviePage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--MOVIEPAGE INDEX-->\r\n<div class=\"moviepage\">\r\n    <div class=\"title\">\r\n        <h1 id=\"movietitle\">");
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                       Write(Model.Completeselectedmovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"subheader\">");
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                        Write(Model.Completeselectedmovie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <section id=\"movie\">  \r\n        <article class=\"overview\">\r\n            <div class=\"movieinfo\"\">\r\n                <div class=\"plot\">\r\n                    <h3>Plot</h3>\r\n                    <p>");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                  Write(Model.Completeselectedmovie.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <article class=\"moreinfo\">\r\n                    <div class=\"director\">\r\n                        <h3>Director:</h3>\r\n                        <p>");
#nullable restore
#line 18 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                      Write(Model.Completeselectedmovie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"released\">\r\n                        <h3>Released:</h3>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                      Write(Model.Completeselectedmovie.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"runtime\">\r\n                        <h3>Runtime:</h3>\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                      Write(Model.Completeselectedmovie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"actors\">\r\n                        <h3>Actors:</h3>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                      Write(Model.Completeselectedmovie.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </article>
                <article class=""ratingandvoting"">
                    <div class=""rating"">
                        <h3>Current Ratings</h3>
                        <p class=""subheader"">Current Cmdb Rating</p>
                        <img id=""cmdblikes"" class=""thumbsimage"" src=""/imagesfolder/thumbsup.png"" alt=""Thumbs up"" />    
                        <p id=""nrOfLikes"">");
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                                     Write(Model.Completeselectedmovie.numberOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <img id=\"cmdbdislikes\" class=\"thumbsimage\" src=\"/imagesfolder/thumbsdown.png\" alt=\"Thumbs down\" />\r\n                        <p id=\"nrOfDislikes\">");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
                                        Write(Model.Completeselectedmovie.numberOfDislikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>   
                    </div>
                    <div id=""voting"">
                        <h3>Vote</h3>
                        <p class=""subheader"">Click here to add your vote.</p>
                    </div>
                    <div>
                        <button id=""votelike"" class=""likebutton""");
            BeginWriteAttribute("value", " value=", 2267, "", 2309, 1);
#nullable restore
#line 47 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
WriteAttributeValue("", 2274, Model.Completeselectedmovie.imdbId, 2274, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">like</button>\r\n                        <button id=\"votedislike\" class=\"dislikebutton\"");
            BeginWriteAttribute("value", " value=", 2395, "", 2437, 1);
#nullable restore
#line 48 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
WriteAttributeValue("", 2402, Model.Completeselectedmovie.imdbId, 2402, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">dislike</button>\r\n                    </div>\r\n                </article>\r\n              </div>\r\n        </article>\r\n        <div>\r\n            <img id=\"moviepageimage\"");
            BeginWriteAttribute("src", " src=\"", 2605, "\"", 2646, 1);
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
WriteAttributeValue("", 2611, Model.Completeselectedmovie.Poster, 2611, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2647, "\"", 2696, 3);
            WriteAttributeValue("", 2653, "Image", 2653, 5, true);
            WriteAttributeValue(" ", 2658, "of", 2659, 3, true);
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\CMDb-Grupp10-IWA\CMDb-Grupp10-IWA\Views\MoviePage\Index.cshtml"
WriteAttributeValue(" ", 2661, Model.Completeselectedmovie.Title, 2662, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
