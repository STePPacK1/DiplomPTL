#pragma checksum "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TopicTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ea1c57c7a7e0a7cdf761bda72e1c23a54bc5d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgrammingTasks_TopicTasks), @"mvc.1.0.view", @"/Views/ProgrammingTasks/TopicTasks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ea1c57c7a7e0a7cdf761bda72e1c23a54bc5d9", @"/Views/ProgrammingTasks/TopicTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgrammingTasks_TopicTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammingLearningTasks.Models.ProgrammingTasks.TopicTaskIdModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bg-light p-2 border rounded-3\">\r\n");
#nullable restore
#line 4 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TopicTasks.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 210, "\"", 266, 1);
#nullable restore
#line 7 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TopicTasks.cshtml"
WriteAttributeValue("", 217, Url.Action("DeleteTopic", new { id = Model.Id }), 217, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bgDanger m-2 col\" role=\"button\">Удалить тему</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 343, "\"", 400, 1);
#nullable restore
#line 8 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TopicTasks.cshtml"
WriteAttributeValue("", 350, Url.Action("AddTask", new { topicId = Model.Id }), 350, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-myHeaderBg m-2 col\" role=\"button\">Создать задачу</a>\r\n        </div>\r\n");
#nullable restore
#line 10 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\TopicTasks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <hr />
    <h4>Список задач</h4>
    <hr />
    <table id=""tasksTable"" class=""display"">
        <thead>
            <tr>
                <th>Номер задачи</th>
                <th>Название</th>
                <th>Автор</th>
                <th>Сложность</th>
                <th>Дата создания</th>
                <th>Ссылка на задачу</th>
            </tr>
        </thead>
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammingLearningTasks.Models.ProgrammingTasks.TopicTaskIdModel> Html { get; private set; }
    }
}
#pragma warning restore 1591