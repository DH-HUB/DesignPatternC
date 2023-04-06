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
    public class DocumentHtml : Document
    {
        private string contenu;

        public void setContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public void dessine()
        {
            Console.WriteLine("Dessine le document HTML : " + contenu);
        }

        public void imprime()
        {
            Console.WriteLine("Imprime le document HTML : " + contenu);
        }

        public string Contenu()
        {
            return contenu;
        }
    }
}