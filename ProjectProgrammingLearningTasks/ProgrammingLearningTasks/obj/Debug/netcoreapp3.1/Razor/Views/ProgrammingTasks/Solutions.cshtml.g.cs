#pragma checksum "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2dc9bc21e816cb170192ce04ea157a9948e834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgrammingTasks_Solutions), @"mvc.1.0.view", @"/Views/ProgrammingTasks/Solutions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2dc9bc21e816cb170192ce04ea157a9948e834", @"/Views/ProgrammingTasks/Solutions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgrammingTasks_Solutions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammingLearningTasks.Models.ProgrammingTasks.SolutionViewContainer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container bg-light p-2 border rounded-3\" style=\"word-wrap:break-word\">\r\n    <div class=\"text-center\">\r\n        <h3>Решение к задаче - ");
#nullable restore
#line 5 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
                          Write(Model.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 283, "\"", 334, 1);
#nullable restore
#line 6 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
WriteAttributeValue("", 290, Url.Action("Task", new {id = Model.TaskId}), 290, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">перейти к задаче</a>\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
     foreach (var solution in Model.SolutionViewModels)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"m-3 p-2 border rounded\">\r\n            <h4>\r\n                ");
#nullable restore
#line 12 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
           Write(solution.LangName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h4>\r\n            <hr/>\r\n            <p>\r\n                ");
#nullable restore
#line 16 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
           Write(solution.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <br/>\r\n            <pre class=\"brush: js\">\r\n                ");
#nullable restore
#line 20 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
           Write(solution.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </pre>\r\n");
#nullable restore
#line 22 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 942, 1);
#nullable restore
#line 25 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
WriteAttributeValue("", 882, Url.Action("EditSolution", new {solution.Id, Model.TaskId}), 882, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control btn-outline-primary text-center\" role=\"button\">Изменить решение</a>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 29 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"form-group\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1259, 1);
#nullable restore
#line 34 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
WriteAttributeValue("", 1213, Url.Action("AddSolution", new {Model.TaskId}), 1213, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control btn-primary text-decoration-none text-center\" role=\"button\">Добавить новое решение</a>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Solutions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\'text/javascript\'>SyntaxHighlighter.all();</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammingLearningTasks.Models.ProgrammingTasks.SolutionViewContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
