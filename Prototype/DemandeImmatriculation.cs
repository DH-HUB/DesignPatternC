using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternC.Prototype
{
    public class DemandeImmatriculation : Document
    {
        private string contenu;
        private string nomDemandeur;

        public override void imprime()
        {
            Console.WriteLine("Impression de la demande d'immatriculation");
        }

        public override void affiche()
        {
            Console.WriteLine("Affichage de la demande d'immatriculation");
        }

        public override void remplir(Dictionary<string, string> informations)
        {
            // Rempli les champs de la demande immat avec les informations fournies
            Console.WriteLine("Remplissage de la demande d'immatriculation");

        }
        // Met impl en utilisant la méthode MemberwiseClone() qui effectue une copie superficielle de l'objet.
        public override object Clone()
        {
            return MemberwiseClone();
        }
       /*crée  une copie superficielle 
        * de l'objet  en utilisant la méthode Clone(), 
        * puis appelle la méthode setNomDemandeur() 
        * pour copier la valeur de l'attribut nomDemandeur dans l'objet clone.*/
        internal DemandeImmatriculation clone()
        {
            DemandeImmatriculation clone = (DemandeImmatriculation)this.Clone();
            clone.setNomDemandeur(this.nomDemandeur);
            return clone;
        }
        /* affecte la valeur de l'argument v à l'attribut nomDemandeur de l'objet courant.*/
        private void setNomDemandeur(object nomDemandeur)
        {
            throw new NotImplementedException();
        }

        internal void setNomDemandeur(string v)
        {
            this.nomDemandeur = v;
        }
    }
}
