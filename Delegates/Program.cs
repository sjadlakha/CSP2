using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Text = "Text of the document";

            var blogPoster = new BlogPoster();
            var blogDelegate = new Document.SendDoc(blogPoster.PostBlog);
            doc.ReportSendingResult(blogDelegate);
        }
    }
}
