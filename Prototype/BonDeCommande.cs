using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternC.Prototype
{
    public class BonDeCommande : Document
    {
        private string contenu;
        private object client;
        private object date;
        private object montant;

        public override void imprime()
        {
            Console.WriteLine("Impression du bon de commande");
        }

        public override void affiche()
        {
            Console.WriteLine("Affichage du bon de commande");
        }

        public override void remplir(Dictionary<string, string> informations)
        {
            // Remplir les champs du bon de commande avec les informations fournies
            Console.WriteLine("Remplissage du bon de commande");
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }

        internal BonDeCommande clone()
        {
            BonDeCommande bonDeCommandeClone = new BonDeCommande();
            bonDeCommandeClone.setClient(this.client);
            bonDeCommandeClone.setMontant(this.montant);
            bonDeCommandeClone.setDate(this.date);
            return bonDeCommandeClone;
        }

        private void setMontant(object montant)
        {
            this.montant = Convert.ToDouble(montant);
        }

        private void setDate(object date)
        {
            this.date = Convert.ToDateTime(date);
        }

        private void setClient(object client)
        {
            this.client = Convert.ToString(client);
        }

        internal void setClient(string v)
        {
            this.client = v;
        }
    }
}

