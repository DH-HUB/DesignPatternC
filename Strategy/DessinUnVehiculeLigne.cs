using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Facade;
using DesignPatternC.Bridge;
using DesignPatternC.Composite;

namespace DesignPatternC.Strategy
{
    // dessiner un seul véhicule par ligne
    class DessinUnVehiculeLigne : IDessinCatalogue
    {
        private string v;

        public DessinUnVehiculeLigne(string v)
        {
            this.v = v;
        }

        public void Dessine(List<Vehicule> vehicules)
        {
            Console.WriteLine("Affichage en une seule ligne : ");
            foreach (Vehicule v in vehicules)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }

        internal void Dessine()
        {
            throw new NotImplementedException();
        }
    }
}
