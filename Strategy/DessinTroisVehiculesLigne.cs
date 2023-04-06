using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Facade;



namespace DesignPatternC.Strategy
{
    // dessiner trois véhicules par ligne
    class DessinTroisVehiculesLigne : IDessinCatalogue
    {
        private string v;

        public DessinTroisVehiculesLigne(string v)
        {
            this.v = v;
        }

        public void Dessine(List<Vehicule> vehicules)
        {
            Console.WriteLine("Affichage en trois lignes : ");
            int i = 0;
            while (i < vehicules.Count)
            {
                Console.WriteLine(vehicules[i++] + "\t|\t" + ((i < vehicules.Count) ? vehicules[i++] : " ") + "\t|\t" + ((i < vehicules.Count) ? vehicules[i++] : " "));
            }
            Console.WriteLine();
        }
    }
}