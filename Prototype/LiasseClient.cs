using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Singleton;


namespace DesignPatternC.Prototype

{
    /*construit une liasse de docs en utilisant  LiasseVierge, 
  * en ajoutant des infos avec la méthode ajouteInformation 
  * en remplissant la liasse avec ces infos avec la méthode construit.
  * Les méthodes affiche et imprime permettent respectivement
  * d'afficher et d'imprimer la liasse de documents construite*/
    internal class LiasseClient
    {

        private LiasseVierge liasseVierge;
        private Dictionary<string, string> informations;
        private Liasse liasse;

        public LiasseClient(string type)
        {
            
            LiasseVierge liasseVierge = LiasseVierge.Instance;
            informations = new Dictionary<string, string>();
        }

        public LiasseClient()
        {
        }

        public void ajouteInformation(string cle, string valeur)
        {
            informations.Add(cle, valeur);
        }

        public void construit()
        {
            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new DemandeImmatriculation());
            liasseVierge.ajoute(new CertificatCession());
            liasse = liasseVierge.clone();
            liasse.remplir(informations);
        }

        public void affiche()
        {
            foreach (Document doc in liasse.getDocuments())
            {
                doc.affiche();
            }
        }

        public void imprime()
        {
            foreach (Document doc in liasse.getDocuments())
            {
                doc.imprime();
            }
        }

        internal void creer(LiasseVierge liasseVierge)
        {
            throw new NotImplementedException();
        }
    }
}
