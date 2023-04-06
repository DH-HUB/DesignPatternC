using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Bridge;
using DesignPatternC.Adapter;
using DesignPatternC.Prototype;




namespace DesignPatternC.Singleton
{

    public class LiasseVierge
    {
        private const string Client = "Client ";
        private static LiasseVierge instance = null;
        private List<Adapter.Document> documents;

        public LiasseVierge()
        {
            documents = new List<Adapter.Document>();
        }

        public static LiasseVierge Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LiasseVierge();
                }
                return instance;
            }
        }

        public void ajoute(Adapter.Document doc)
        {
            documents.Add(doc);
        }

        public void retire(Adapter.Document doc)
        {
            documents.Remove(doc);
        }

        public void affiche()
        {
            foreach (Adapter.Document doc in documents)
            {
                doc.dessine();
            }
        }

        internal List<Prototype.Document> ajoute(Prototype.BonDeCommande bonDeCommande)
        {
            List<Prototype.Document> documents = new List<Prototype.Document>();
            for (int i = 0; i < 5; i++)
            {
                BonDeCommande bdc = (BonDeCommande)bonDeCommande.clone();
                bdc.setClient(Client + i);
                documents.Add(bdc);
            }
            return documents;
        }

        internal void ajoute(Prototype.DemandeImmatriculation demandeImmatriculation)
        {
            DemandeImmatriculation di = (DemandeImmatriculation)demandeImmatriculation.clone();
            di.setNomDemandeur("Hak");
            documents.Add(di as Adapter.Document);
        }

        internal void ajoute(Prototype.CertificatCession certificatCession)
        {
            CertificatCession cc = (CertificatCession)certificatCession.clone();
            cc.setNomVendeur("Hak");
            documents.Add((Adapter.Document)cc);
        }

        internal Prototype.Liasse clone()
        {
            LiasseVierge lv = LiasseVierge.Instance;
            Prototype.Liasse clone = lv.clone();
            clone.Documents = new List<Adapter.Document>();
            foreach (Prototype.Document doc in documents)
            {
                clone.ajoute(doc.clone());
            }
            return clone;
        }
    }
}