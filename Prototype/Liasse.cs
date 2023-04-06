using DesignPatternC.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Singleton;

namespace DesignPatternC.Prototype
{
    // collection de documents
    public class Liasse
    {
        private List<Document> documents;
        internal List<Adapter.Document> Documents;

        public Liasse()
        {
            documents = new List<Document>();
        }

        public void ajoute(Document doc)
        {
            documents.Add(doc);
        }

        public void retire(Document doc)
        {
            documents.Remove(doc);
        }

        public List<Document> getDocuments()
        {
            return documents;
        }
        public void setDocuments(List<Document> documents)
        {
            this.documents = documents;
        }

        public object Clone()
        {
            Liasse nouvelleLiasse = new Liasse();

            foreach (Document doc in documents)
            {
                // Clone chaque doc de la liasse
                Document nouveauDoc = (Document)doc.Clone();
                nouvelleLiasse.ajoute(nouveauDoc);
            }

            return nouvelleLiasse;
        }

        internal object remplir(Dictionary<string, string> informations)
        {
            return remplir;
        }
    }
}