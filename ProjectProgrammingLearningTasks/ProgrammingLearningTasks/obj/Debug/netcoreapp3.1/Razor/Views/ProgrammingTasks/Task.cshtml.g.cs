#pragma checksum "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672b0a0827c1830b7fd54515b66bab743e0ebfb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgrammingTasks_Task), @"mvc.1.0.view", @"/Views/ProgrammingTasks/Task.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672b0a0827c1830b7fd54515b66bab743e0ebfb7", @"/Views/ProgrammingTasks/Task.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgrammingTasks_Task : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammingLearningTasks.Models.ProgrammingTasks.TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container bg-light p-2 border rounded-3\">\r\n    <div class=\"text-center\">\r\n        <h3>");
#nullable restore
#line 5 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <br/>\r\n    <div class=\"row\">\r\n        <div class=\"col text-start\">\r\n            <span>");
#nullable restore
#line 10 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
             Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"col text-center\">\r\n            <span>?????????????????? - ");
#nullable restore
#line 13 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                         Write(Model.Complexity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"col text-end\">\r\n            <span>");
#nullable restore
#line 16 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
             Write(Model.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
    </div>
    <hr/>
    <br/>
    <div class=""text-left"">
        <h5 class=""fw-bold"">????????????</h5>
    </div>
    <div>
        <div class=""mt-2"">
            <textarea id=""TextContent"" class=""form-control"" disabled>
                ");
#nullable restore
#line 27 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
           Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </textarea>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.InputDataText != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">?????????????? ????????????</h5>\r\n            <textarea id=\"InputDataTextContent\" class=\"form-control\" disabled>\r\n                ");
#nullable restore
#line 38 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
           Write(Model.InputDataText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </textarea>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.OutputDataText != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">???????????????? ????????????</h5>\r\n            <textarea id=\"OutputDataTextContent\" class=\"form-control\" disabled>\r\n                ");
#nullable restore
#line 48 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
           Write(Model.OutputDataText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </textarea>\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.Comment != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">??????????????????????</h5>\r\n            <p id=\"Comment\">\r\n                ");
#nullable restore
#line 58 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.TestValues.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">????????????</h5>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>INPUT.TXT</th>\r\n                    <th>OUTPUT.TXT</th>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                 foreach (var testValue in Model.TestValues)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                       Write(testValue.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                       Write(testValue.Output);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 85 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.ImageIds.Any() && Model.ImageIds != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">?????????????????? ????????????????????</h5>\r\n        </div>\r\n        <div class=\"row justify-content-start\">\r\n");
#nullable restore
#line 94 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
             foreach (var imageId in Model.ImageIds)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2808, "\"", 2882, 1);
#nullable restore
#line 97 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
WriteAttributeValue("", 2814, Url.Action("DownloadImage", "ProgrammingTasks", new {id = imageId}), 2814, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" cursor:pointer;\"\r\n                         onclick=\"onClick(this)\" class=\"img-thumbnail\">\r\n                </div>\r\n");
#nullable restore
#line 100 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div id=""modal01"" class=""w3-modal"" onclick=""this.style.display='none'"">
            <span class=""w3-button w3-hover-red w3-xlarge w3-display-topright"">&times;</span>
            <div class=""w3-modal-content w3-animate-zoom"">
                <img id=""img01"" style=""width:100%"">
            </div>
        </div>
");
#nullable restore
#line 108 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.NestedFiles.Any() && Model.NestedFiles != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <div class=\"text-left\">\r\n            <h5 class=\"fw-bold\">?????????????????? ?????????? ?????? ????????????????</h5>\r\n        </div>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 116 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
             foreach (var nestedFile in Model.NestedFiles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-group-item\">\r\n                    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 3774, "\"", 3840, 1);
#nullable restore
#line 119 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
WriteAttributeValue("", 3781, Url.Action("DownloadNestedFile", new {id = nestedFile.Id}), 3781, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
                                                                                                             Write(nestedFile.FileNameWithExtension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 121 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 123 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 3960, "\"", 4025, 1);
#nullable restore
#line 125 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
WriteAttributeValue("", 3967, Url.Action("DownloadDocxReport", new {taskId = Model.Id}), 3967, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mb-3 form-control\" role=\"button\">?????????????? ???????????? ?? ?????????????? docx</a>\r\n");
#nullable restore
#line 126 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (Model.HasSolutions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4180, "\"", 4236, 1);
#nullable restore
#line 129 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
WriteAttributeValue("", 4187, Url.Action("Solutions", new {taskId = Model.Id}), 4187, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-3 form-control bg-myHeaderBg\" role=\"button\">?????????????? ?? ????????????????</a>\r\n");
#nullable restore
#line 130 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4400, "\"", 4451, 1);
#nullable restore
#line 134 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
WriteAttributeValue("", 4407, Url.Action("EditTask", new {id = Model.Id}), 4407, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary mb-3 form-control\" role=\"button\">????????????????/?????????????????? ????????????</a>\r\n");
#nullable restore
#line 135 "C:\Users\ilya0\Desktop\ProjectProgrammingLearningTasks\ProgrammingLearningTasks\Views\ProgrammingTasks\Task.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://www.w3schools.com/w3css/4/w3.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            let text = $('#Comment').text();
            let newText = linkify(text);
            $('#Comment').html(newText);
            
            autoResizeTextArea('TextContent');
            autoResizeTextArea('OutputDataTextContent');
            autoResizeTextArea('InputDataTextContent');
            
            function autoResizeTextArea(id) {
                let textContentElem = document.getElementById(id);
                textContentElem.style.height = ""1px"";
                textContentElem.style.height = (5+textContentElem.scrollHeight)+""px"";
                textContentElem.style.resize = ""none"";
                textContentElem.style.backgroundColor = ""#f8f9fa"";
                textContentElem.style.border = 0;
            }
            
            function linkify(text) {
                let urlRegex = /(\b(https?|ftp|file):\/\/[-A-Z0-9+&");
                WriteLiteral("@#\\/%?=~_|!:,.;]*[-A-Z0-9+&");
                WriteLiteral(@"@#\/%=~_|])/ig;
                return text.replace(urlRegex, function (url) {
                    return '<a href=""' + url + '"">' + url + '</a>';
                });           
            }
        });
    
        function onClick(element) {
            document.getElementById(""img01"").src = element.src;
            document.getElementById(""modal01"").style.display = ""block"";
        }
        
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammingLearningTasks.Models.ProgrammingTasks.TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
