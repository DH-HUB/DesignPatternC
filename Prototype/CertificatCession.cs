using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternC.Prototype
{
    public class CertificatCession : Document
    {
        private string contenu;
        private string nomVendeur;

        public override void imprime()
        {
            Console.WriteLine("Impression du certificat de cession");
        }

        public override void affiche()
        {
            Console.WriteLine("Affichage du certificat de cession");
        }

        public override void remplir(Dictionary<string, string> informations)
        {
            // Rempli les champs du CC avec les infos fournies
            Console.WriteLine("Remplissage du certificat de cession");
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
        /*Renvoie  copie de l'objet CertificatCession en cours avec la méthode MemberwiseClone() qui effectue une copie superficielle de l'objet*/
        internal CertificatCession clone()
        {
            return (CertificatCession)this.MemberwiseClone();
        }
        /*Modifie la valeur de l'attribut nomVendeur.*/
        internal void setNomVendeur(string v)
        {
            this.nomVendeur = v;
        }
    }
}