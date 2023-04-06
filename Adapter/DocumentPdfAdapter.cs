using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternC.Adapter
{
    public class DocumentPdfAdapter : DocumentPdf
    {
        private DocumentHtml docHtml;

        public DocumentPdfAdapter(DocumentHtml docHtml)
        {
            this.docHtml = docHtml;
        }
    }
}