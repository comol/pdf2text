
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

string resulttext = "";

using (PdfDocument document = PdfDocument.Open(Environment.GetCommandLineArgs()[1]))
{
    
    foreach (Page page in document.GetPages())
    {
        resulttext = resulttext + page.Text;
    }
}

File.WriteAllText(Environment.GetCommandLineArgs()[2], resulttext);
