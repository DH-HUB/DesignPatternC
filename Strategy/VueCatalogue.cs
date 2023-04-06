using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Facade;


namespace DesignPatternC.Strategy
{
    // Utilise une strat pour dessiner les véhicules
    class VueCatalogue
    {
        private IDessinCatalogue dessin;

        public VueCatalogue(IDessinCatalogue dessin)
        {
            this.dessin = dessin;
        }

        public void Dessine(List<Vehicule> vehicules)
        {
            dessin.Dessine(vehicules);
        }
    }
}