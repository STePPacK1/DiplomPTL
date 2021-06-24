using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using HtmlToOpenXml;

namespace ProgrammingLearningTasks.Utils
{
    public class WordGenerator
    {
        public static byte[] HtmlToWord(string html)
        {
            using var generatedDocument = new MemoryStream();
            using (var package = WordprocessingDocument.Create(
                generatedDocument, WordprocessingDocumentType.Document))
            {
                var mainPart = package.MainDocumentPart;
                if (mainPart == null)
                {
                    mainPart = package.AddMainDocumentPart();
                    new Document(new Body()).Save(mainPart);
                }

                var converter = new HtmlConverter(mainPart);
                var body = mainPart.Document.Body;

                var paragraphs = converter.Parse(html);
                foreach (var t in paragraphs)
                {
                    body.Append(t);
                }

                mainPart.Document.Save();
            }

            return generatedDocument.ToArray();
        }
    }
}