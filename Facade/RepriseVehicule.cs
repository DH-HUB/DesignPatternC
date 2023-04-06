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
    public class RepriseVehicule
    {
        public void demandeReprise(Vehicule vehicule)
        {
            Console.WriteLine("Demande de reprise pour le véhicule \"" + vehicule.marque + " " + vehicule.modele + "\"");
        }
    }
}
