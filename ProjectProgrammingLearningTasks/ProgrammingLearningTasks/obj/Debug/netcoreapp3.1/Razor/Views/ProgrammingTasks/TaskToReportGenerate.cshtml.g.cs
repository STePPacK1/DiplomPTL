#pragma checksum "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92bb5721cb0222f18158d1bfba1e3df610c63e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgrammingTasks_TaskToReportGenerate), @"mvc.1.0.view", @"/Views/ProgrammingTasks/TaskToReportGenerate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92bb5721cb0222f18158d1bfba1e3df610c63e6", @"/Views/ProgrammingTasks/TaskToReportGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgrammingTasks_TaskToReportGenerate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammingLearningTasks.Models.ProgrammingTasks.TaskReportViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container bg-light p-2 border rounded-3\">\r\n    <div class=\"text-center\">\r\n        <h3>");
#nullable restore
#line 5 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <br/>\r\n    <div class=\"row\">\r\n        <div class=\"col text-start\">\r\n            <span>");
#nullable restore
#line 10 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
             Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"col text-center\">\r\n            <span>?????????????????? - ");
#nullable restore
#line 13 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                         Write(Model.Complexity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"col text-end\">\r\n            <span>");
#nullable restore
#line 16 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
             Write(Model.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <hr/>\r\n    <br/>\r\n    <div class=\"text-left\">\r\n        <h5 class=\"fw-bold\">????????????</h5>\r\n    </div>\r\n    <div>\r\n        <div class=\"mt-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
       Write(Html.Raw(Model.Text.Replace(Environment.NewLine, "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
     if (Model.InputDataText != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">?????????????? ????????????</h5>\r\n            ");
#nullable restore
#line 35 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
       Write(Html.Raw(Model.InputDataText.Replace(Environment.NewLine, "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
     if (Model.OutputDataText != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">???????????????? ????????????</h5>\r\n            ");
#nullable restore
#line 43 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
       Write(Html.Raw(Model.OutputDataText.Replace(Environment.NewLine, "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 45 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
     if (Model.Comment != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">??????????????????????</h5>\r\n            <p id=\"Comment\">\r\n                ");
#nullable restore
#line 52 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 55 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
     if (Model.TestValues.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <br/>
        <div class=""text-left"">
            <h5 class=""fw-bold"">??????????????</h5>
            <br/>
            <table class=""table"">
                <tr>
                    <th>INPUT.TXT</th>
                    <th>OUTPUT.TXT</th>
                </tr>
");
#nullable restore
#line 67 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                 foreach (var testValue in Model.TestValues)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                       Write(testValue.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                       Write(testValue.Output);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
     if (Model.NestedFiles.Any() && Model.NestedFiles != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">?????????????????? ??????????</h5>\r\n        </div>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 88 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
             foreach (var nestedFile in Model.NestedFiles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-group-item\">\r\n                    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 2684, "\"", 2706, 1);
#nullable restore
#line 91 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
WriteAttributeValue("", 2691, nestedFile.Url, 2691, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
                                                                 Write(nestedFile.FileNameWithExtension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 93 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 95 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TaskToReportGenerate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammingLearningTasks.Models.ProgrammingTasks.TaskReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
