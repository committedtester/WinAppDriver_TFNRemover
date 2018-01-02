using System;
using System.IO;
using System.Text;
using iTextSharp.text.pdf;

namespace WinAppDriver_TFNRemover.MethodController
{
    class PDFMethods
    {
        public static void ConvertPDFToText(string PDFName)
        {
            if (!File.Exists(PDFName)) return;
            var output = Path.ChangeExtension(PDFName, ".txt"); 

            var bytes = File.ReadAllBytes(PDFName);
            File.WriteAllText(output, ConvertToText(bytes), Encoding.UTF8);
        }


        private static string ConvertToText(byte[] bytes)
        {
            var sb =new StringBuilder();

            try
            {
                var reader = new PdfReader(bytes);
                var numberOfPages = reader.NumberOfPages;

                for (var currentPageIndex = 1; currentPageIndex <= numberOfPages; currentPageIndex++)
                {
                    sb.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, currentPageIndex));
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return sb.ToString();

        }
    }
}
