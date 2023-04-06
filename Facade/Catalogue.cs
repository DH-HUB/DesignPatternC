using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Bridge;

namespace DesignPatternC.Facade
{

    public class Catalogue
    {
        private List<Vehicule> vehicules = new List<Vehicule>();

        public void ajouteVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
        }

        public List<Vehicule> retrouveVehicules(double prixMin, double prixMax)
        {
            List<Vehicule> resultat = new List<Vehicule>();

            foreach (Vehicule vehicule in vehicules)
            {
                if (vehicule.prix >= prixMin && vehicule.prix <= prixMax)
                {
                    resultat.Add(vehicule);
                }
            }

            return resultat;
        }

        internal List<Vehicule> getVehicules()
        {
            return vehicules;
        }
    }
}