using DesignPatternC.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternC.Composite
{
    class SocieteSansFiliale : ISociete
    {
        private List<Vehicule> vehicules = new List<Vehicule>();
        private string v;

        public SocieteSansFiliale(string v)
        {
            this.v = v;
        }

        public void calculCoutEntretien()
        {
            Console.WriteLine("La société n'a pas de filiale et son coût d'entretien est de 8000 euros.");
        }

        public void ajouterVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
            Console.WriteLine($"Le véhicule {vehicule.Modele} a été ajouté à la société {this.v}.");
        }

        internal List<Vehicule> getListeVehicules()
        {
            return vehicules;
        }
    }
}
