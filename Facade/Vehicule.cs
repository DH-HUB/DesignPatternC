using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Bridge;
using static DesignPatternC.Observer.Sujet;
using System.ComponentModel;

namespace DesignPatternC.Facade
{
    public class Vehicule
    {

        internal double prix;
        internal string photo;
        internal string marque;
        internal string modele;
        private double coutEntretienAnnuel;
        private string description;
        private CatalogueVehicules catalogue;
        private string v1;
        private int v2;
        private string v;
        private int v3;
        private string v4;

        public string Marque { get; set; }
        public string Modele { get; set; }
        public double Prix { get; set; }



        public double GetCoutEntretienAnnuel()
        {
            return coutEntretienAnnuel;
        }

        public void SetCoutEntretienAnnuel(double value)
        {
            coutEntretienAnnuel = value;
        }
        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
            catalogue.notifieObservateurs();
        }

        public double getPrix()
        {
            return prix;
        }
        public void setPrix(double prix)
        {
            this.prix = prix;
            catalogue.notifieObservateurs();
        }


        public Vehicule(string marque, string modele, double prix, string photo,string description, string catalogue)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Prix = prix;
            this.photo = photo;
            this.description = description;
            this.prix = prix;
            this.catalogue = catalogue;
        }

        public Vehicule(string v1, int v2, CatalogueVehicules catalogue)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.catalogue = catalogue;
        }

        public Vehicule(string v1, string v, int v3, string v4)
        {
            this.v1 = v1;
            this.v = v;
            this.v3 = v3;
            this.v4 = v4;
        }

        public override string ToString()
        {
            return marque + " " + modele + " - " + prix + "€ - " + photo;
        }

        internal object getCatalogue()
        {
            return catalogue;
        }

        public double CoutEntretienAnnuel { get; internal set; }
    }


}
