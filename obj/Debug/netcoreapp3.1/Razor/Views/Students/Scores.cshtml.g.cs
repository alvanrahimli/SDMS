#pragma checksum "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88564748069960d9f8f0964cae4d83371f6638b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Scores), @"mvc.1.0.view", @"/Views/Students/Scores.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Models.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using SDMS.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alvan/Projects/SDMS/Views/_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88564748069960d9f8f0964cae4d83371f6638b4", @"/Views/Students/Scores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f562ccb195649efefbdb395e4fb2524d9a263c3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Scores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
  
    Layout = "_Layout";
    var scores = (ViewBag.Scores as List<Score>);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 6 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
     if(scores.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\n            No records found\n        </div>\n");
#nullable restore
#line 11 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-stripped"">
        <thead>
            <tr>
                <td>No</td>
                <td scope=""col"">Score</td>
                <td scope=""col"">Course</td>
                <td scope=""col"">Date</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
             for (int i = 0; i < scores.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
#nullable restore
#line 25 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
#nullable restore
#line 26 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
                   Write(scores[i].ScoreOver100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
                   Write(scores[i].Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
                   Write(scores[i].Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 30 "/home/alvan/Projects/SDMS/Views/Students/Scores.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
