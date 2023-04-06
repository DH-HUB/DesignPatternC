using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Adapter;
using DesignPatternC.Bridge;
using DesignPatternC.Composite;
using DesignPatternC.Facade;
using DesignPatternC.Strategy;
using static DesignPatternC.Observer.Sujet;

namespace DesignPatternC.Observer
{
    public class VueVehicule : IObservateur
    {
        private Vehicule vehicule;

        public VueVehicule(Vehicule vehicule)
        {
            this.vehicule = vehicule;
            ((CatalogueVehicules)vehicule.getCatalogue()).ajoutObservateur(this);
        }

        public void actualise()
        {
            redessine();
        }

        public void redessine()
        {
            Console.WriteLine("Affichage du véhicule : " + vehicule.getDescription() + " - " + vehicule.getPrix() + " € - " + vehicule.photo);
        }

        internal void affiche()
        {
            Console.WriteLine("Description du véhicule : " + vehicule.getDescription());
            Console.WriteLine("Prix du véhicule : " + vehicule.getPrix() + " €");
        }
    }
}
