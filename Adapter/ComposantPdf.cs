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
    // On adapte le DocumentPdf
    public class ComposantPdf
    {
        public void pdfFixeContenu(string contenu)
        {
            Console.WriteLine("Fixe le contenu PDF : " + contenu);
        }

        public void pdfPrepareAffichage()
        {
            Console.WriteLine("Prépare l'affichage PDF");
        }

        public void pdfRaffraichit()
        {
            Console.WriteLine("Rafraîchit l'affichage PDF");
        }

        public void pdfTermineAffichage()
        {
            Console.WriteLine("Termine l'affichage PDF");
        }

        public void pdfEnvoieImprimante()
        {
            Console.WriteLine("Envoie le PDF à l'imprimante");
        }
    }

}