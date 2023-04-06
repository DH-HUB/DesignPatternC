using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Facade;
using DesignPatternC.Bridge;



namespace DesignPatternC.Adapter
{
    public class DocumentPdf : Document
    {
        private ComposantPdf outilPdf = new ComposantPdf();
        private string contenu;

        public void setContenu(string contenu)
        {
            this.contenu = contenu;
            outilPdf.pdfFixeContenu(contenu);
        }

        public void dessine()
        {
            outilPdf.pdfPrepareAffichage();
            outilPdf.pdfRaffraichit();
            outilPdf.pdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.pdfEnvoieImprimante();
        }
    }
}