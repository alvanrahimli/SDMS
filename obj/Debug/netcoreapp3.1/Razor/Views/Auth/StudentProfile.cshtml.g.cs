#pragma checksum "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b99d90d5b02797bf4abc5cc483301ca45348851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_StudentProfile), @"mvc.1.0.view", @"/Views/Auth/StudentProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b99d90d5b02797bf4abc5cc483301ca45348851", @"/Views/Auth/StudentProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f562ccb195649efefbdb395e4fb2524d9a263c3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_StudentProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDMS.Models.Dtos.StudentReturnDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"card\" style=\"width: 50%;\">\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">\n                Name: ");
#nullable restore
#line 10 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n            <h6 class=\"card-subtitle mb-2\">\n                Email: ");
#nullable restore
#line 13 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h6>\n            <h6 class=\"card-subtitle mb-2\">\n                Speciality: ");
#nullable restore
#line 16 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                       Write(Model.SpecialityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h6>\n            <p class=\"card-text\">\n                Details: ");
#nullable restore
#line 19 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                    Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n            \n        </div>\n    </div>\n    <br>\n    <hr>\n    <h2>Current courses:</h2>\n");
#nullable restore
#line 27 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
     foreach (var course in Model.CurrentCourses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 50%; margin-top: 20px;\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">Name: ");
#nullable restore
#line 31 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                                        Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <h6 class=\"card-subtitle mb-2 text-muted\">\n                    Credit: <strong>");
#nullable restore
#line 33 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                               Write(course.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                    Absence limit: <strong>");
#nullable restore
#line 34 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                                      Write(course.AbsenceLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                </h6>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1125, 1);
#nullable restore
#line 36 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
WriteAttributeValue("", 1105, course.SyllabusPath, 1105, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Syllabus</a>\n                <a href=\"#\" class=\"card-link\">");
#nullable restore
#line 37 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
                                         Write(course.Teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                <a href=\"#\" class=\"card-link\">Go to course info</a>\n            </div>\n        </div>\n");
#nullable restore
#line 41 "/home/alvan/Projects/SDMS/Views/Auth/StudentProfile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDMS.Models.Dtos.StudentReturnDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
